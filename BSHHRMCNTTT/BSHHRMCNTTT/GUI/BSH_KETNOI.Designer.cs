namespace BSHHRMCNTTT.SysForm
{
    partial class frmConnectDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnectDB));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.t_server = new System.Windows.Forms.TextBox();
            this.t_dbname = new System.Windows.Forms.TextBox();
            this.t_userlogin = new System.Windows.Forms.TextBox();
            this.t_password = new System.Windows.Forms.TextBox();
            this.checkrememberpass = new DevExpress.XtraEditors.CheckEdit();
            this.b_disconnect = new DevExpress.XtraEditors.SimpleButton();
            this.b_connect = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ldate = new DevExpress.XtraEditors.LabelControl();
            this.ltime = new DevExpress.XtraEditors.LabelControl();
            this.timerstart = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkrememberpass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Server Name";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.t_server);
            this.groupControl1.Controls.Add(this.t_dbname);
            this.groupControl1.Controls.Add(this.t_userlogin);
            this.groupControl1.Controls.Add(this.t_password);
            this.groupControl1.Controls.Add(this.checkrememberpass);
            this.groupControl1.Controls.Add(this.b_disconnect);
            this.groupControl1.Controls.Add(this.b_connect);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 31);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(411, 250);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin";
            // 
            // t_server
            // 
            this.t_server.Location = new System.Drawing.Point(124, 32);
            this.t_server.Name = "t_server";
            this.t_server.Size = new System.Drawing.Size(218, 21);
            this.t_server.TabIndex = 14;
            // 
            // t_dbname
            // 
            this.t_dbname.Location = new System.Drawing.Point(124, 72);
            this.t_dbname.Name = "t_dbname";
            this.t_dbname.Size = new System.Drawing.Size(218, 21);
            this.t_dbname.TabIndex = 13;
            // 
            // t_userlogin
            // 
            this.t_userlogin.Location = new System.Drawing.Point(124, 105);
            this.t_userlogin.Name = "t_userlogin";
            this.t_userlogin.Size = new System.Drawing.Size(218, 21);
            this.t_userlogin.TabIndex = 12;
            // 
            // t_password
            // 
            this.t_password.Location = new System.Drawing.Point(124, 140);
            this.t_password.Name = "t_password";
            this.t_password.Size = new System.Drawing.Size(218, 21);
            this.t_password.TabIndex = 11;
            this.t_password.UseSystemPasswordChar = true;
            // 
            // checkrememberpass
            // 
            this.checkrememberpass.Location = new System.Drawing.Point(122, 177);
            this.checkrememberpass.Name = "checkrememberpass";
            this.checkrememberpass.Properties.Caption = "Nhớ thông tin tài khoản đăng nhập";
            this.checkrememberpass.Size = new System.Drawing.Size(220, 19);
            this.checkrememberpass.TabIndex = 10;
            this.checkrememberpass.CheckedChanged += new System.EventHandler(this.checkrememberpass_CheckedChanged);
            // 
            // b_disconnect
            // 
            this.b_disconnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_disconnect.Location = new System.Drawing.Point(206, 214);
            this.b_disconnect.Name = "b_disconnect";
            this.b_disconnect.Size = new System.Drawing.Size(75, 23);
            this.b_disconnect.TabIndex = 9;
            this.b_disconnect.Text = "Bỏ Kết Nối";
            this.b_disconnect.Click += new System.EventHandler(this.b_disconnect_Click);
            // 
            // b_connect
            // 
            this.b_connect.Location = new System.Drawing.Point(112, 214);
            this.b_connect.Name = "b_connect";
            this.b_connect.Size = new System.Drawing.Size(75, 23);
            this.b_connect.TabIndex = 8;
            this.b_connect.Text = "Kết Nối";
            this.b_connect.Click += new System.EventHandler(this.b_connect_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 148);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Password";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 108);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "User Login";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "DB Name";
            // 
            // ldate
            // 
            this.ldate.Location = new System.Drawing.Point(347, 12);
            this.ldate.Name = "ldate";
            this.ldate.Size = new System.Drawing.Size(23, 13);
            this.ldate.TabIndex = 2;
            this.ldate.Text = "Date";
            // 
            // ltime
            // 
            this.ltime.Location = new System.Drawing.Point(282, 12);
            this.ltime.Name = "ltime";
            this.ltime.Size = new System.Drawing.Size(22, 13);
            this.ltime.TabIndex = 3;
            this.ltime.Text = "Time";
            // 
            // timerstart
            // 
            this.timerstart.Tick += new System.EventHandler(this.timerstart_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BSHHRM-2018";
            // 
            // frmConnectDB
            // 
            this.AcceptButton = this.b_connect;
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.b_disconnect;
            this.ClientSize = new System.Drawing.Size(435, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltime);
            this.Controls.Add(this.ldate);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.InactiveGlowColor = System.Drawing.Color.Transparent;
            this.KeyPreview = true;
            this.Name = "frmConnectDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết Nối Dữ Liệu";
            this.Load += new System.EventHandler(this.frmConnectDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkrememberpass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit checkrememberpass;
        private DevExpress.XtraEditors.SimpleButton b_disconnect;
        private DevExpress.XtraEditors.SimpleButton b_connect;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl ldate;
        private DevExpress.XtraEditors.LabelControl ltime;
        private System.Windows.Forms.Timer timerstart;
        private System.Windows.Forms.TextBox t_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_server;
        private System.Windows.Forms.TextBox t_dbname;
        private System.Windows.Forms.TextBox t_userlogin;
    }
}