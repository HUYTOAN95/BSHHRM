namespace BSHHRMCNTTT.GUI
{
    partial class BSH_KyLuat
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
            this.GridView = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtsotien = new DevExpress.XtraEditors.TextEdit();
            this.txtlydo = new DevExpress.XtraEditors.TextEdit();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.MaKL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhThucKL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDoKL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienKL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsotien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlydo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowDrop = true;
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKL,
            this.HinhThucKL,
            this.LyDoKL,
            this.SoTienKL});
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.Location = new System.Drawing.Point(4, 12);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridView.Size = new System.Drawing.Size(412, 389);
            this.GridView.TabIndex = 0;
            this.GridView.Click += new System.EventHandler(this.GridView_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtsotien);
            this.groupControl1.Controls.Add(this.txtlydo);
            this.groupControl1.Controls.Add(this.txtten);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(422, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(282, 225);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin";
            // 
            // txtsotien
            // 
            this.txtsotien.Location = new System.Drawing.Point(74, 133);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Size = new System.Drawing.Size(203, 20);
            this.txtsotien.TabIndex = 3;
            // 
            // txtlydo
            // 
            this.txtlydo.Location = new System.Drawing.Point(74, 89);
            this.txtlydo.Name = "txtlydo";
            this.txtlydo.Size = new System.Drawing.Size(203, 20);
            this.txtlydo.TabIndex = 2;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(74, 46);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(203, 20);
            this.txtten.TabIndex = 1;
            this.txtten.ToolTip = "F2 để thu gọn thông tin ";
            this.txtten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtten_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 136);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Số tiền ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Lý do ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hình thức ";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(434, 356);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "&Thêm";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(519, 356);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 5;
            this.btnedit.Text = "&Sửa";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(608, 356);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "&Xóa";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // MaKL
            // 
            this.MaKL.DataPropertyName = "MaKL";
            this.MaKL.HeaderText = "Mã";
            this.MaKL.Name = "MaKL";
            this.MaKL.ReadOnly = true;
            this.MaKL.Width = 50;
            // 
            // HinhThucKL
            // 
            this.HinhThucKL.DataPropertyName = "HinhThucKL";
            this.HinhThucKL.HeaderText = "Hình thức";
            this.HinhThucKL.Name = "HinhThucKL";
            this.HinhThucKL.ReadOnly = true;
            this.HinhThucKL.Width = 150;
            // 
            // LyDoKL
            // 
            this.LyDoKL.DataPropertyName = "LyDoKL";
            this.LyDoKL.HeaderText = "Lý do ";
            this.LyDoKL.Name = "LyDoKL";
            this.LyDoKL.ReadOnly = true;
            this.LyDoKL.Width = 180;
            // 
            // SoTienKL
            // 
            this.SoTienKL.DataPropertyName = "SoTienKL";
            this.SoTienKL.HeaderText = "Số tiền";
            this.SoTienKL.Name = "SoTienKL";
            this.SoTienKL.ReadOnly = true;
            this.SoTienKL.Width = 120;
            // 
            // BSH_KyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 404);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GridView);
            this.KeyPreview = true;
            this.Name = "BSH_KyLuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kỷ Luật";
            this.Load += new System.EventHandler(this.BSH_KyLuat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BSH_KyLuat_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsotien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlydo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.SimpleButton btnedit;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtsotien;
        private DevExpress.XtraEditors.TextEdit txtlydo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKL;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhThucKL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDoKL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienKL;
    }
}