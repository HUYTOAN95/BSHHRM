namespace BSHHRMCNTTT.GUI
{
    partial class BSH_BangLuong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSH_BangLuong));
            this.GridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNam = new DevExpress.XtraEditors.TextEdit();
            this.labelvnd = new System.Windows.Forms.Label();
            this.cbbthang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrichKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnloc = new DevExpress.XtraEditors.SimpleButton();
            this.btnpreview = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbthang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HSL,
            this.SoNgayLV,
            this.HSCV,
            this.TrichKhoan,
            this.LuongNhan,
            this.NgayLap,
            this.Thang,
            this.Nam});
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.Location = new System.Drawing.Point(12, 47);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GridView.Size = new System.Drawing.Size(913, 388);
            this.GridView.TabIndex = 0;
            this.GridView.Click += new System.EventHandler(this.GridView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Năm";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(224, 18);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(111, 20);
            this.txtNam.TabIndex = 5;
            // 
            // labelvnd
            // 
            this.labelvnd.AutoSize = true;
            this.labelvnd.Location = new System.Drawing.Point(12, 464);
            this.labelvnd.Name = "labelvnd";
            this.labelvnd.Size = new System.Drawing.Size(27, 13);
            this.labelvnd.TabIndex = 6;
            this.labelvnd.Text = "VND";
            // 
            // cbbthang
            // 
            this.cbbthang.Location = new System.Drawing.Point(61, 17);
            this.cbbthang.Name = "cbbthang";
            this.cbbthang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbthang.Properties.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbbthang.Size = new System.Drawing.Size(100, 20);
            this.cbbthang.TabIndex = 8;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 150;
            // 
            // HSL
            // 
            this.HSL.DataPropertyName = "HSL";
            this.HSL.HeaderText = "Hệ số lương";
            this.HSL.Name = "HSL";
            // 
            // SoNgayLV
            // 
            this.SoNgayLV.DataPropertyName = "SoNgayLV";
            this.SoNgayLV.HeaderText = "Số ngày làm ";
            this.SoNgayLV.Name = "SoNgayLV";
            // 
            // HSCV
            // 
            this.HSCV.DataPropertyName = "HSCV";
            this.HSCV.HeaderText = "Hệ số chức vụ";
            this.HSCV.Name = "HSCV";
            this.HSCV.Width = 150;
            // 
            // TrichKhoan
            // 
            this.TrichKhoan.DataPropertyName = "TrichKhoan";
            dataGridViewCellStyle5.Format = "#,###";
            dataGridViewCellStyle5.NullValue = "0";
            this.TrichKhoan.DefaultCellStyle = dataGridViewCellStyle5;
            this.TrichKhoan.HeaderText = "Trích khoản bảo hiểm";
            this.TrichKhoan.Name = "TrichKhoan";
            this.TrichKhoan.ReadOnly = true;
            this.TrichKhoan.Width = 150;
            // 
            // LuongNhan
            // 
            this.LuongNhan.DataPropertyName = "LuongNhan";
            dataGridViewCellStyle6.Format = "#,### ";
            dataGridViewCellStyle6.NullValue = "0";
            this.LuongNhan.DefaultCellStyle = dataGridViewCellStyle6;
            this.LuongNhan.HeaderText = "Lương nhân";
            this.LuongNhan.Name = "LuongNhan";
            this.LuongNhan.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Tháng ";
            this.Thang.Name = "Thang";
            // 
            // Nam
            // 
            this.Nam.DataPropertyName = "Nam";
            this.Nam.HeaderText = "Năm";
            this.Nam.Name = "Nam";
            // 
            // btnloc
            // 
            this.btnloc.Image = ((System.Drawing.Image)(resources.GetObject("btnloc.Image")));
            this.btnloc.Location = new System.Drawing.Point(352, 14);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(62, 28);
            this.btnloc.TabIndex = 7;
            this.btnloc.Text = "&Lọc";
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // btnpreview
            // 
            this.btnpreview.Image = ((System.Drawing.Image)(resources.GetObject("btnpreview.Image")));
            this.btnpreview.Location = new System.Drawing.Point(850, 464);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(62, 28);
            this.btnpreview.TabIndex = 1;
            this.btnpreview.Text = "&IN";
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // BSH_BangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 499);
            this.Controls.Add(this.cbbthang);
            this.Controls.Add(this.btnloc);
            this.Controls.Add(this.labelvnd);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.GridView);
            this.Name = "BSH_BangLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng lương";
            this.Load += new System.EventHandler(this.BSH_BangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbthang.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private DevExpress.XtraEditors.SimpleButton btnpreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtNam;
        private System.Windows.Forms.Label labelvnd;
        private DevExpress.XtraEditors.SimpleButton btnloc;
        private DevExpress.XtraEditors.ComboBoxEdit cbbthang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrichKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
    }
}