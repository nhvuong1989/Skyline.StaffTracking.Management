namespace Skyline.StaffTracking.Management
{
    partial class frmRestaurant
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvMain = new System.Windows.Forms.TreeView();
            this.dgvRestaurant = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRestaurantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRestaurantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRestaurantAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRestaurantType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmtControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmImportRestaurant = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurant)).BeginInit();
            this.panelControl.SuspendLayout();
            this.cmtControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvRestaurant);
            this.splitContainer1.Size = new System.Drawing.Size(1080, 677);
            this.splitContainer1.SplitterDistance = 355;
            this.splitContainer1.TabIndex = 0;
            // 
            // trvMain
            // 
            this.trvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvMain.Location = new System.Drawing.Point(0, 0);
            this.trvMain.Name = "trvMain";
            this.trvMain.Size = new System.Drawing.Size(355, 677);
            this.trvMain.TabIndex = 0;
            this.trvMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvMain_AfterSelect);
            this.trvMain.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvMain_NodeMouseClick);
            // 
            // dgvRestaurant
            // 
            this.dgvRestaurant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestaurant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colRestaurantId,
            this.colRestaurantName,
            this.colRestaurantAddress,
            this.colIsActive,
            this.colRestaurantType});
            this.dgvRestaurant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRestaurant.Location = new System.Drawing.Point(0, 0);
            this.dgvRestaurant.Name = "dgvRestaurant";
            this.dgvRestaurant.RowHeadersWidth = 51;
            this.dgvRestaurant.Size = new System.Drawing.Size(721, 677);
            this.dgvRestaurant.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.Visible = false;
            this.colId.Width = 125;
            // 
            // colRestaurantId
            // 
            this.colRestaurantId.DataPropertyName = "RestaurantId";
            this.colRestaurantId.HeaderText = "RestaurantId";
            this.colRestaurantId.MinimumWidth = 6;
            this.colRestaurantId.Name = "colRestaurantId";
            this.colRestaurantId.Visible = false;
            this.colRestaurantId.Width = 125;
            // 
            // colRestaurantName
            // 
            this.colRestaurantName.DataPropertyName = "RestaurantName";
            this.colRestaurantName.HeaderText = "Tên nhà hàng";
            this.colRestaurantName.MinimumWidth = 6;
            this.colRestaurantName.Name = "colRestaurantName";
            this.colRestaurantName.Width = 125;
            // 
            // colRestaurantAddress
            // 
            this.colRestaurantAddress.DataPropertyName = "RestaurantAddress";
            this.colRestaurantAddress.HeaderText = "Địa chỉ";
            this.colRestaurantAddress.MinimumWidth = 6;
            this.colRestaurantAddress.Name = "colRestaurantAddress";
            this.colRestaurantAddress.Width = 125;
            // 
            // colIsActive
            // 
            this.colIsActive.DataPropertyName = "IsActive";
            this.colIsActive.HeaderText = "Tình trạng hoạt động";
            this.colIsActive.MinimumWidth = 6;
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsActive.Width = 125;
            // 
            // colRestaurantType
            // 
            this.colRestaurantType.DataPropertyName = "RestaurantType";
            this.colRestaurantType.HeaderText = "Loại nhà hàng";
            this.colRestaurantType.MinimumWidth = 6;
            this.colRestaurantType.Name = "colRestaurantType";
            this.colRestaurantType.Width = 125;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.btnSave);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 619);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1080, 58);
            this.panelControl.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(854, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmtControl
            // 
            this.cmtControl.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmtControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmImportRestaurant});
            this.cmtControl.Name = "cmtControl";
            this.cmtControl.Size = new System.Drawing.Size(211, 56);
            // 
            // tsmImportRestaurant
            // 
            this.tsmImportRestaurant.Name = "tsmImportRestaurant";
            this.tsmImportRestaurant.Size = new System.Drawing.Size(210, 24);
            this.tsmImportRestaurant.Text = "Import";
            this.tsmImportRestaurant.Click += new System.EventHandler(this.tsmImportRestaurant_Click);
            // 
            // frmRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 677);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmRestaurant";
            this.Text = "frmRestaurant";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurant)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.cmtControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvRestaurant;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.TreeView trvMain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRestaurantId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRestaurantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRestaurantAddress;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRestaurantType;
        private System.Windows.Forms.ContextMenuStrip cmtControl;
        private System.Windows.Forms.ToolStripMenuItem tsmImportRestaurant;
    }
}