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
using BSHHRMCNTTT.BUS;
using BSHHRMCNTTT.VO;

namespace BSHHRMCNTTT.SysForm
{
    public partial class BSH_NSD : DevExpress.XtraEditors.XtraForm
    {
        public BSH_NSD()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            gridview.DataSource = NSDBUS.NSD_LKE();
            d_ngayhh.Text = DateTime.Now.AddYears(3).ToString();
            
        }

        private void gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (t_madv.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Mã đơn vị không được để trống!");
                t_madv.Focus();
                return;
            }
            if (t_nsd.Text.Trim().Equals(""))
            {
                MessageBox.Show(" NSD không để trống!");
                t_nsd.Focus();
                return;
            }
            if (t_manv.Text.Trim().Equals(""))
            {
                MessageBox.Show(" Mã nhân viên không để trống!");
                t_manv.Focus();
                return;
            }
            NSDInfo obj = new NSDInfo();
            obj.b_madv = t_madv.Text;
            obj.b_nsd = t_nsd.Text;
            obj.b_matkhau = t_matkhau.Text;
            obj.b_manv = t_manv.Text;
            obj.b_ngaydk = DateTime.Parse(d_ngaydk.Text);
            obj.b_ngayhh = DateTime.Parse(d_ngayhh.Text);
            obj.b_quyendn = c_quyen.Text;
            obj.b_email = t_email.Text;
            try
            {
                NSDBUS.NSD_NH(obj);
                XtraMessageBox.Show("Thêm người dụng mới thành công");
                LoadData();
               
            }
            catch
            {
                MessageBox.Show(" Xảy ra sự cố !");
              
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string madv = gridview.CurrentRow.Cells[0].Value.ToString();
            string nsd = gridview.CurrentRow.Cells[1].Value.ToString();
            NSDInfo obj = new NSDInfo();
            obj.b_madv = madv;
            obj.b_nsd = nsd;
            obj.b_matkhau = t_matkhau.Text;
            obj.b_manv = t_manv.Text;
            obj.b_ngaydk = DateTime.Parse(d_ngaydk.Text);
            obj.b_ngayhh = DateTime.Parse(d_ngayhh.Text);
            obj.b_quyendn = c_quyen.Text;
            obj.b_email = t_email.Text;
            try
            {
                NSDBUS.NSD_SUA(obj);
                XtraMessageBox.Show("Cập nhật người sử dụng thành công");
                LoadData();
            }
            catch
            {
                XtraMessageBox.Show("Lỗi cập nhật người sử dụng ");
            }

        }

        private void gridview_Click(object sender, EventArgs e)
        {
            t_madv.Text = gridview.CurrentRow.Cells[0].Value.ToString();
            t_nsd.Text = gridview.CurrentRow.Cells[1].Value.ToString();
            t_matkhau.Text = gridview.CurrentRow.Cells[2].Value.ToString();
            t_manv.Text = gridview.CurrentRow.Cells[3].Value.ToString();
            d_ngaydk.Text = gridview.CurrentRow.Cells[4].Value.ToString();
            d_ngayhh.Text= gridview.CurrentRow.Cells[5].Value.ToString();
            c_quyen.Text= gridview.CurrentRow.Cells[7].Value.ToString();
            t_email.Text= gridview.CurrentRow.Cells[8].Value.ToString();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string madv = gridview.CurrentRow.Cells[0].Value.ToString();
            string nsd = gridview.CurrentRow.Cells[1].Value.ToString();
            NSDInfo obj = new NSDInfo();
            obj.b_madv = madv;
            obj.b_nsd = nsd;
            //try
            //{
                NSDBUS.NSD_XOA(obj);
                XtraMessageBox.Show("Xóa người sử dụng thành công");
                LoadData();
            //}
            //catch
            //{
            //    XtraMessageBox.Show("Lỗi xóa người sử dụng !");
            //}
        }

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
                              
                            }
                        }
                    }
                    break;
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if(t_madv.Text != "")
            {
              
                NSDBUS.NSD_LKE_ID("ma_dv",t_madv.Text);
                

            }
            else if(t_nsd.Text !="")
            {
                NSDBUS.NSD_LKE_ID("nsd", t_nsd.Text);
            }
            LoadData();
        }
    }
}