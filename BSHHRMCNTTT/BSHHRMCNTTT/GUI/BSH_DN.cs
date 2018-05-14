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
            string pass = MD5Encrypt.Encrypt(t_pass.Text);
            SqlCommand cmd = new SqlCommand("SPBSH_NSD_DN", DBConnection.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma_dv", t_madv.Text);
            cmd.Parameters.AddWithValue("@nsd", t_nsd.Text);
            cmd.Parameters.AddWithValue("@matkhau",pass);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
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
                        frm.query = "SELECT ma_dv as'Mã đơn vị',nsd as'NSD',quyendn as'Quyền',thoigiandn as'Thời gian ĐN gần nhất' FROM NSD";
                        frm.cbbitem.Items.Add("nsd");
                        frm.cbbitem.Items.Add("ma_dv");

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
    }
}