namespace BSHHRMCNTTT.GUI
{
    partial class BSH_HopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSH_HopDong));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txttongiao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttongiao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txttongiao);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btndelete);
            this.groupControl1.Controls.Add(this.btnedit);
            this.groupControl1.Controls.Add(this.btnadd);
            this.groupControl1.Location = new System.Drawing.Point(410, 25);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(551, 260);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Thông tin";
            // 
            // txttongiao
            // 
            this.txttongiao.Location = new System.Drawing.Point(205, 45);
            this.txttongiao.Name = "txttongiao";
            this.txttongiao.Size = new System.Drawing.Size(171, 20);
            this.txttongiao.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tìm kiếm ";
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHD,
            this.LoaiHD,
            this.NgayBD,
            this.NgayKT});
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.Location = new System.Drawing.Point(9, 12);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridView.Size = new System.Drawing.Size(395, 374);
            this.GridView.TabIndex = 10;
            // 
            // btndelete
            // 
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(291, 100);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(62, 28);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "&Xóa";
            // 
            // btnedit
            // 
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.Location = new System.Drawing.Point(211, 100);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(62, 28);
            this.btnedit.TabIndex = 13;
            this.btnedit.Text = "&Lưu";
            // 
            // btnadd
            // 
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(132, 100);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(62, 28);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "&Mới";
            // 
            // SoHD
            // 
            this.SoHD.DataPropertyName = "SoHD";
            this.SoHD.HeaderText = "Số HD";
            this.SoHD.Name = "SoHD";
            this.SoHD.ReadOnly = true;
            // 
            // LoaiHD
            // 
            this.LoaiHD.DataPropertyName = "LoaiHD";
            this.LoaiHD.HeaderText = "Loại HD";
            this.LoaiHD.Name = "LoaiHD";
            this.LoaiHD.ReadOnly = true;
            // 
            // NgayBD
            // 
            this.NgayBD.HeaderText = "Ngày bắt đầu ";
            this.NgayBD.Name = "NgayBD";
            this.NgayBD.ReadOnly = true;
            // 
            // NgayKT
            // 
            this.NgayKT.HeaderText = "Ngày kết thúc";
            this.NgayKT.Name = "NgayKT";
            this.NgayKT.ReadOnly = true;
            // 
            // BSH_HopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 398);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GridView);
            this.Name = "BSH_HopDong";
            this.Text = "Hợp Đồng";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttongiao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txttongiao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnedit;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKT;
    }
}