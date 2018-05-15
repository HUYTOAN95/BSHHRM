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
using System.Data.SqlClient;
using BSHHRMCNTTT.SO;

namespace BSHHRMCNTTT.GUI
{
    public partial class BSH_NhanVien : DevExpress.XtraEditors.XtraForm
    {
        private DBConnection db;
        public BSH_NhanVien()
        {
            db = new DBConnection();
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
            switch (e.KeyCode)
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

        private void txtmacd_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    using (BSH_CheDo frm = new BSH_CheDo())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txtmacd.Text = frm.Selected;
                            txtmacd.SelectionStart = txtmacd.Text.Length;
                            txttencd.Text = frm.Selected1;
                            txttencd.SelectionStart = txttencd.Text.Length;


                        }
                    }
                    break;
            }
        }

        private void textEdit15_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    using (BSH_BacLuong frm = new BSH_BacLuong())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            textEdit15.Text = frm.Selected2;
                            textEdit15.SelectionStart = textEdit15.Text.Length;

                        }
                    }
                    break;
            }
        }

        private void txtkyluat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    using (BSH_KyLuat frm = new BSH_KyLuat())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txtkyluat.Text = frm.Selected;
                            txtkyluat.SelectionStart = txtkyluat.Text.Length;
                            txttenkl.Text = frm.Selected1;
                            txttenkl.SelectionStart = txttenkl.Text.Length;

                        }
                    }
                    break;
            }
        }

        private void txtkhen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    using (BSH_KhenThuong frm = new BSH_KhenThuong())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txtkhen.Text = frm.Selected;
                            txtkhen.SelectionStart = txtkhen.Text.Length;
                            txttenkhen.Text = frm.Selected1;
                            txttenkhen.SelectionStart = txttenkhen.Text.Length;

                        }
                    }
                    break;
            }
        }

        private void txtsohd_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    try
                    {
                        string query = string.Format("SPBSH_AUTO_IDHD");
                        SqlParameter[] para = new SqlParameter[0];
                        txtsohd.Text = db.STR_LKE(query);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    break;
            }
        }

        private void cbbloaihd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbloaihd.SelectedItem.ToString().Trim() == "1 Năm")
                ngaykt.Text = DateTime.Now.AddYears(1).ToString();
            else if (cbbloaihd.SelectedItem.ToString().Trim() == "2 Năm")
                ngaykt.Text = DateTime.Now.AddYears(2).ToString();
            else if (cbbloaihd.SelectedItem.ToString().Trim() == "3 Năm")
                ngaykt.Text = DateTime.Now.AddYears(3).ToString();
        }

        private void txtmanv_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    try
                    {
                        string query = string.Format("SPBSH_AUTO_IDNV");
                        SqlParameter[] para = new SqlParameter[0];
                        txtmanv.Text = db.STR_LKE(query);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    break;
            }
        }
    }
}