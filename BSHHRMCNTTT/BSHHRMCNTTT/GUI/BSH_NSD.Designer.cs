namespace BSHHRMCNTTT.SysForm
{
    partial class BSH_NSD
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
            this.grbcontrol = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.ma_dv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigiandn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyendn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbinfor = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.t_email = new System.Windows.Forms.TextBox();
            this.c_quyen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.d_ngayhh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.d_ngaydk = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_manv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_matkhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_nsd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_madv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grbcontrol)).BeginInit();
            this.grbcontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.grbinfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbcontrol
            // 
            this.grbcontrol.Controls.Add(this.simpleButton5);
            this.grbcontrol.Controls.Add(this.simpleButton4);
            this.grbcontrol.Controls.Add(this.simpleButton3);
            this.grbcontrol.Controls.Add(this.simpleButton2);
            this.grbcontrol.Controls.Add(this.simpleButton1);
            this.grbcontrol.Location = new System.Drawing.Point(12, 426);
            this.grbcontrol.Name = "grbcontrol";
            this.grbcontrol.ShowCaption = false;
            this.grbcontrol.Size = new System.Drawing.Size(1042, 53);
            this.grbcontrol.TabIndex = 1;
            this.grbcontrol.Text = "groupControl1";
            this.grbcontrol.Paint += new System.Windows.Forms.PaintEventHandler(this.grbcontrol_Paint);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(659, 17);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 23);
            this.simpleButton5.TabIndex = 4;
            this.simpleButton5.Text = "&IN";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(551, 17);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "&Lọc";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(444, 17);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "&Xóa";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(337, 17);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "&Sửa";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(214, 17);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "&Thêm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridview
            // 
            this.gridview.AllowUserToAddRows = false;
            this.gridview.AllowUserToDeleteRows = false;
            this.gridview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_dv,
            this.nsd,
            this.matkhau,
            this.ma_nv,
            this.ngaydk,
            this.ngayhan,
            this.thoigiandn,
            this.quyendn,
            this.email});
            this.gridview.Location = new System.Drawing.Point(12, 5);
            this.gridview.Name = "gridview";
            this.gridview.ReadOnly = true;
            this.gridview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridview.Size = new System.Drawing.Size(1042, 305);
            this.gridview.TabIndex = 0;
            this.gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_CellContentClick);
            this.gridview.Click += new System.EventHandler(this.gridview_Click);
            // 
            // ma_dv
            // 
            this.ma_dv.DataPropertyName = "ma_dv";
            this.ma_dv.HeaderText = "Mã Đơn Vị";
            this.ma_dv.Name = "ma_dv";
            this.ma_dv.ReadOnly = true;
            // 
            // nsd
            // 
            this.nsd.DataPropertyName = "nsd";
            this.nsd.HeaderText = "Người Dùng";
            this.nsd.Name = "nsd";
            this.nsd.ReadOnly = true;
            // 
            // matkhau
            // 
            this.matkhau.DataPropertyName = "matkhau";
            this.matkhau.HeaderText = "Mật Khẩu";
            this.matkhau.Name = "matkhau";
            this.matkhau.ReadOnly = true;
            // 
            // ma_nv
            // 
            this.ma_nv.DataPropertyName = "ma_nv";
            this.ma_nv.HeaderText = "Mã Nhân Viên";
            this.ma_nv.Name = "ma_nv";
            this.ma_nv.ReadOnly = true;
            this.ma_nv.Width = 110;
            // 
            // ngaydk
            // 
            this.ngaydk.DataPropertyName = "ngaydk";
            this.ngaydk.HeaderText = "Ngày Đăng Kí";
            this.ngaydk.Name = "ngaydk";
            this.ngaydk.ReadOnly = true;
            this.ngaydk.Width = 120;
            // 
            // ngayhan
            // 
            this.ngayhan.DataPropertyName = "ngayhan";
            this.ngayhan.HeaderText = "Ngày Hết Hạn";
            this.ngayhan.Name = "ngayhan";
            this.ngayhan.ReadOnly = true;
            this.ngayhan.Width = 120;
            // 
            // thoigiandn
            // 
            this.thoigiandn.DataPropertyName = "thoigiandn";
            this.thoigiandn.HeaderText = "Thời gian DN gần nhất";
            this.thoigiandn.Name = "thoigiandn";
            this.thoigiandn.ReadOnly = true;
            this.thoigiandn.Width = 160;
            // 
            // quyendn
            // 
            this.quyendn.DataPropertyName = "quyendn";
            this.quyendn.HeaderText = "Quyền đăng nhập";
            this.quyendn.Name = "quyendn";
            this.quyendn.ReadOnly = true;
            this.quyendn.Width = 150;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 200;
            // 
            // grbinfor
            // 
            this.grbinfor.Controls.Add(this.label8);
            this.grbinfor.Controls.Add(this.t_email);
            this.grbinfor.Controls.Add(this.c_quyen);
            this.grbinfor.Controls.Add(this.label7);
            this.grbinfor.Controls.Add(this.d_ngayhh);
            this.grbinfor.Controls.Add(this.label6);
            this.grbinfor.Controls.Add(this.d_ngaydk);
            this.grbinfor.Controls.Add(this.label5);
            this.grbinfor.Controls.Add(this.label4);
            this.grbinfor.Controls.Add(this.t_manv);
            this.grbinfor.Controls.Add(this.label3);
            this.grbinfor.Controls.Add(this.t_matkhau);
            this.grbinfor.Controls.Add(this.label2);
            this.grbinfor.Controls.Add(this.t_nsd);
            this.grbinfor.Controls.Add(this.label1);
            this.grbinfor.Controls.Add(this.t_madv);
            this.grbinfor.Location = new System.Drawing.Point(12, 316);
            this.grbinfor.Name = "grbinfor";
            this.grbinfor.Size = new System.Drawing.Size(1042, 92);
            this.grbinfor.TabIndex = 2;
            this.grbinfor.TabStop = false;
            this.grbinfor.Text = "Thông tin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(556, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email";
            // 
            // t_email
            // 
            this.t_email.Location = new System.Drawing.Point(632, 46);
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(193, 21);
            this.t_email.TabIndex = 16;
            // 
            // c_quyen
            // 
            this.c_quyen.FormattingEnabled = true;
            this.c_quyen.Location = new System.Drawing.Point(632, 19);
            this.c_quyen.Name = "c_quyen";
            this.c_quyen.Size = new System.Drawing.Size(121, 21);
            this.c_quyen.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quyền đăng nhập";
            // 
            // d_ngayhh
            // 
            this.d_ngayhh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.d_ngayhh.Location = new System.Drawing.Point(922, 46);
            this.d_ngayhh.Name = "d_ngayhh";
            this.d_ngayhh.Size = new System.Drawing.Size(105, 21);
            this.d_ngayhh.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(845, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày hết hạn";
            // 
            // d_ngaydk
            // 
            this.d_ngaydk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.d_ngaydk.Location = new System.Drawing.Point(922, 19);
            this.d_ngaydk.Name = "d_ngaydk";
            this.d_ngaydk.Size = new System.Drawing.Size(105, 21);
            this.d_ngaydk.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(845, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày đăng kí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã nhân viên";
            // 
            // t_manv
            // 
            this.t_manv.Location = new System.Drawing.Point(353, 22);
            this.t_manv.Name = "t_manv";
            this.t_manv.Size = new System.Drawing.Size(151, 21);
            this.t_manv.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu";
            // 
            // t_matkhau
            // 
            this.t_matkhau.Location = new System.Drawing.Point(353, 48);
            this.t_matkhau.Name = "t_matkhau";
            this.t_matkhau.Size = new System.Drawing.Size(151, 21);
            this.t_matkhau.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NSD";
            // 
            // t_nsd
            // 
            this.t_nsd.Location = new System.Drawing.Point(98, 48);
            this.t_nsd.Name = "t_nsd";
            this.t_nsd.Size = new System.Drawing.Size(151, 21);
            this.t_nsd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã đơn vị";
            // 
            // t_madv
            // 
            this.t_madv.Location = new System.Drawing.Point(98, 21);
            this.t_madv.Name = "t_madv";
            this.t_madv.Size = new System.Drawing.Size(151, 21);
            this.t_madv.TabIndex = 1;
            this.t_madv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_madv_KeyDown);
            // 
            // BSH_NSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 491);
            this.Controls.Add(this.grbinfor);
            this.Controls.Add(this.grbcontrol);
            this.Controls.Add(this.gridview);
            this.KeyPreview = true;
            this.Name = "BSH_NSD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Người Sử Dụng";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grbcontrol)).EndInit();
            this.grbcontrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.grbinfor.ResumeLayout(false);
            this.grbinfor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl grbcontrol;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.GroupBox grbinfor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox t_email;
        private System.Windows.Forms.ComboBox c_quyen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker d_ngayhh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker d_ngaydk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_manv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_matkhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_nsd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_madv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_dv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigiandn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyendn;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}