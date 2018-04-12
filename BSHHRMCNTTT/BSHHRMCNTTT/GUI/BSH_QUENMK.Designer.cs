namespace BSHHRMCNTTT.SysForm
{
    partial class BSH_QUENMK
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
            this.grbinfo = new DevExpress.XtraEditors.GroupControl();
            this.label4 = new System.Windows.Forms.Label();
            this.t_nsd = new System.Windows.Forms.TextBox();
            this.t_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_manv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_madv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.b_accept = new DevExpress.XtraEditors.SimpleButton();
            this.grbkey = new System.Windows.Forms.GroupBox();
            this.t_passnew = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.t_key = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grbinfo)).BeginInit();
            this.grbinfo.SuspendLayout();
            this.grbkey.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbinfo
            // 
            this.grbinfo.Controls.Add(this.label4);
            this.grbinfo.Controls.Add(this.t_nsd);
            this.grbinfo.Controls.Add(this.t_email);
            this.grbinfo.Controls.Add(this.label3);
            this.grbinfo.Controls.Add(this.t_manv);
            this.grbinfo.Controls.Add(this.label2);
            this.grbinfo.Controls.Add(this.t_madv);
            this.grbinfo.Controls.Add(this.label1);
            this.grbinfo.Location = new System.Drawing.Point(22, 12);
            this.grbinfo.Name = "grbinfo";
            this.grbinfo.Size = new System.Drawing.Size(525, 256);
            this.grbinfo.TabIndex = 0;
            this.grbinfo.Text = "Thông tin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã Đơn Vị";
            // 
            // t_nsd
            // 
            this.t_nsd.Location = new System.Drawing.Point(172, 87);
            this.t_nsd.Name = "t_nsd";
            this.t_nsd.Size = new System.Drawing.Size(201, 21);
            this.t_nsd.TabIndex = 6;
            // 
            // t_email
            // 
            this.t_email.Location = new System.Drawing.Point(172, 151);
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(256, 21);
            this.t_email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // t_manv
            // 
            this.t_manv.Location = new System.Drawing.Point(172, 119);
            this.t_manv.Name = "t_manv";
            this.t_manv.Size = new System.Drawing.Size(201, 21);
            this.t_manv.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // t_madv
            // 
            this.t_madv.Location = new System.Drawing.Point(172, 49);
            this.t_madv.Name = "t_madv";
            this.t_madv.Size = new System.Drawing.Size(201, 21);
            this.t_madv.TabIndex = 1;
            this.t_madv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.t_madv_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(294, 279);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 2;
            this.b_cancel.Text = "Hủy bỏ";
            // 
            // b_accept
            // 
            this.b_accept.Location = new System.Drawing.Point(192, 279);
            this.b_accept.Name = "b_accept";
            this.b_accept.Size = new System.Drawing.Size(75, 23);
            this.b_accept.TabIndex = 1;
            this.b_accept.Text = "Xác nhận ";
            this.b_accept.Click += new System.EventHandler(this.b_accept_Click);
            // 
            // grbkey
            // 
            this.grbkey.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbkey.Controls.Add(this.t_passnew);
            this.grbkey.Controls.Add(this.label6);
            this.grbkey.Controls.Add(this.t_key);
            this.grbkey.Controls.Add(this.label5);
            this.grbkey.Location = new System.Drawing.Point(22, 12);
            this.grbkey.Name = "grbkey";
            this.grbkey.Size = new System.Drawing.Size(525, 256);
            this.grbkey.TabIndex = 8;
            this.grbkey.TabStop = false;
            this.grbkey.Text = "Nhập mã key ";
            // 
            // t_passnew
            // 
            this.t_passnew.Location = new System.Drawing.Point(147, 116);
            this.t_passnew.Name = "t_passnew";
            this.t_passnew.Size = new System.Drawing.Size(234, 21);
            this.t_passnew.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Đặt lại mật khẩu";
            // 
            // t_key
            // 
            this.t_key.Location = new System.Drawing.Point(147, 85);
            this.t_key.Name = "t_key";
            this.t_key.Size = new System.Drawing.Size(234, 21);
            this.t_key.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhập Key";
            // 
            // frmforgetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 316);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_accept);
            this.Controls.Add(this.grbinfo);
            this.Controls.Add(this.grbkey);
            this.Name = "frmforgetpassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên Mật Khẩu";
            this.Load += new System.EventHandler(this.frmforgetpassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grbinfo)).EndInit();
            this.grbinfo.ResumeLayout(false);
            this.grbinfo.PerformLayout();
            this.grbkey.ResumeLayout(false);
            this.grbkey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grbinfo;
        private System.Windows.Forms.TextBox t_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_manv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_madv;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton b_accept;
        private DevExpress.XtraEditors.SimpleButton b_cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_nsd;
        private System.Windows.Forms.GroupBox grbkey;
        private System.Windows.Forms.TextBox t_passnew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_key;
        private System.Windows.Forms.Label label5;
    }
}