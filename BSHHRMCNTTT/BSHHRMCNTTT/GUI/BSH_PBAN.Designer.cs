namespace BSHHRMCNTTT.GUI
{
    partial class BSH_PBAN
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
            this.grbthongtin = new DevExpress.XtraEditors.GroupControl();
            this.txtghichu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnin = new DevExpress.XtraEditors.SimpleButton();
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.mapb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenpb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grbthongtin)).BeginInit();
            this.grbthongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtghichu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grbthongtin
            // 
            this.grbthongtin.Controls.Add(this.txtghichu);
            this.grbthongtin.Controls.Add(this.labelControl3);
            this.grbthongtin.Controls.Add(this.txtten);
            this.grbthongtin.Controls.Add(this.labelControl2);
            this.grbthongtin.Location = new System.Drawing.Point(502, 12);
            this.grbthongtin.Name = "grbthongtin";
            this.grbthongtin.Size = new System.Drawing.Size(408, 366);
            this.grbthongtin.TabIndex = 1;
            this.grbthongtin.Text = "Thông tin";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(53, 103);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(333, 20);
            this.txtghichu.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Ghi chú";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(53, 63);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(236, 20);
            this.txtten.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(7, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(18, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(9, 19);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "&Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(108, 19);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "&Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(205, 19);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "&Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(308, 19);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(75, 23);
            this.btnin.TabIndex = 9;
            this.btnin.Text = "&IN";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnin);
            this.panel.Controls.Add(this.btnthem);
            this.panel.Controls.Add(this.btnsua);
            this.panel.Controls.Add(this.btnxoa);
            this.panel.Location = new System.Drawing.Point(505, 391);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(405, 58);
            this.panel.TabIndex = 10;
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mapb,
            this.tenpb,
            this.ghichu});
            this.GridView.Location = new System.Drawing.Point(2, 14);
            this.GridView.Name = "GridView";
            this.GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridView.Size = new System.Drawing.Size(494, 435);
            this.GridView.TabIndex = 11;
            this.GridView.Click += new System.EventHandler(this.GridView_Click);
            // 
            // mapb
            // 
            this.mapb.DataPropertyName = "mapb";
            this.mapb.HeaderText = "Mã ";
            this.mapb.Name = "mapb";
            // 
            // tenpb
            // 
            this.tenpb.DataPropertyName = "tenpb";
            this.tenpb.HeaderText = "Tên";
            this.tenpb.Name = "tenpb";
            this.tenpb.Width = 200;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi Chú";
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 250;
            // 
            // BSH_PBAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 465);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.grbthongtin);
            this.Name = "BSH_PBAN";
            this.Text = "Phòng Ban ";
            this.Load += new System.EventHandler(this.BSH_PBAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grbthongtin)).EndInit();
            this.grbthongtin.ResumeLayout(false);
            this.grbthongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtghichu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl grbthongtin;
        private DevExpress.XtraEditors.TextEdit txtghichu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnin;
        private DevExpress.XtraEditors.PanelControl panel;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenpb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
    }
}