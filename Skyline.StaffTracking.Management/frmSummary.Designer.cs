namespace Skyline.StaffTracking.Management
{
    partial class frmSummary
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
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShiftWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVisitShop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSummary
            // 
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLocation,
            this.colShiftWork,
            this.colVisitShop,
            this.colDistance});
            this.dgvSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSummary.Location = new System.Drawing.Point(0, 0);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.RowHeadersVisible = false;
            this.dgvSummary.RowHeadersWidth = 51;
            this.dgvSummary.RowTemplate.Height = 24;
            this.dgvSummary.Size = new System.Drawing.Size(637, 372);
            this.dgvSummary.TabIndex = 0;
            // 
            // colLocation
            // 
            this.colLocation.DataPropertyName = "LocationName";
            this.colLocation.HeaderText = "Vùng miền";
            this.colLocation.MinimumWidth = 6;
            this.colLocation.Name = "colLocation";
            this.colLocation.Width = 170;
            // 
            // colShiftWork
            // 
            this.colShiftWork.DataPropertyName = "ShiftWork";
            this.colShiftWork.HeaderText = "Ca làm việc";
            this.colShiftWork.MinimumWidth = 6;
            this.colShiftWork.Name = "colShiftWork";
            this.colShiftWork.Width = 125;
            // 
            // colVisitShop
            // 
            this.colVisitShop.DataPropertyName = "VisitShop";
            this.colVisitShop.HeaderText = "Số quán";
            this.colVisitShop.MinimumWidth = 6;
            this.colVisitShop.Name = "colVisitShop";
            this.colVisitShop.Width = 125;
            // 
            // colDistance
            // 
            this.colDistance.DataPropertyName = "DinstanceSum";
            this.colDistance.HeaderText = "Khoảng cách";
            this.colDistance.MinimumWidth = 6;
            this.colDistance.Name = "colDistance";
            this.colDistance.Width = 125;
            // 
            // frmSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 372);
            this.Controls.Add(this.dgvSummary);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSummary";
            this.Text = "Thông tin tổng hợp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShiftWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVisitShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistance;
    }
}