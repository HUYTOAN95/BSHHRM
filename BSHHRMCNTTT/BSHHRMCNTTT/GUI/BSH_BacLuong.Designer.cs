namespace BSHHRMCNTTT.GUI
{
    partial class BSH_BacLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSH_BacLuong));
            this.GridView = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txthsl = new DevExpress.XtraEditors.TextEdit();
            this.txtbac = new DevExpress.XtraEditors.TextEdit();
            this.txtma = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthsl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).BeginInit();
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
            this.Ma,
            this.Bac,
            this.HSL});
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.Location = new System.Drawing.Point(5, 7);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.Size = new System.Drawing.Size(307, 359);
            this.GridView.TabIndex = 0;
            this.GridView.Click += new System.EventHandler(this.GridView_Click);
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Mã";
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            // 
            // Bac
            // 
            this.Bac.DataPropertyName = "Bac";
            this.Bac.HeaderText = "Bậc";
            this.Bac.Name = "Bac";
            this.Bac.ReadOnly = true;
            // 
            // HSL
            // 
            this.HSL.DataPropertyName = "HSL";
            this.HSL.HeaderText = "Hệ số lương";
            this.HSL.Name = "HSL";
            this.HSL.ReadOnly = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txthsl);
            this.groupControl1.Controls.Add(this.txtbac);
            this.groupControl1.Controls.Add(this.txtma);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(318, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(227, 152);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin";
            // 
            // txthsl
            // 
            this.txthsl.Location = new System.Drawing.Point(62, 96);
            this.txthsl.Name = "txthsl";
            this.txthsl.Size = new System.Drawing.Size(154, 20);
            this.txthsl.TabIndex = 5;
            // 
            // txtbac
            // 
            this.txtbac.Location = new System.Drawing.Point(62, 62);
            this.txtbac.Name = "txtbac";
            this.txtbac.Size = new System.Drawing.Size(100, 20);
            this.txtbac.TabIndex = 4;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(62, 32);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 99);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Hệ số ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(17, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Bậc";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(14, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã";
            // 
            // btnadd
            // 
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(327, 326);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(66, 28);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "&Mới";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.Location = new System.Drawing.Point(400, 326);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(66, 28);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "&Lưu";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(473, 326);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(66, 28);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "&Xóa";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // BSH_BacLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 369);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GridView);
            this.KeyPreview = true;
            this.Name = "BSH_BacLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bậc lương";
            this.Load += new System.EventHandler(this.BSH_BacLuong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BSH_BacLuong_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthsl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bac;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSL;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txthsl;
        private DevExpress.XtraEditors.TextEdit txtbac;
        private DevExpress.XtraEditors.TextEdit txtma;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.SimpleButton btnedit;
        private DevExpress.XtraEditors.SimpleButton btndelete;
    }
}