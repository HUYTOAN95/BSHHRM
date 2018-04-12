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
using System.IO;
using BSHHRMCNTTT.SysForm;

namespace BSHHRMCNTTT.SysForm
{
    public partial class frmConnectDB : DevExpress.XtraEditors.XtraForm
    {
        Timer time = new Timer();
        Boolean show_date = false;
        public frmConnectDB()
        {
            InitializeComponent();
        }

        private void b_disconnect_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn thoát khỏi hệ thống (Yes/ No)?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                DBConnection.CloseConnection();
            Application.Exit();
        }

        private void b_connect_Click(object sender, EventArgs e)
        {
            if (t_server.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show(" Tên Server không được để trống!");
                t_server.Focus();
                return;
            }
            if (t_dbname.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show(" Tên Database không được để trống!");
                t_dbname.Focus();
                return;
            }
            DBConnection.InforConnect(t_server.Text, t_dbname.Text, t_userlogin.Text, t_password.Text);
            try
            {
                DBConnection.OpenConnection();
                XtraMessageBox.Show("Kết nối thành công!");
                FileInfo myfile = new FileInfo("Config.txt");
                StreamWriter tex = myfile.CreateText();
                tex.WriteLine("Data Source=" + t_server.Text + ";Initial Catalog=" + t_dbname.Text + ";User ID=" + t_userlogin.Text + ";Password=" + t_password.Text + ";Integrated Security=True");
                tex.Close();
                this.Hide();
                frmlogin frm = new frmlogin();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Kết nối thất bại!"+ex.Message);
            }
        }

        private void frmConnectDB_Load(object sender, EventArgs e)
        {
            time.Interval = 1000;  //in milliseconds

            time.Tick += new EventHandler(this.timerstart_Tick);

            time.Start();  //this will use t_Tick() method
            if (BSHHRMCNTTT.Properties.Settings.Default.servername != string.Empty)
            {
                t_server.Text = BSHHRMCNTTT.Properties.Settings.Default.servername;
                t_dbname.Text = BSHHRMCNTTT.Properties.Settings.Default.dbname;
                t_userlogin.Text = BSHHRMCNTTT.Properties.Settings.Default.userlogin;
                t_password.Text = BSHHRMCNTTT.Properties.Settings.Default.password;
               
            }
        }

        private void checkrememberpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkrememberpass.Checked)
            {
                BSHHRMCNTTT.Properties.Settings.Default.servername = t_server.Text;
                BSHHRMCNTTT.Properties.Settings.Default.dbname = t_dbname.Text;
                BSHHRMCNTTT.Properties.Settings.Default.userlogin = t_userlogin.Text;
                BSHHRMCNTTT.Properties.Settings.Default.password = t_password.Text;
              
                BSHHRMCNTTT.Properties.Settings.Default.Save();
            }
        }

        private void timerstart_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";
            int am_pm = 0;
            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                if (hh > 12)
                {
                    am_pm = 1;
                    hh -= 12;
                }
                if (hh < 10)
                {
                    time += "0";
                }
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            if (am_pm == 0)
            {
                time += " AM ";
            }
            else
            {
                time += " PM ";
            }
            //update label
            ltime.Text = time;
            if (!show_date)
            {
                ldate.Text = DateTime.Today.ToString("dd/MM/yyyy");
                show_date = true;
            }
        }

        private void t_server_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}