using Dapper;
using Newtonsoft.Json;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyline.StaffTracking.Management
{
    public partial class frmRestaurant : Form
    {
        string selectedProvice;
        const string ConnnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Tracking;User ID=sa;Password=MinhTriet123;Connect Timeout=180;";
        //const string ConnnectionString = "Data Source=SGN1LAP017\\SQLEXPRESS01;Initial Catalog=Tracking;Integrated Security=True;";

        private List<MasterModel> masterModels = new List<MasterModel>();
        private List<RestaurantModel> restaurantModels = new List<RestaurantModel>();

        public frmRestaurant()
        {
            InitializeComponent();
        }

        private void AddChildNode(TreeNode parentNode, string parentId)
        {
            foreach (var itmMaster in masterModels.Where(p => p.GroupId == parentId))
            {
                TreeNode node = new TreeNode();
                node.Name = itmMaster.Code;
                node.Text = itmMaster.Name;
                node.Tag = itmMaster.DictionaryType;
                parentNode.Nodes.Add(node);
            }
        }

        private async Task LoadData()
        {
            using (DbConnection sql = new SqlConnection(ConnnectionString))
            {
                sql.Open();

                var result = await sql.QueryMultipleAsync("spGetAllConfig",
                commandType: System.Data.CommandType.StoredProcedure);
                masterModels = result.Read<MasterModel>().ToList();
                restaurantModels = result.Read<RestaurantModel>().ToList();
                sql.Close();
            }
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            await LoadData();

            TreeNode node;
            //Vẽ tree view
            foreach (var itmMaster in masterModels.Where(p => p.DictionaryType == "Location"))
            {
                node = new TreeNode();
                node.Name = itmMaster.Code;
                node.Text = itmMaster.Name;
                node.Tag = itmMaster.DictionaryType;
                trvMain.Nodes.Add(node);
                AddChildNode(node, itmMaster.Code);
            }
        }

        private void trvMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            List<RestaurantModel> restaurants = restaurantModels.Where(p => p.ProviceId == e.Node.Name).ToList();
            dgvRestaurant.AutoGenerateColumns = false;
            dgvRestaurant.DataSource = restaurants;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void trvMain_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.Node.Tag.ToString() != "Location")
                {
                    selectedProvice = e.Node.Name;
                    cmtControl.Show(trvMain, e.Location);
                }
            }
        }

        private async void tsmImportRestaurant_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Excel Files|*.xls;*.xlsx";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    //process doc file
                    using (ExcelEngine excelEngine = new ExcelEngine())
                    {
                        //Initialize application
                        IApplication app = excelEngine.Excel;

                        //Set default application version as Excel 2016
                        app.DefaultVersion = ExcelVersion.Excel2016;

                        //Open existing Excel workbook from the specified location
                        IWorkbook workbook = null;
                        using (Stream reader = File.OpenRead(openFile.FileName))
                        {
                            workbook = app.Workbooks.Open(reader);
                        }

                        if (workbook != null)
                        {
                            //Access the first worksheet
                            IWorksheet worksheet = workbook.Worksheets[0];
                            List<RestaurantModel> restaurants = new List<RestaurantModel>();
                            int restaurantType = 1;
                            for (int i = 2; ; i++)
                            {
                                if (worksheet[$"A{i}"].Value == "")
                                    break;

                                if (worksheet[$"C{i}"].Value == "Có")
                                    restaurantType = 2;
                                restaurants.Add
                                    (
                                        new RestaurantModel
                                        {
                                            RestaurantName = worksheet[$"A{i}"].Value,
                                            RestaurantAddress = worksheet[$"B{i}"].Value,
                                            RestaurantType = restaurantType,
                                            ShiftWork = worksheet[$"D{i}"].Value,
                                            ProviceId = selectedProvice
                                        }
                                    );
                            }
                            // xu ly save.
                            if (restaurants.Count > 0)
                            {
                                using (DbConnection sql = new SqlConnection(ConnnectionString))
                                {
                                    sql.Open();

                                    var result = await sql.ExecuteScalarAsync("spInsertRestaurants",
                                        param: new
                                        {
                                            RestaurantList = JsonConvert.SerializeObject(restaurants)
                                        },
                                    commandType: System.Data.CommandType.StoredProcedure);

                                    sql.Close();
                                }

                                await LoadData();
                            }
                        }
                    }
                }
            }
        }
    }
}
