namespace BSHHRMCNTTT.SysForm
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checksave = new DevExpress.XtraEditors.CheckEdit();
            this.linkfogetpass = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.b_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.b_login = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.t_pass = new DevExpress.XtraEditors.TextEdit();
            this.t_nsd = new DevExpress.XtraEditors.TextEdit();
            this.t_madv = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checksave.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_pass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_nsd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_madv.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.t_madv);
            this.groupControl1.Controls.Add(this.t_nsd);
            this.groupControl1.Controls.Add(this.t_pass);
            this.groupControl1.Controls.Add(this.checksave);
            this.groupControl1.Controls.Add(this.linkfogetpass);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.b_cancel);
            this.groupControl1.Controls.Add(this.b_login);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(21, 22);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(436, 277);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "BSH - Đăng Nhập ";
            // 
            // checksave
            // 
            this.checksave.Location = new System.Drawing.Point(228, 154);
            this.checksave.Name = "checksave";
            this.checksave.Properties.Caption = "Lưu tài khoản đăng nhập";
            this.checksave.Size = new System.Drawing.Size(168, 19);
            this.checksave.TabIndex = 10;
            // 
            // linkfogetpass
            // 
            this.linkfogetpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkfogetpass.Location = new System.Drawing.Point(57, 155);
            this.linkfogetpass.Name = "linkfogetpass";
            this.linkfogetpass.Size = new System.Drawing.Size(77, 13);
            this.linkfogetpass.TabIndex = 9;
            this.linkfogetpass.Text = "Quên Mật Khẩu ";
            this.linkfogetpass.Click += new System.EventHandler(this.linkfogetpass_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(168, 227);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "BSHHRM_2018";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(57, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Mã Đơn Vị";
            // 
            // b_cancel
            // 
            this.b_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_cancel.Location = new System.Drawing.Point(228, 185);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 5;
            this.b_cancel.Text = "Hủy Bỏ";
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // b_login
            // 
            this.b_login.Location = new System.Drawing.Point(120, 185);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(75, 23);
            this.b_login.TabIndex = 4;
            this.b_login.Text = "Đăng Nhập";
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(57, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mật Khẩu";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(57, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Đăng Nhập";
            // 
            // t_pass
            // 
            this.t_pass.Location = new System.Drawing.Point(149, 109);
            this.t_pass.Name = "t_pass";
            this.t_pass.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.t_pass.Properties.Appearance.Options.UseBackColor = true;
            this.t_pass.Properties.UseSystemPasswordChar = true;
            this.t_pass.Size = new System.Drawing.Size(187, 20);
            this.t_pass.TabIndex = 11;
            // 
            // t_nsd
            // 
            this.t_nsd.Location = new System.Drawing.Point(149, 73);
            this.t_nsd.Name = "t_nsd";
            this.t_nsd.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.t_nsd.Properties.Appearance.Options.UseBackColor = true;
            this.t_nsd.Size = new System.Drawing.Size(187, 20);
            this.t_nsd.TabIndex = 12;
            // 
            // t_madv
            // 
            this.t_madv.Location = new System.Drawing.Point(149, 38);
            this.t_madv.Name = "t_madv";
            this.t_madv.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.t_madv.Properties.Appearance.Options.UseBackColor = true;
            this.t_madv.Size = new System.Drawing.Size(187, 20);
            this.t_madv.TabIndex = 13;
            this.t_madv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_madv_KeyDown_2);
            // 
            // frmlogin
            // 
            this.AcceptButton = this.b_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.b_cancel;
            this.ClientSize = new System.Drawing.Size(477, 311);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BSH- Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checksave.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_pass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_nsd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_madv.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton b_cancel;
        private DevExpress.XtraEditors.SimpleButton b_login;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit checksave;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkfogetpass;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit t_pass;
        private DevExpress.XtraEditors.TextEdit t_madv;
        private DevExpress.XtraEditors.TextEdit t_nsd;
    }
}