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

            ViewForm(frm);
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
            ViewForm(frm);
        }
    }
}