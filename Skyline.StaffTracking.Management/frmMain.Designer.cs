namespace Skyline.StaffTracking.Management
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnRestaurant = new System.Windows.Forms.Button();
            this.dtpDateAction = new System.Windows.Forms.DateTimePicker();
            this.lblDateAction = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.colRestaurantFieldId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsComplete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmtControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSummary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.cmtControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSummary);
            this.splitContainer1.Panel1.Controls.Add(this.btnExcel);
            this.splitContainer1.Panel1.Controls.Add(this.btnRestaurant);
            this.splitContainer1.Panel1.Controls.Add(this.dtpDateAction);
            this.splitContainer1.Panel1.Controls.Add(this.lblDateAction);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvEmployee);
            this.splitContainer1.Size = new System.Drawing.Size(1071, 709);
            this.splitContainer1.SplitterDistance = 121;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(830, 89);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(100, 28);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnRestaurant
            // 
            this.btnRestaurant.Location = new System.Drawing.Point(686, 89);
            this.btnRestaurant.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestaurant.Name = "btnRestaurant";
            this.btnRestaurant.Size = new System.Drawing.Size(136, 28);
            this.btnRestaurant.TabIndex = 3;
            this.btnRestaurant.Text = "Quản lý nhà hàng";
            this.btnRestaurant.UseVisualStyleBackColor = true;
            this.btnRestaurant.Click += new System.EventHandler(this.btnRestaurant_Click);
            // 
            // dtpDateAction
            // 
            this.dtpDateAction.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAction.Location = new System.Drawing.Point(208, 53);
            this.dtpDateAction.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateAction.Name = "dtpDateAction";
            this.dtpDateAction.Size = new System.Drawing.Size(111, 22);
            this.dtpDateAction.TabIndex = 2;
            // 
            // lblDateAction
            // 
            this.lblDateAction.AutoSize = true;
            this.lblDateAction.Location = new System.Drawing.Point(101, 57);
            this.lblDateAction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateAction.Name = "lblDateAction";
            this.lblDateAction.Size = new System.Drawing.Size(96, 17);
            this.lblDateAction.TabIndex = 1;
            this.lblDateAction.Text = "Ngày làm việc";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(341, 50);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRestaurantFieldId,
            this.colEmployeeName,
            this.colPhoneNumber,
            this.colStartTime,
            this.colEndTime,
            this.colComment,
            this.colIsComplete,
            this.colDistance});
            this.dgvEmployee.ContextMenuStrip = this.cmtControl;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(1071, 583);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvEmployee_MouseDown);
            // 
            // colRestaurantFieldId
            // 
            this.colRestaurantFieldId.DataPropertyName = "RestaurantFieldId";
            this.colRestaurantFieldId.HeaderText = "EmployeeId";
            this.colRestaurantFieldId.MinimumWidth = 6;
            this.colRestaurantFieldId.Name = "colRestaurantFieldId";
            this.colRestaurantFieldId.ReadOnly = true;
            this.colRestaurantFieldId.Visible = false;
            this.colRestaurantFieldId.Width = 125;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.DataPropertyName = "EmployeeName";
            this.colEmployeeName.HeaderText = "Tên nhân viên";
            this.colEmployeeName.MinimumWidth = 6;
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.ReadOnly = true;
            this.colEmployeeName.Width = 250;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.DataPropertyName = "PhoneNumber";
            this.colPhoneNumber.HeaderText = "Số điện thoại";
            this.colPhoneNumber.MinimumWidth = 6;
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.ReadOnly = true;
            this.colPhoneNumber.Width = 125;
            // 
            // colStartTime
            // 
            this.colStartTime.DataPropertyName = "StartTime";
            dataGridViewCellStyle4.Format = "G";
            dataGridViewCellStyle4.NullValue = null;
            this.colStartTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.colStartTime.HeaderText = "Thời gian bắt đầu";
            this.colStartTime.MinimumWidth = 6;
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.ReadOnly = true;
            this.colStartTime.Width = 150;
            // 
            // colEndTime
            // 
            this.colEndTime.DataPropertyName = "EndTime";
            dataGridViewCellStyle5.Format = "G";
            dataGridViewCellStyle5.NullValue = null;
            this.colEndTime.DefaultCellStyle = dataGridViewCellStyle5;
            this.colEndTime.HeaderText = "Thời gian kết thúc";
            this.colEndTime.MinimumWidth = 6;
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.ReadOnly = true;
            this.colEndTime.Width = 150;
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "Ghi chú";
            this.colComment.MinimumWidth = 6;
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
            this.colComment.Width = 125;
            // 
            // colIsComplete
            // 
            this.colIsComplete.DataPropertyName = "IsComplete";
            this.colIsComplete.HeaderText = "Hoàn thành";
            this.colIsComplete.MinimumWidth = 6;
            this.colIsComplete.Name = "colIsComplete";
            this.colIsComplete.ReadOnly = true;
            this.colIsComplete.Width = 125;
            // 
            // colDistance
            // 
            this.colDistance.DataPropertyName = "Distance";
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.colDistance.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDistance.HeaderText = "Quãng đường đi(Km)";
            this.colDistance.MinimumWidth = 6;
            this.colDistance.Name = "colDistance";
            this.colDistance.ReadOnly = true;
            this.colDistance.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDistance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDistance.Width = 150;
            // 
            // cmtControl
            // 
            this.cmtControl.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmtControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportReportToolStripMenuItem});
            this.cmtControl.Name = "cmtControl";
            this.cmtControl.Size = new System.Drawing.Size(167, 28);
            // 
            // exportReportToolStripMenuItem
            // 
            this.exportReportToolStripMenuItem.Name = "exportReportToolStripMenuItem";
            this.exportReportToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.exportReportToolStripMenuItem.Text = "Export report";
            this.exportReportToolStripMenuItem.Click += new System.EventHandler(this.exportReportToolStripMenuItem_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(938, 89);
            this.btnSummary.Margin = new System.Windows.Forms.Padding(4);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(100, 28);
            this.btnSummary.TabIndex = 5;
            this.btnSummary.Text = "Tổng hợp";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 709);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.cmtControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpDateAction;
        private System.Windows.Forms.Label lblDateAction;
        private System.Windows.Forms.ContextMenuStrip cmtControl;
        private System.Windows.Forms.ToolStripMenuItem exportReportToolStripMenuItem;
        private System.Windows.Forms.Button btnRestaurant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRestaurantFieldId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistance;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnSummary;
    }
}

