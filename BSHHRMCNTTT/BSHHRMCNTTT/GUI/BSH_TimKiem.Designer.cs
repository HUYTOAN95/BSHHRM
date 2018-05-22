namespace BSHHRMCNTTT.GUI
{
    partial class BSH_TimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSH_TimKiem));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnloc = new DevExpress.XtraEditors.SimpleButton();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.btnprint = new DevExpress.XtraEditors.SimpleButton();
            this.cbbitem = new System.Windows.Forms.ComboBox();
            this.cbbfill = new System.Windows.Forms.ComboBox();
            this.txtdata = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mục ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(203, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Lọc theo";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtdata);
            this.groupControl1.Controls.Add(this.cbbfill);
            this.groupControl1.Controls.Add(this.cbbitem);
            this.groupControl1.Controls.Add(this.btnloc);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(640, 59);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Lọc dữ liệu";
            // 
            // btnloc
            // 
            this.btnloc.Image = ((System.Drawing.Image)(resources.GetObject("btnloc.Image")));
            this.btnloc.Location = new System.Drawing.Point(541, 23);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(62, 28);
            this.btnloc.TabIndex = 5;
            this.btnloc.Text = "&Lọc";
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.Location = new System.Drawing.Point(13, 97);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.Size = new System.Drawing.Size(952, 392);
            this.GridView.TabIndex = 5;
            // 
            // btnprint
            // 
            this.btnprint.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.Image")));
            this.btnprint.Location = new System.Drawing.Point(905, 495);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(62, 28);
            this.btnprint.TabIndex = 6;
            this.btnprint.Text = "&IN";
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // cbbitem
            // 
            this.cbbitem.FormattingEnabled = true;
            this.cbbitem.Items.AddRange(new object[] {
            "Nhân Viên",
            "Bảng Lương",
            "Phòng Ban"});
            this.cbbitem.Location = new System.Drawing.Point(66, 28);
            this.cbbitem.Name = "cbbitem";
            this.cbbitem.Size = new System.Drawing.Size(121, 21);
            this.cbbitem.TabIndex = 6;
            this.cbbitem.SelectedIndexChanged += new System.EventHandler(this.cbbitem_SelectedIndexChanged);
            // 
            // cbbfill
            // 
            this.cbbfill.FormattingEnabled = true;
            this.cbbfill.Location = new System.Drawing.Point(249, 28);
            this.cbbfill.Name = "cbbfill";
            this.cbbfill.Size = new System.Drawing.Size(121, 21);
            this.cbbfill.TabIndex = 7;
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(377, 29);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(144, 21);
            this.txtdata.TabIndex = 8;
            // 
            // BSH_TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 535);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.groupControl1);
            this.Name = "BSH_TimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnloc;
        private System.Windows.Forms.DataGridView GridView;
        private DevExpress.XtraEditors.SimpleButton btnprint;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.ComboBox cbbfill;
        private System.Windows.Forms.ComboBox cbbitem;
    }
}