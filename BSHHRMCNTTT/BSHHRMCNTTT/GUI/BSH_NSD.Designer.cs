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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSH_NSD));
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridview = new System.Windows.Forms.DataGridView();
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
            this.ma_dv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigiandn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyendn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.grbinfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton5
            // 
            this.simpleButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton5.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(822, 417);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(62, 28);
            this.simpleButton5.TabIndex = 12;
            this.simpleButton5.Text = "&IN";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(890, 417);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(62, 28);
            this.simpleButton4.TabIndex = 13;
            this.simpleButton4.Text = "&Lọc";
            this.simpleButton4.ToolTip = "Lọc theo người sử dụng";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(754, 417);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(62, 28);
            this.simpleButton3.TabIndex = 11;
            this.simpleButton3.Text = "&Xóa";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(686, 417);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(62, 28);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "&Lưu";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(617, 417);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(62, 28);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "&Mới";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gridview
            // 
            this.gridview.AllowUserToAddRows = false;
            this.gridview.AllowUserToDeleteRows = false;
            this.gridview.AllowUserToResizeColumns = false;
            this.gridview.AllowUserToResizeRows = false;
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
            this.gridview.EnableHeadersVisualStyles = false;
            this.gridview.Location = new System.Drawing.Point(6, 5);
            this.gridview.Name = "gridview";
            this.gridview.ReadOnly = true;
            this.gridview.Size = new System.Drawing.Size(604, 474);
            this.gridview.StandardTab = true;
            this.gridview.TabIndex = 0;
            this.gridview.TabStop = false;
            this.gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_CellContentClick);
            this.gridview.Click += new System.EventHandler(this.gridview_Click);
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
            this.grbinfor.Location = new System.Drawing.Point(616, 5);
            this.grbinfor.Name = "grbinfor";
            this.grbinfor.Size = new System.Drawing.Size(333, 330);
            this.grbinfor.TabIndex = 2;
            this.grbinfor.TabStop = false;
            this.grbinfor.Text = "Thông tin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email";
            // 
            // t_email
            // 
            this.t_email.Location = new System.Drawing.Point(103, 274);
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(190, 21);
            this.t_email.TabIndex = 8;
            // 
            // c_quyen
            // 
            this.c_quyen.FormattingEnabled = true;
            this.c_quyen.Items.AddRange(new object[] {
            "ADMIN",
            "USER1",
            "USER2",
            "USER3",
            "USER4"});
            this.c_quyen.Location = new System.Drawing.Point(103, 165);
            this.c_quyen.Name = "c_quyen";
            this.c_quyen.Size = new System.Drawing.Size(104, 21);
            this.c_quyen.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quyền đăng nhập";
            // 
            // d_ngayhh
            // 
            this.d_ngayhh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.d_ngayhh.Location = new System.Drawing.Point(102, 238);
            this.d_ngayhh.Name = "d_ngayhh";
            this.d_ngayhh.Size = new System.Drawing.Size(134, 21);
            this.d_ngayhh.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày hết hạn";
            // 
            // d_ngaydk
            // 
            this.d_ngaydk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.d_ngaydk.Location = new System.Drawing.Point(102, 202);
            this.d_ngaydk.Name = "d_ngaydk";
            this.d_ngaydk.Size = new System.Drawing.Size(134, 21);
            this.d_ngaydk.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày đăng kí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã nhân viên";
            // 
            // t_manv
            // 
            this.t_manv.Location = new System.Drawing.Point(102, 128);
            this.t_manv.Name = "t_manv";
            this.t_manv.Size = new System.Drawing.Size(151, 21);
            this.t_manv.TabIndex = 4;
            this.t_manv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_manv_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu";
            // 
            // t_matkhau
            // 
            this.t_matkhau.Location = new System.Drawing.Point(103, 91);
            this.t_matkhau.Name = "t_matkhau";
            this.t_matkhau.Size = new System.Drawing.Size(151, 21);
            this.t_matkhau.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NSD";
            // 
            // t_nsd
            // 
            this.t_nsd.Location = new System.Drawing.Point(103, 55);
            this.t_nsd.Name = "t_nsd";
            this.t_nsd.Size = new System.Drawing.Size(151, 21);
            this.t_nsd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã đơn vị";
            // 
            // t_madv
            // 
            this.t_madv.Location = new System.Drawing.Point(103, 21);
            this.t_madv.Name = "t_madv";
            this.t_madv.Size = new System.Drawing.Size(151, 21);
            this.t_madv.TabIndex = 1;
            this.t_madv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_madv_KeyDown);
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
            this.matkhau.Width = 150;
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
            this.quyendn.HeaderText = "Quyền";
            this.quyendn.Name = "quyendn";
            this.quyendn.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 200;
            // 
            // BSH_NSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 491);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.grbinfor);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.simpleButton1);
            this.KeyPreview = true;
            this.Name = "BSH_NSD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Người Sử Dụng";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BSH_NSD_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.grbinfor.ResumeLayout(false);
            this.grbinfor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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