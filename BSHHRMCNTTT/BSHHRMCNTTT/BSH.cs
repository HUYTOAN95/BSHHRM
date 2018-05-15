using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BSHHRMCNTTT.SysForm;
using BSHHRMCNTTT.GUI;

namespace BSHHRMCNTTT
{
    public partial class BSH : DevExpress.XtraEditors.XtraForm
    {
        public BSH()
        {
            InitializeComponent();
        }
        private bool IsFormActivated(Form form)
        {
            bool IsOpen = false;
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form.Name == item.Name)
                    {
                        xtraTabbedMdiManager.Pages[item].MdiChild.Activate();
                        IsOpen = true;
                    }
                }

            }
            return IsOpen;

        }
        private void ViewForm(Form _form)
        {
            if (!IsFormActivated(_form))
            {
                _form.MdiParent = this;
                _form.StartPosition = FormStartPosition.CenterScreen;
                _form.WindowState = FormWindowState.Normal;
                _form.Show();
            }
        }
        private void barButtonItemDN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn muốn đăng xuất  !", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                frmlogin frm = new frmlogin();
                frm.ShowDialog();
               
            }
            
              

        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            itemstart.Caption = "Program is running !";
            itemauthor.Caption = "Nguyễn Huy Toàn THKT56 ";
        }

        private void frmmain_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

       

        private void frmmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

    
       

        private void ItemMaNSD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BSH_NSD frm = new BSH_NSD();

            //ViewForm(frm);
            frm.ShowDialog();
        }

        private void ItemDMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BSH_DMK frm = new BSH_DMK();
            ViewForm(frm);
        }

        private void ItemHopdong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ItemPB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            BSH_PBAN frm = new BSH_PBAN();
            //ViewForm(frm);
            frm.ShowDialog();
        }

        private void ItemCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BSH_ChucVu frm = new BSH_ChucVu();
            //ViewForm(frm);
            frm.ShowDialog();
        }

        private void ItemHSNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BSH_NhanVien frm = new BSH_NhanVien();
            frm.ShowDialog();
        }

        

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BSH_CheDo frm = new BSH_CheDo();
            frm.ShowDialog();
        }

        private void ItemTrinhDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BSH_TrinhDo frm = new BSH_TrinhDo();
            frm.ShowDialog();
        }

        private void ItemKhenThuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BSH_KhenThuong frm = new BSH_KhenThuong();
            frm.ShowDialog();
        }

        private void ItemKyLuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BSH_KyLuat frm = new BSH_KyLuat();
            frm.ShowDialog();
        }

        private void ItemDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            frmlogin frm = new frmlogin();
            frm.ShowDialog();
            
        }

        private void ItemDantoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BSH_DanToc frm = new BSH_DanToc();
            frm.ShowDialog();
     
        }

        private void itemtongiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BSH_TonGiao frm = new BSH_TonGiao();
            frm.ShowDialog();
        }
    }
}