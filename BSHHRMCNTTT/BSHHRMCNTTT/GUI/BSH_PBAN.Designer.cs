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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSH_PBAN));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbthongtin = new DevExpress.XtraEditors.GroupControl();
            this.txtghichu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnin = new DevExpress.XtraEditors.SimpleButton();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.mapb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenpb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grbthongtin)).BeginInit();
            this.grbthongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtghichu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grbthongtin
            // 
            this.grbthongtin.Controls.Add(this.txtghichu);
            this.grbthongtin.Controls.Add(this.labelControl3);
            this.grbthongtin.Controls.Add(this.txtten);
            this.grbthongtin.Controls.Add(this.labelControl2);
            this.grbthongtin.Location = new System.Drawing.Point(372, 16);
            this.grbthongtin.Name = "grbthongtin";
            this.grbthongtin.Size = new System.Drawing.Size(309, 161);
            this.grbthongtin.TabIndex = 1;
            this.grbthongtin.Text = "Thông tin";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(53, 103);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(242, 20);
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
            this.txtten.Size = new System.Drawing.Size(242, 20);
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
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(384, 348);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(62, 28);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "&Mới";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(454, 348);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(62, 28);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "&Lưu";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(531, 348);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(62, 28);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "&Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnin
            // 
            this.btnin.Image = ((System.Drawing.Image)(resources.GetObject("btnin.Image")));
            this.btnin.Location = new System.Drawing.Point(605, 348);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(62, 28);
            this.btnin.TabIndex = 9;
            this.btnin.Text = "&IN";
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // GridView
            // 
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mapb,
            this.tenpb,
            this.ghichu});
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.Location = new System.Drawing.Point(2, 13);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridView.Size = new System.Drawing.Size(363, 386);
            this.GridView.TabIndex = 11;
            this.GridView.Click += new System.EventHandler(this.GridView_Click);
            // 
            // mapb
            // 
            this.mapb.DataPropertyName = "mapb";
            this.mapb.HeaderText = "Mã ";
            this.mapb.Name = "mapb";
            this.mapb.ReadOnly = true;
            this.mapb.Width = 50;
            // 
            // tenpb
            // 
            this.tenpb.DataPropertyName = "tenpb";
            this.tenpb.HeaderText = "Tên";
            this.tenpb.Name = "tenpb";
            this.tenpb.ReadOnly = true;
            this.tenpb.Width = 400;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi Chú";
            this.ghichu.Name = "ghichu";
            this.ghichu.ReadOnly = true;
            this.ghichu.Visible = false;
            this.ghichu.Width = 250;
            // 
            // BSH_PBAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 404);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.grbthongtin);
            this.Controls.Add(this.btnxoa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "BSH_PBAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng Ban ";
            this.Load += new System.EventHandler(this.BSH_PBAN_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BSH_PBAN_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grbthongtin)).EndInit();
            this.grbthongtin.ResumeLayout(false);
            this.grbthongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtghichu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
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
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapb;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenpb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
    }
}