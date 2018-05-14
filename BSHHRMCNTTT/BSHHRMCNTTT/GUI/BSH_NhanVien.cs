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

namespace BSHHRMCNTTT.GUI
{
    public partial class BSH_NhanVien : DevExpress.XtraEditors.XtraForm
    {
        public BSH_NhanVien()
        {
            InitializeComponent();
        }

        private void separatorControl1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BSH_NhanVien_Load(object sender, EventArgs e)
        {
            
        }

        private void txtmacv_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F1:
                    using (BSH_ChucVu frm = new BSH_ChucVu())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txtmacv.Text = frm.Selected;
                            txtmacv.SelectionStart = txtmacv.Text.Length;
                            txttencv.Text = frm.Selected2;
                            txttencv.SelectionStart = txttencv.Text.Length;

                        }
                    }
                        break;
            }
        }

        private void txtmapb_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    using (BSH_PBAN frm = new BSH_PBAN())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txtmapb.Text = frm.Selected;
                            txtmapb.SelectionStart = txtmapb.Text.Length;
                            txttenpb.Text = frm.Selected2;
                            txttenpb.SelectionStart = txttenpb.Text.Length;

                        }
                    }
                    break;
            }

        }

        private void txttongiao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    using (BSH_TonGiao frm = new BSH_TonGiao())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txttongiao.Text = frm.Selected;
                            txttongiao.SelectionStart = txttongiao.Text.Length;
                           
                        }
                    }
                    break;
            }
        }

        private void txtdantoc_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    using (BSH_DanToc frm = new BSH_DanToc())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txtdantoc.Text = frm.Selected;
                            txtdantoc.SelectionStart = txtdantoc.Text.Length;

                        }
                    }
                    break;
            }
        }

        private void txttentd_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtmatd_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtmatd_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    using (BSH_TrinhDo frm = new BSH_TrinhDo())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txtmatd.Text = frm.Selected;
                            txtmatd.SelectionStart = txtmatd.Text.Length;
                            txttentd.Text = frm.Selected1;
                            txttentd.SelectionStart = txttentd.Text.Length;
                            txtchuyenmon.Text = frm.Selected2;
                            txtchuyenmon.SelectionStart = txtchuyenmon.Text.Length;

                        }
                    }
                    break;
            }
        }
    }
}