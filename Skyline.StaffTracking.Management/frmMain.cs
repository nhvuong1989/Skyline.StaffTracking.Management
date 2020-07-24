using Dapper;
using Newtonsoft.Json;
using Syncfusion.Presentation;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Device.Location;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using IFill = Syncfusion.Presentation.IFill;
using IShape = Syncfusion.Presentation.IShape;

namespace Skyline.StaffTracking.Management
{
    public partial class frmMain : Form
    {
        List<FieldResult> fieldResults = new List<FieldResult>();
        List<FieldResultDetail> fieldResultDetails = new List<FieldResultDetail>();
        //const string ConnnectionString = "Data Source=SGN1LAP017\\SQLEXPRESS01;Initial Catalog=Tracking;Integrated Security=True;";
        const string ConnnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Tracking;User ID=sa;Password=MinhTriet123;Connect Timeout=180;";
        public frmMain()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            using (DbConnection sql = new SqlConnection(ConnnectionString))
            {
                sql.Open();

                var result = await sql.QueryMultipleAsync("spSearchField",
                    param: new
                    {
                        CurrentDate = dtpDateAction.Value
                    },
                commandType: System.Data.CommandType.StoredProcedure);
                fieldResults = result.Read<FieldResult>().ToList();
                fieldResultDetails = result.Read<FieldResultDetail>().ToList();
                sql.Close();
            }

            foreach (var itm in fieldResults)
            {
                itm.ShiftWork = "C";
                if (itm.StartTime.Hour < 13 && itm.EndTime.Hour < 13)
                    itm.ShiftWork = "S";
                itm.Distance = GetInstance(itm.RestaurantFieldId, fieldResultDetails) / 1000;
            }
            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.DataSource = fieldResults;
        }

        private double GetInstance(int id, List<FieldResultDetail> fieldResultDetails)
        {
            List<Position> positions = new List<Position>();
            foreach (var itm in fieldResultDetails.Where(p => p.RestaurantFieldId == id && p.Distance != null).OrderBy(p => p.DateCreated))
            {
                List<Position> temp = JsonConvert.DeserializeObject<List<Position>>(itm.Distance);
                positions.AddRange(temp);
            }

            double distance = 0;
            for (int i = 0; i < positions.Count - 1; i++)
            {
                distance += new GeoCoordinate(positions[i].Latitude, positions[i].Longitude).GetDistanceTo(new GeoCoordinate(positions[i + 1].Latitude, positions[i + 1].Longitude));
            }
            return distance;
        }

        private void ExportTemplate(int fieldId, string filePath)
        {
            try
            {
                IPresentation pptxDoc = Presentation.Open(@"Templates\Report.pptx");

                Syncfusion.Drawing.Image image = null;

                List<FieldResultDetail> fieldResultDetail = fieldResultDetails.Where(p => p.RestaurantFieldId == fieldId
                && !string.IsNullOrWhiteSpace(p.AttachPath)).ToList();
                //Adds a blank slide to Presentation
                int idxImg = 0;
                var field = fieldResults.FirstOrDefault(p => p.RestaurantFieldId == fieldId);
                string shiftWork = "C";
                if (field.StartTime.Hour < 12)
                {
                    shiftWork = "S";
                }
                for (int idx = 1; idx < pptxDoc.Slides.Count; idx++)
                {
                    ISlide itmSlide = pptxDoc.Slides[idx];
                    if (idx < pptxDoc.Slides.Count - 1)
                    {
                        //Adds normal shape to slide
                        foreach (IShape itmShap in itmSlide.Shapes.OrderBy(p => p.ShapeName))
                        {
                            if (itmShap.ShapeName.Contains("header"))
                            {
                                //xu ly replace
                                ITextBody textBody = itmShap.TextBody;
                                textBody.Text = textBody.Text.Replace("Localtion", field.LocationName);
                                textBody.Text = textBody.Text.Replace("ActionDate", field.StartTime.ToString("yyyy-MM-dd"));
                                if (field.StartTime.Hour < 13)
                                    textBody.Text = textBody.Text.Replace("Shift", "Ca Sáng");
                                else
                                    textBody.Text = textBody.Text.Replace("Shift", "Ca Chiều");

                                textBody.Text = textBody.Text.Replace("WorkingTime", $"{field.StartTime.ToString("HH:mm")} - {field.StartTime.ToString("HH:mm")}");
                            }
                            else
                            {
                                if (idxImg <= fieldResultDetail.Count - 1 && !string.IsNullOrEmpty(fieldResultDetail[idxImg].AttachPath))
                                {
                                    using (Stream stream = new FileStream(fieldResultDetail[idxImg].AttachPath, FileMode.Open))
                                    {
                                        image = Syncfusion.Drawing.Image.FromStream(stream);
                                    }
                                    IFill lineFormat = itmShap.Fill;
                                    lineFormat.FillType = FillType.Picture;
                                    lineFormat.PictureFill.ImageBytes = image.ImageData;
                                }
                                else
                                {
                                    break;
                                }
                                idxImg++;
                            }
                        }
                    }
                    else
                    {
                        //lay duong dan folder.
                        //search image
                        string folder = fieldResultDetail[0].AttachPath.Substring(0, fieldResultDetail[0].AttachPath.LastIndexOf(@"\"));
                        string[] fileResults = Directory.GetFiles(folder, $"ketqua_{shiftWork}*");
                        idxImg = 0;
                        foreach (IShape itmShap in itmSlide.Shapes.OrderBy(p => p.ShapeName))
                        {
                            if (itmShap.ShapeName.Contains("header"))
                            {
                                ITextBody textBody = itmShap.TextBody;
                                textBody.Text = textBody.Text.Replace("Localtion", field.LocationName);
                                textBody.Text = textBody.Text.Replace("ActionDate", field.StartTime.ToString("yyyy-MM-dd"));
                                if (field.StartTime.Hour < 13)
                                    textBody.Text = textBody.Text.Replace("Shift", "Ca Sáng");
                                else
                                    textBody.Text = textBody.Text.Replace("Shift", "Ca Chiều");
                                textBody.Text = textBody.Text.Replace("WorkingTime", $"{field.StartTime.ToString("HH:mm")} - {field.StartTime.ToString("HH:mm")}");

                                //xu ly replace
                            }
                            else
                            {
                                using (Stream stream = new FileStream(fileResults[idxImg], FileMode.Open))
                                {
                                    image = Syncfusion.Drawing.Image.FromStream(stream);
                                }
                                IFill lineFormat = itmShap.Fill;
                                lineFormat.FillType = FillType.Picture;
                                lineFormat.PictureFill.ImageBytes = image.ImageData;
                                idxImg++;
                            }
                        }
                    }
                }

                pptxDoc.Save(filePath);
                pptxDoc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private int ConvertToInt(object value)
        {
            int result = 0;
            if (value == null)
                return result;

            int.TryParse(value.ToString(), out result);
            return result;
        }

        private void exportReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows?.Count <= 0)
            {
                return;
            }
            int fieldId = ConvertToInt(dgvEmployee.SelectedRows[0].Cells[colRestaurantFieldId.Index].Value);

            string filePath = "";
            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "PowerPoint Presentations|*.pptx;";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFile.FileName;
                    ExportTemplate(fieldId, filePath);
                }
            }
        }

        private void dgvEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvEmployee.HitTest(e.X, e.Y);
                dgvEmployee.ClearSelection();
                dgvEmployee.Rows[hti.RowIndex].Selected = true;
            }
        }

        private void btnRestaurant_Click(object sender, EventArgs e)
        {
            frmRestaurant frm = new frmRestaurant();
            frm.ShowDialog();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "Excel |*.xlsx;";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    using (ExcelEngine excelEngine = new ExcelEngine())
                    {
                        //Initialize Application
                        IApplication application = excelEngine.Excel;

                        //Set default version for application
                        application.DefaultVersion = ExcelVersion.Excel2013;

                        //Create a new workbook
                        IWorkbook workbook = application.Workbooks.Create(1);

                        //Accessing first worksheet in the workbook
                        IWorksheet worksheet = workbook.Worksheets[0];

                        string[] header = typeof(FieldResult).GetProperties()
                            .Select(p => Attribute.IsDefined(p, typeof(DescriptionAttribute)) ?
                                        (Attribute.GetCustomAttribute(p, typeof(DescriptionAttribute)) as DescriptionAttribute).Description : p.Name
                            ).ToArray();

                        header = header.Where((p, idx) => idx >= 0).ToArray();
                        //Import data from DataGridView control
                        worksheet.ImportArray(header, 1, 1, false);
                        worksheet.ImportData(fieldResults, 2, 1, false);

                        MemoryStream stream = new MemoryStream();

                        workbook.SaveAs(stream);
                        //Save the workbook
                        using (FileStream sw = new FileStream(saveFile.FileName, FileMode.Create, FileAccess.Write))
                        {
                            stream.Position = 0;
                            stream.CopyTo(sw);
                        }
                    }
                }
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            List<FieldSummary> fieldSummaries = fieldResults.GroupBy(p => new { p.LocationName, p.ShiftWork }, (key, g) => new FieldSummary
            {
                LocationName = key.LocationName,
                ShiftWork = key.ShiftWork,
                DinstanceSum = g.Sum(s => s.Distance),
                VisitShop = 0
            }).ToList();

            for (int i = 0; i < fieldSummaries.Count; i++)
            {
                if (fieldSummaries[i].ShiftWork == "S")
                {
                    fieldSummaries[i].VisitShop = fieldResultDetails.Count(p =>
                    fieldResults.Any(t =>
                    t.LocationName == fieldSummaries[i].LocationName
                    && t.RestaurantFieldId == p.RestaurantFieldId
                    && p.DateCreated.Hour < 12
                    ));
                }
                else
                {
                    fieldSummaries[i].VisitShop = fieldResultDetails.Count(p =>
                        fieldResults.Any(t =>
                        t.LocationName == fieldSummaries[i].LocationName
                        && t.RestaurantFieldId == p.RestaurantFieldId
                        && p.DateCreated.Hour > 12
                        ));
                }
            }

            frmSummary frm = new frmSummary(fieldSummaries);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }
    }
}
