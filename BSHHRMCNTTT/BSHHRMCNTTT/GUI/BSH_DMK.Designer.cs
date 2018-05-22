namespace BSHHRMCNTTT.SysForm
{
    partial class BSH_DMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSH_DMK));
            this.b_commit = new DevExpress.XtraEditors.SimpleButton();
            this.b_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtnhapla = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmkmoi = new DevExpress.XtraEditors.TextEdit();
            this.txtmkcu = new DevExpress.XtraEditors.TextEdit();
            this.txtnsd = new DevExpress.XtraEditors.TextEdit();
            this.txtmadv = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnhapla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmkmoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmkcu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnsd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmadv.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // b_commit
            // 
            this.b_commit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_commit.Image = ((System.Drawing.Image)(resources.GetObject("b_commit.Image")));
            this.b_commit.Location = new System.Drawing.Point(123, 254);
            this.b_commit.Name = "b_commit";
            this.b_commit.Size = new System.Drawing.Size(62, 28);
            this.b_commit.TabIndex = 10;
            this.b_commit.Text = "&Lưu";
            this.b_commit.Click += new System.EventHandler(this.b_commit_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_cancel.Image = ((System.Drawing.Image)(resources.GetObject("b_cancel.Image")));
            this.b_cancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.b_cancel.Location = new System.Drawing.Point(201, 254);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(62, 28);
            this.b_cancel.TabIndex = 11;
            this.b_cancel.Text = "&Hủy";
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtnhapla);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtmkmoi);
            this.groupControl1.Controls.Add(this.txtmkcu);
            this.groupControl1.Controls.Add(this.txtnsd);
            this.groupControl1.Controls.Add(this.txtmadv);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(19, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(368, 229);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "&Thông tin";
            // 
            // txtnhapla
            // 
            this.txtnhapla.Location = new System.Drawing.Point(124, 180);
            this.txtnhapla.Name = "txtnhapla";
            this.txtnhapla.Properties.UseSystemPasswordChar = true;
            this.txtnhapla.Size = new System.Drawing.Size(201, 20);
            this.txtnhapla.TabIndex = 19;
            this.txtnhapla.Enter += new System.EventHandler(this.txtnhapla_Enter);
            this.txtnhapla.Leave += new System.EventHandler(this.txtnhapla_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mật khẩu mới";
            // 
            // txtmkmoi
            // 
            this.txtmkmoi.Location = new System.Drawing.Point(124, 142);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.Properties.UseSystemPasswordChar = true;
            this.txtmkmoi.Size = new System.Drawing.Size(201, 20);
            this.txtmkmoi.TabIndex = 16;
            // 
            // txtmkcu
            // 
            this.txtmkcu.Location = new System.Drawing.Point(124, 103);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Properties.UseSystemPasswordChar = true;
            this.txtmkcu.Size = new System.Drawing.Size(201, 20);
            this.txtmkcu.TabIndex = 15;
            this.txtmkcu.Leave += new System.EventHandler(this.txtmkcu_Leave);
            // 
            // txtnsd
            // 
            this.txtnsd.Location = new System.Drawing.Point(124, 68);
            this.txtnsd.Name = "txtnsd";
            this.txtnsd.Size = new System.Drawing.Size(201, 20);
            this.txtnsd.TabIndex = 14;
            // 
            // txtmadv
            // 
            this.txtmadv.Location = new System.Drawing.Point(124, 32);
            this.txtmadv.Name = "txtmadv";
            this.txtmadv.Size = new System.Drawing.Size(201, 20);
            this.txtmadv.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "NSD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã đơn vị";
            // 
            // BSH_DMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 290);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_commit);
            this.KeyPreview = true;
            this.Name = "BSH_DMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BSH - Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.BSH_DMK_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BSH_DMK_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnhapla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmkmoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmkcu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnsd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmadv.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton b_commit;
        private DevExpress.XtraEditors.SimpleButton b_cancel;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtnhapla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtmkmoi;
        private DevExpress.XtraEditors.TextEdit txtmkcu;
        private DevExpress.XtraEditors.TextEdit txtnsd;
        private DevExpress.XtraEditors.TextEdit txtmadv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}