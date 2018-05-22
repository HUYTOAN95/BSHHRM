namespace BSHHRMCNTTT.GUI
{
    partial class BSH_ChamCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSH_ChamCong));
            this.GridView = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtSNN = new DevExpress.XtraEditors.TextEdit();
            this.txtSNC = new DevExpress.XtraEditors.TextEdit();
            this.txtmanv = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNNCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSNN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSNC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanv.Properties)).BeginInit();
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
            this.SNLV,
            this.SNNCP,
            this.Thang,
            this.Nam});
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.Location = new System.Drawing.Point(12, 12);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridView.Size = new System.Drawing.Size(441, 433);
            this.GridView.TabIndex = 0;
            this.GridView.Click += new System.EventHandler(this.GridView_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtSNN);
            this.groupControl1.Controls.Add(this.txtSNC);
            this.groupControl1.Controls.Add(this.txtmanv);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(459, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(297, 192);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thông tin";
            // 
            // txtSNN
            // 
            this.txtSNN.Location = new System.Drawing.Point(86, 110);
            this.txtSNN.Name = "txtSNN";
            this.txtSNN.Size = new System.Drawing.Size(100, 20);
            this.txtSNN.TabIndex = 5;
            // 
            // txtSNC
            // 
            this.txtSNC.Location = new System.Drawing.Point(86, 70);
            this.txtSNC.Name = "txtSNC";
            this.txtSNC.Size = new System.Drawing.Size(100, 20);
            this.txtSNC.TabIndex = 4;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(85, 32);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(170, 20);
            this.txtmanv.TabIndex = 3;
            this.txtmanv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmanv_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 113);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 26);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Số ngày nghỉ\r\n( có phép)";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Số ngày công";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã nhân viên";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            // 
            // SNLV
            // 
            this.SNLV.DataPropertyName = "SNLV";
            this.SNLV.HeaderText = "Số ngày làm việc";
            this.SNLV.Name = "SNLV";
            this.SNLV.Width = 120;
            // 
            // SNNCP
            // 
            this.SNNCP.DataPropertyName = "SNNCP";
            this.SNNCP.HeaderText = "Số ngày nghỉ có phép";
            this.SNNCP.Name = "SNNCP";
            this.SNNCP.Width = 150;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Tháng";
            this.Thang.Name = "Thang";
            this.Thang.Width = 50;
            // 
            // Nam
            // 
            this.Nam.DataPropertyName = "Nam";
            this.Nam.HeaderText = "Năm";
            this.Nam.Name = "Nam";
            // 
            // btndelete
            // 
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(648, 393);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(66, 28);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "&Xóa";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.Location = new System.Drawing.Point(575, 393);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(66, 28);
            this.btnedit.TabIndex = 7;
            this.btnedit.Text = "&Lưu";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(502, 393);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(66, 28);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "&Mới";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // BSH_ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 446);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GridView);
            this.Name = "BSH_ChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Ngày Công ";
            this.Load += new System.EventHandler(this.BSH_ChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSNN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSNC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanv.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnedit;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtSNN;
        private DevExpress.XtraEditors.TextEdit txtSNC;
        private DevExpress.XtraEditors.TextEdit txtmanv;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNNCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
    }
}