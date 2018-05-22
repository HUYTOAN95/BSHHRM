namespace BSHHRMCNTTT.GUI
{
    partial class BSH_ChucVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSH_ChucVu));
            this.GridView = new System.Windows.Forms.DataGridView();
            this.grbinfo = new System.Windows.Forms.GroupBox();
            this.txtma = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txthscv = new DevExpress.XtraEditors.TextEdit();
            this.macv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hscv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.grbinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthscv.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macv,
            this.tencv,
            this.hscv});
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.GridColor = System.Drawing.SystemColors.Control;
            this.GridView.Location = new System.Drawing.Point(12, 12);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.GridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridView.Size = new System.Drawing.Size(382, 387);
            this.GridView.TabIndex = 0;
            this.GridView.Click += new System.EventHandler(this.GridView_Click);
            // 
            // grbinfo
            // 
            this.grbinfo.Controls.Add(this.txthscv);
            this.grbinfo.Controls.Add(this.labelControl3);
            this.grbinfo.Controls.Add(this.txtma);
            this.grbinfo.Controls.Add(this.labelControl2);
            this.grbinfo.Controls.Add(this.txtten);
            this.grbinfo.Controls.Add(this.labelControl1);
            this.grbinfo.Location = new System.Drawing.Point(400, 6);
            this.grbinfo.Name = "grbinfo";
            this.grbinfo.Size = new System.Drawing.Size(295, 179);
            this.grbinfo.TabIndex = 1;
            this.grbinfo.TabStop = false;
            this.grbinfo.Text = "Thông Tin";
            this.grbinfo.Enter += new System.EventHandler(this.grbinfo_Enter);
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(51, 58);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(133, 20);
            this.txtma.TabIndex = 3;
            this.txtma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtma_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(14, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mã";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(51, 90);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(238, 20);
            this.txtten.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 95);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên ";
            // 
            // btndelete
            // 
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(597, 351);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(62, 28);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "&Xóa";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(422, 351);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(62, 28);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "&Mới";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.Location = new System.Drawing.Point(509, 351);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(62, 28);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "&Lưu";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Hệ số ";
            // 
            // txthscv
            // 
            this.txthscv.Location = new System.Drawing.Point(51, 122);
            this.txthscv.Name = "txthscv";
            this.txthscv.Properties.Mask.EditMask = "n";
            this.txthscv.Size = new System.Drawing.Size(93, 20);
            this.txthscv.TabIndex = 5;
            // 
            // macv
            // 
            this.macv.DataPropertyName = "macv";
            this.macv.HeaderText = "Mã";
            this.macv.Name = "macv";
            this.macv.ReadOnly = true;
            // 
            // tencv
            // 
            this.tencv.DataPropertyName = "tencv";
            this.tencv.HeaderText = "Tên";
            this.tencv.Name = "tencv";
            this.tencv.ReadOnly = true;
            this.tencv.Width = 250;
            // 
            // hscv
            // 
            this.hscv.DataPropertyName = "hscv";
            this.hscv.HeaderText = "Hệ Số";
            this.hscv.Name = "hscv";
            this.hscv.ReadOnly = true;
            // 
            // BSH_ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 404);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.grbinfo);
            this.Controls.Add(this.GridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "BSH_ChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức Vụ";
            this.Load += new System.EventHandler(this.BSH_ChucVu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BSH_ChucVu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.grbinfo.ResumeLayout(false);
            this.grbinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthscv.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.GroupBox grbinfo;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.TextEdit txtma;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.SimpleButton btnedit;
        private DevExpress.XtraEditors.TextEdit txthscv;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DataGridViewTextBoxColumn macv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hscv;
    }
}