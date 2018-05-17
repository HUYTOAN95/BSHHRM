namespace BSHHRMCNTTT.GUI
{
    partial class BSH_CheDo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSH_CheDo));
            this.GridView = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.macd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macd,
            this.tencd});
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.Location = new System.Drawing.Point(7, 9);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridView.Size = new System.Drawing.Size(338, 390);
            this.GridView.TabIndex = 0;
            this.GridView.Click += new System.EventHandler(this.GridView_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtten);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(351, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(290, 92);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(60, 43);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(225, 20);
            this.txtten.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // btnadd
            // 
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(375, 348);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(66, 28);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "&Mới";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.Location = new System.Drawing.Point(466, 348);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(66, 28);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "&Lưu";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(560, 348);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(66, 28);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "&Xóa";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // macd
            // 
            this.macd.DataPropertyName = "MaCD";
            this.macd.HeaderText = "Mã";
            this.macd.Name = "macd";
            this.macd.ReadOnly = true;
            this.macd.Width = 50;
            // 
            // tencd
            // 
            this.tencd.DataPropertyName = "TenLoaiCD";
            this.tencd.HeaderText = "Tên";
            this.tencd.Name = "tencd";
            this.tencd.ReadOnly = true;
            this.tencd.Width = 300;
            // 
            // BSH_CheDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 404);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GridView);
            this.KeyPreview = true;
            this.Name = "BSH_CheDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chế Độ";
            this.Load += new System.EventHandler(this.BSH_CheDo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BSH_CheDo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtten;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.SimpleButton btnedit;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn macd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencd;
    }
}