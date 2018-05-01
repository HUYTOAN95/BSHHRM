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
using System.Net.Mail;
using System.Net;


namespace BSHHRMCNTTT.SysForm
{
    public partial class BSH_QUENMK : DevExpress.XtraEditors.XtraForm
    {
        public BSH_QUENMK()
        {
            InitializeComponent();
        }

        private void b_accept_Click(object sender, EventArgs e)
        {
            if (t_email.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show(" Email không được để trống!");
                t_email.Focus();
                return;
            }
            else if (t_madv.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show(" Mã đơn vị không được để trống!");
                t_madv.Focus();
                return;
            }
            grbinfo.Visible = false;
            grbkey.Visible = true;
           if (grbkey.Visible == false)
               SendEmail();
           else if (grbkey.Visible ==true)
           {
                UpdateAccount();
           }
             
        }
        private void UpdateAccount()
        {   
            
        }

        private void frmforgetpassword_Load(object sender, EventArgs e)
        {
            grbkey.Visible = false;
          
        }
        //Bắt phim sự kiện keydown
        #region[ KeyDown]
        private void t_madv_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    {
                        frmlselect frm = new frmlselect();
                        frm.caption = "Danh sách NSD";
                        frm.query = "SELECT * FROM View_bsh_nsd";
                        frm.cbbitem.Items.Add("Người Sử Dụng");
                        frm.cbbitem.Items.Add("Mã Đơn Vị");

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
        #endregion
        // send keycode to email client 
        #region [Send Email]
        public void SendEmail()
        {
           
            
            //try
            //{
            //    string KeyCode;
            //    KeyCode = NSDBUS.NSD_LKE_ID(t_madv.Text, t_nsd.Text);

            //    var fromAddress = new MailAddress("nguyenhuytoan113@gmail.com");
            //    var fromPassword = "toankim1995";
            //    var toAddress = new MailAddress(t_email.Text);

            //    string subject = "Key lấy lại mật khẩu chỉ được cấp 1 lần ";
            //    string body = KeyCode;

            //    System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
            //    {
            //        Host = "smtp.gmail.com",
            //        Port = 587,
            //        EnableSsl = true,
            //        DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
            //        UseDefaultCredentials = false,
            //        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

            //    };

            //    using (var message = new MailMessage(fromAddress, toAddress)
            //    {
            //        Subject = subject,
            //        Body = body
            //    })


            //        smtp.Send(message);
            //}
            //catch(Exception ex)
            //{
            //    XtraMessageBox.Show("Error" + ex);
            //}
        }
        #endregion
    }
}