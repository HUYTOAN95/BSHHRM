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
using BSHHRMCNTTT.SO;
using System.Data.SqlClient;

namespace BSHHRMCNTTT.SysForm
{
    public partial class BSH_DMK : DevExpress.XtraEditors.XtraForm
    {
        private DBConnection db;

        public BSH_DMK()
        {
            db = new DBConnection();
            InitializeComponent();
        }

        private void BSH_DMK_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    ClearData();
                    break;
                case Keys.Escape:
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
            }
        }
        private void ClearData()
        {
         
            txtmkcu.Text = "";
            txtmkmoi.Text = "";
            txtnhapla.Text = "";
        }

        private void BSH_DMK_Load(object sender, EventArgs e)
        {
            txtmadv.Text = InfoNSD.madv;
            txtnsd.Text = InfoNSD.nsd;
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmkcu_Leave(object sender, EventArgs e)
        {
            if(txtmkcu.Text != InfoNSD.password)
            {
                XtraMessageBox.Show("Nhập sai mật khẩu, vui lòng kiểm tra lại ! ");
                txtmkcu.Focus();
                return;
            }
        }

        private void txtnhapla_Leave(object sender, EventArgs e)
        {
            if (txtmkmoi.Text != txtnhapla.Text)
            {
                XtraMessageBox.Show("Mật khẩu không trùng khớp , vui lòng kiểm tra lại! ");
                txtnhapla.Focus();
                return;
            }
        }

        private void txtnhapla_Enter(object sender, EventArgs e)
        {
            
        }

        private void b_commit_Click(object sender, EventArgs e)
        {
            if (txtmkmoi.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập mật khẩu mới! ");
                txtnhapla.Focus();
                return;
            }
            if (txtmkmoi.Text != txtnhapla.Text)
            {
                XtraMessageBox.Show("Mật khẩu không trùng khớp , vui lòng kiểm tra lại! ");
                txtnhapla.Focus();
                return;
            }
            if (txtmkcu.Text =="")
            {
                XtraMessageBox.Show("Vui lòng nhập mật khẩu cũ !");
                txtmkcu.Focus();
                return;
            }
            //try
            //{
                string pass = MD5Encrypt.Encrypt(txtnhapla.Text);
                string query = string.Format("SPBSH_MK_DOI");
                SqlParameter[] para = {
                new SqlParameter("@madv",txtmadv.Text),
                new SqlParameter("@nsd",txtnsd.Text),
                new SqlParameter("@matkhau",pass)
                };
                bool i = db.UpdateRecord(query, para);
                if (i == true)
                {
                    XtraMessageBox.Show("Thay đổi mật khẩu thành công !");
                   
                    ClearData();

                }
                else
                    XtraMessageBox.Show("Lỗi thay đổi mật khẩu , vui lòng kiểm tra lại!");
            //}
            //catch(Exception ex)
            //{
            //    throw ex;
            //}
        }
    }
}