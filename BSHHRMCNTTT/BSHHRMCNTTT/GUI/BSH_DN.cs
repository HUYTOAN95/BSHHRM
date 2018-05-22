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
    public partial class frmlogin : DevExpress.XtraEditors.XtraForm
    {
        public frmlogin()
        {
            InitializeComponent();
            //t_madv.ForeColor = SystemColors.GrayText;
            //t_madv.Text = "Please Enter Ma Don Vi";
            //this.t_madv.Leave += new System.EventHandler(this.t_madv_Leave);
            //this.t_madv.Enter += new System.EventHandler(this.t_madv_Enter);
            //t_nsd.ForeColor = SystemColors.GrayText;
            //t_nsd.Text = "Please Enter User Name";
            //this.t_nsd.Leave += new System.EventHandler(this.t_nsd_Leave);
            //this.t_nsd.Enter += new System.EventHandler(this.t_nsd_Enter);
            //t_pass.ForeColor = SystemColors.GrayText;
            //t_pass.Text = "Please Enter Password";
            //this.t_pass.Leave += new System.EventHandler(this.t_pass_Leave);
            //this.t_pass.Enter += new System.EventHandler(this.t_pass_Enter);
            //t_pass.Properties.UseSystemPasswordChar = false;

        }

        private void t_pass_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void t_madv_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            if (t_madv.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show(" Mã đơn vị không được để trống!");

                t_madv.Focus();
                return;
            }
            if (t_nsd.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show(" Người sử dụng không được để trống!");
                t_nsd.Focus();
                return;
            }

            InfoNSD.madv = t_madv.Text;
            InfoNSD.nsd = t_nsd.Text;
            InfoNSD.password = t_pass.Text;
            string Password = MD5Encrypt.Encrypt(InfoNSD.password);
            SqlCommand cmd = new SqlCommand("SPBSH_NSD_DN", DBConnection.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma_dv", InfoNSD.madv);
            cmd.Parameters.AddWithValue("@nsd", InfoNSD.nsd);
            cmd.Parameters.AddWithValue("@matkhau", Password);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Int32.Parse(dr[0].ToString()) == 1)
                {
                    XtraMessageBox.Show("Tài khoản đăng nhập của bạn hết hạn", "Liên hệ admin", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
                else if (Int32.Parse(dr[0].ToString()) == 2)
                {
                    XtraMessageBox.Show("Đăng nhập thành công với quyên truy cập " + dr[1].ToString() + " !");
                    this.Hide();
                    BSH frm = new BSH();
                    frm.Show();
                }
                else
                    XtraMessageBox.Show("Đăng nhập thất bại ", "kiểm tra tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
        }

        private void t_madv_KeyDown_1(object sender, KeyEventArgs e)
        {

        }

        private void linkfogetpass_Click(object sender, EventArgs e)
        {
            BSH_QUENMK frm = new BSH_QUENMK();
            frm.Show();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            frmConnectDB frm = new frmConnectDB();
            frm.Show();
            this.Hide();

        }

        private void t_madv_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_madv_KeyDown_2(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.F1:
                    {
                        frmlselect frm = new frmlselect();
                        frm.caption = "Danh sách NSD";
                        frm.query = "SELECT * FROM View_bsh_nsd";
                        frm.cbbitem.Items.Add("Người sử dụng");
                        frm.cbbitem.Items.Add("Mã đơn vị");

                        using (frm)
                        {
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                t_madv.Text = frm.Selected;
                                t_madv.SelectionStart = t_madv.Text.Length;
                                t_nsd.Text = frm.Selected2;
                                t_nsd.SelectionStart = t_nsd.Text.Length;

                            }
                        }
                    }
                    break;
            }
        }

        private void t_madv_Leave(object sender, EventArgs e)
        {
            if (t_madv.Text.Length == 0)
            {
                t_madv.Text = "Please Enter Ma Don Vi";
                t_madv.ForeColor = SystemColors.GrayText;
            }
        }

        private void t_madv_Enter(object sender, EventArgs e)
        {
            if (t_madv.Text.Length == 0)
            {
                t_madv.Text = "Please Enter Ma Don Vi";
                t_madv.ForeColor = SystemColors.WindowText;
            }
        }

        private void t_nsd_Enter(object sender, EventArgs e)
        {
            if (t_nsd.Text.Length == 0)
            {
                t_nsd.Text = "Please Enter User Name";
                t_nsd.ForeColor = SystemColors.WindowText;
            }
        }

        private void t_nsd_Leave(object sender, EventArgs e)
        {
            if (t_nsd.Text.Length == 0)
            {
                t_nsd.Text = "Please Enter User Name";
                t_nsd.ForeColor = SystemColors.GrayText;
            }
        }

        private void t_pass_Enter(object sender, EventArgs e)
        {
            if (t_pass.Text.Length == 0)
            {
                t_pass.Text = "Please Enter Password";
                t_pass.ForeColor = SystemColors.WindowText;
            }
            //t_pass.SelectionStart = 0;
            //t_pass.SelectionLength = t_pass.Text.Length;
        }

        private void t_pass_Leave(object sender, EventArgs e)
        {
            if (t_pass.Text.Length == 0)
            {
                t_pass.Text = "Please Enter Password";
                t_pass.ForeColor = SystemColors.GrayText;
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void frmlogin_Shown(object sender, EventArgs e)
        {

        }

        private void frmlogin_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void t_pass_EditValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}