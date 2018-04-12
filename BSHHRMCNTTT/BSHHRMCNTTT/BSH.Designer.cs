namespace BSHHRMCNTTT
{
    partial class BSH
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSH));
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonControlHT = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemDX = new DevExpress.XtraBars.BarButtonItem();
            this.itemstart = new DevExpress.XtraBars.BarHeaderItem();
            this.itemauthor = new DevExpress.XtraBars.BarHeaderItem();
            this.barButtonItemNSD = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDMK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSLDL = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemPHDL = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.ribbonPageHT = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupHT = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupDL = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupTheme = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageQL = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlHT)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // ribbonControlHT
            // 
            this.ribbonControlHT.ExpandCollapseItem.Id = 0;
            this.ribbonControlHT.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlHT.ExpandCollapseItem,
            this.barButtonItemDX,
            this.itemstart,
            this.itemauthor,
            this.barButtonItemNSD,
            this.barButtonItemDMK,
            this.barButtonItemSLDL,
            this.barButtonItemPHDL,
            this.skinRibbonGalleryBarItem1});
            this.ribbonControlHT.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlHT.MaxItemId = 9;
            this.ribbonControlHT.Name = "ribbonControlHT";
            this.ribbonControlHT.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageHT,
            this.ribbonPageQL});
            this.ribbonControlHT.Size = new System.Drawing.Size(998, 141);
            this.ribbonControlHT.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonItemDX
            // 
            this.barButtonItemDX.Caption = "Đăng Xuất";
            this.barButtonItemDX.Id = 1;
            this.barButtonItemDX.Name = "barButtonItemDX";
            this.barButtonItemDX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDN_ItemClick);
            // 
            // itemstart
            // 
            this.itemstart.Caption = "Status";
            this.itemstart.Id = 2;
            this.itemstart.Name = "itemstart";
            // 
            // itemauthor
            // 
            this.itemauthor.Caption = "Author";
            this.itemauthor.Id = 3;
            this.itemauthor.Name = "itemauthor";
            // 
            // barButtonItemNSD
            // 
            this.barButtonItemNSD.Caption = "Người Dùng";
            this.barButtonItemNSD.Id = 4;
            this.barButtonItemNSD.Name = "barButtonItemNSD";
            this.barButtonItemNSD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemNSD_ItemClick);
            // 
            // barButtonItemDMK
            // 
            this.barButtonItemDMK.Caption = "Đổi Mật Khẩu";
            this.barButtonItemDMK.Id = 5;
            this.barButtonItemDMK.Name = "barButtonItemDMK";
            this.barButtonItemDMK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDMK_ItemClick);
            // 
            // barButtonItemSLDL
            // 
            this.barButtonItemSLDL.Caption = "Sao Lưu Dữ Liệu";
            this.barButtonItemSLDL.Id = 6;
            this.barButtonItemSLDL.Name = "barButtonItemSLDL";
            // 
            // barButtonItemPHDL
            // 
            this.barButtonItemPHDL.Caption = "Phục Hồi Dữ Liệu";
            this.barButtonItemPHDL.Id = 7;
            this.barButtonItemPHDL.Name = "barButtonItemPHDL";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 8;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // ribbonPageHT
            // 
            this.ribbonPageHT.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupHT,
            this.ribbonPageGroupDL,
            this.ribbonPageGroupTheme});
            this.ribbonPageHT.Name = "ribbonPageHT";
            this.ribbonPageHT.Text = "Hệ Thống";
            // 
            // ribbonPageGroupHT
            // 
            this.ribbonPageGroupHT.ItemLinks.Add(this.barButtonItemNSD);
            this.ribbonPageGroupHT.ItemLinks.Add(this.barButtonItemDMK);
            this.ribbonPageGroupHT.ItemLinks.Add(this.barButtonItemDX);
            this.ribbonPageGroupHT.Name = "ribbonPageGroupHT";
            this.ribbonPageGroupHT.Text = "Hệ Thống";
            // 
            // ribbonPageGroupDL
            // 
            this.ribbonPageGroupDL.ItemLinks.Add(this.barButtonItemSLDL);
            this.ribbonPageGroupDL.ItemLinks.Add(this.barButtonItemPHDL);
            this.ribbonPageGroupDL.Name = "ribbonPageGroupDL";
            this.ribbonPageGroupDL.Text = "Dữ Liệu";
            // 
            // ribbonPageGroupTheme
            // 
            this.ribbonPageGroupTheme.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroupTheme.Name = "ribbonPageGroupTheme";
            this.ribbonPageGroupTheme.Text = "Giao Diện";
            // 
            // ribbonPageQL
            // 
            this.ribbonPageQL.Name = "ribbonPageQL";
            this.ribbonPageQL.Text = "Quản Lý";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.itemstart);
            this.ribbonStatusBar1.ItemLinks.Add(this.itemauthor);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 374);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControlHT;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(998, 27);
            // 
            // BSH
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 401);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControlHT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "BSH";
            this.Text = "BSH - Human Resource Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmmain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmmain_FormClosed);
            this.Load += new System.EventHandler(this.frmmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlHT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlHT;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDX;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupHT;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarHeaderItem itemstart;
        private DevExpress.XtraBars.BarHeaderItem itemauthor;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNSD;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDMK;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSLDL;
        private DevExpress.XtraBars.BarButtonItem barButtonItemPHDL;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDL;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageQL;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupTheme;
    }
}