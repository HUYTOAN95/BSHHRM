﻿namespace BSHHRMCNTTT.GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.grbinfo = new System.Windows.Forms.GroupBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.btnedit = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.txtma = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.macv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.grbinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macv,
            this.tencv});
            this.GridView.Location = new System.Drawing.Point(12, 12);
            this.GridView.Name = "GridView";
            this.GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridView.Size = new System.Drawing.Size(382, 330);
            this.GridView.TabIndex = 0;
            this.GridView.Click += new System.EventHandler(this.GridView_Click);
            // 
            // grbinfo
            // 
            this.grbinfo.Controls.Add(this.txtma);
            this.grbinfo.Controls.Add(this.labelControl2);
            this.grbinfo.Controls.Add(this.txtten);
            this.grbinfo.Controls.Add(this.labelControl1);
            this.grbinfo.Location = new System.Drawing.Point(400, 12);
            this.grbinfo.Name = "grbinfo";
            this.grbinfo.Size = new System.Drawing.Size(278, 187);
            this.grbinfo.TabIndex = 1;
            this.grbinfo.TabStop = false;
            this.grbinfo.Text = "Thông Tin";
            this.grbinfo.Enter += new System.EventHandler(this.grbinfo_Enter);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnedit);
            this.panelControl1.Controls.Add(this.btnadd);
            this.panelControl1.Location = new System.Drawing.Point(400, 282);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(278, 51);
            this.panelControl1.TabIndex = 2;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(18, 15);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "&Thêm Mới";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(99, 15);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "&Sửa Đổi";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(590, 297);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "&Xóa";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 100);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên ";
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(51, 95);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(221, 20);
            this.txtten.TabIndex = 1;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(51, 63);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(133, 20);
            this.txtma.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(14, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mã";
            // 
            // macv
            // 
            this.macv.DataPropertyName = "macv";
            this.macv.HeaderText = "Mã";
            this.macv.Name = "macv";
            // 
            // tencv
            // 
            this.tencv.DataPropertyName = "tencv";
            this.tencv.HeaderText = "Tên";
            this.tencv.Name = "tencv";
            this.tencv.Width = 300;
            // 
            // BSH_ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 345);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.grbinfo);
            this.Controls.Add(this.GridView);
            this.Name = "BSH_ChucVu";
            this.Text = "Chức Vụ";
            this.Load += new System.EventHandler(this.BSH_ChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.grbinfo.ResumeLayout(false);
            this.grbinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtma.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.GroupBox grbinfo;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnedit;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.TextEdit txtma;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn macv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencv;
    }
}