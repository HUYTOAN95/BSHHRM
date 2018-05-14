namespace BSHHRMCNTTT.SysForm
{
    partial class frmlselect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlselect));
            this.grbnsd = new System.Windows.Forms.GroupBox();
            this.t_fillter = new System.Windows.Forms.TextBox();
            this.cbbitem = new System.Windows.Forms.ComboBox();
            this.b_filter = new DevExpress.XtraEditors.SimpleButton();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.b_choose = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grbnsd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // grbnsd
            // 
            this.grbnsd.Controls.Add(this.t_fillter);
            this.grbnsd.Controls.Add(this.cbbitem);
            this.grbnsd.Controls.Add(this.b_filter);
            this.grbnsd.Controls.Add(this.gridview);
            this.grbnsd.Controls.Add(this.b_choose);
            this.grbnsd.Location = new System.Drawing.Point(12, 12);
            this.grbnsd.Name = "grbnsd";
            this.grbnsd.Size = new System.Drawing.Size(454, 292);
            this.grbnsd.TabIndex = 0;
            this.grbnsd.TabStop = false;
            this.grbnsd.Text = "NSD";
            // 
            // t_fillter
            // 
            this.t_fillter.Location = new System.Drawing.Point(294, 21);
            this.t_fillter.Name = "t_fillter";
            this.t_fillter.Size = new System.Drawing.Size(150, 21);
            this.t_fillter.TabIndex = 4;
            // 
            // cbbitem
            // 
            this.cbbitem.FormattingEnabled = true;
            this.cbbitem.Location = new System.Drawing.Point(169, 21);
            this.cbbitem.Name = "cbbitem";
            this.cbbitem.Size = new System.Drawing.Size(121, 21);
            this.cbbitem.TabIndex = 3;
            // 
            // b_filter
            // 
            this.b_filter.Location = new System.Drawing.Point(87, 20);
            this.b_filter.Name = "b_filter";
            this.b_filter.Size = new System.Drawing.Size(75, 23);
            this.b_filter.TabIndex = 2;
            this.b_filter.Text = "Lọc";
            this.b_filter.Click += new System.EventHandler(this.b_filter_Click);
            // 
            // gridview
            // 
            this.gridview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(6, 54);
            this.gridview.Name = "gridview";
            this.gridview.Size = new System.Drawing.Size(440, 222);
            this.gridview.TabIndex = 0;
            // 
            // b_choose
            // 
            this.b_choose.Location = new System.Drawing.Point(6, 20);
            this.b_choose.Name = "b_choose";
            this.b_choose.Size = new System.Drawing.Size(75, 23);
            this.b_choose.TabIndex = 1;
            this.b_choose.Text = "Chọn ";
            this.b_choose.Click += new System.EventHandler(this.b_choose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "BSHHRM-2018";
            // 
            // frmlselect
            // 
            this.AcceptButton = this.b_choose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbnsd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmlselect";
            this.Text = "BSH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmlselect_FormClosed);
            this.Load += new System.EventHandler(this.frmConnectDB_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmlselect_KeyDown);
            this.grbnsd.ResumeLayout(false);
            this.grbnsd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbnsd;
        private System.Windows.Forms.DataGridView gridview;
        private DevExpress.XtraEditors.SimpleButton b_filter;
        private DevExpress.XtraEditors.SimpleButton b_choose;
        private System.Windows.Forms.TextBox t_fillter;
        public System.Windows.Forms.ComboBox cbbitem;
        private System.Windows.Forms.Label label1;
    }
}