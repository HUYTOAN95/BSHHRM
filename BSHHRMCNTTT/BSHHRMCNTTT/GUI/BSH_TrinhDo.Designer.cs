namespace BSHHRMCNTTT.GUI
{
    partial class BSH_TrinhDo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSH_TrinhDo));
            this.GridView = new System.Windows.Forms.DataGridView();
            this.matd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtchuyennganh = new DevExpress.XtraEditors.TextEdit();
            this.txttrinhdo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtchuyennganh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttrinhdo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matd,
            this.tentd,
            this.tencn});
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.GridView.Location = new System.Drawing.Point(3, 10);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridView.Size = new System.Drawing.Size(372, 389);
            this.GridView.TabIndex = 0;
            this.GridView.Click += new System.EventHandler(this.GridView_Click);
            // 
            // matd
            // 
            this.matd.DataPropertyName = "matd";
            this.matd.HeaderText = "Mã";
            this.matd.Name = "matd";
            this.matd.ReadOnly = true;
            this.matd.Width = 50;
            // 
            // tentd
            // 
            this.tentd.DataPropertyName = "tentd";
            this.tentd.HeaderText = "Trình Độ";
            this.tentd.Name = "tentd";
            this.tentd.ReadOnly = true;
            // 
            // tencn
            // 
            this.tencn.DataPropertyName = "tencn";
            this.tencn.HeaderText = "Chuyên Ngành ";
            this.tencn.Name = "tencn";
            this.tencn.ReadOnly = true;
            this.tencn.Width = 250;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtchuyennganh);
            this.groupBox1.Controls.Add(this.txttrinhdo);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Location = new System.Drawing.Point(381, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // txtchuyennganh
            // 
            this.txtchuyennganh.Location = new System.Drawing.Point(94, 74);
            this.txtchuyennganh.Name = "txtchuyennganh";
            this.txtchuyennganh.Size = new System.Drawing.Size(220, 20);
            this.txtchuyennganh.TabIndex = 5;
            // 
            // txttrinhdo
            // 
            this.txttrinhdo.Location = new System.Drawing.Point(94, 40);
            this.txttrinhdo.Name = "txttrinhdo";
            this.txttrinhdo.Size = new System.Drawing.Size(220, 20);
            this.txttrinhdo.TabIndex = 4;
            this.txttrinhdo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttrinhdo_KeyDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Chuyên Ngành ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Trình Độ";
            // 
            // btndelete
            // 
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(596, 342);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(66, 28);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "&Xóa";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnedit.Location = new System.Drawing.Point(510, 342);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(66, 28);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "&Lưu";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(425, 342);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(66, 28);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "&Mới";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // BSH_TrinhDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 404);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "BSH_TrinhDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trình Độ ";
            this.Load += new System.EventHandler(this.BSH_TrinhDo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BSH_TrinhDo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtchuyennganh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttrinhdo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtchuyennganh;
        private DevExpress.XtraEditors.TextEdit txttrinhdo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnedit;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn matd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencn;
    }
}