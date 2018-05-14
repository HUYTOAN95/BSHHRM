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


namespace BSHHRMCNTTT.SysForm
{
    public partial class BSH_NSD : DevExpress.XtraEditors.XtraForm
    { private DBConnection db;
        public BSH_NSD()
        {   db = new DBConnection();
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        // Xử lý đổ dữ liệu ra bảng  
        #region[LoadData]
        private void LoadData()
        {
            try
            {
                string query = string.Format("SPBSH_NSD_LKE");
                SqlParameter[] para = new SqlParameter [0];
                gridview.DataSource = db.LKE(query);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            d_ngayhh.Text = DateTime.Now.AddYears(3).ToString();
            
        }
        #endregion
        // Xử lý thêm bản ghi vào bảng 
        #region[AddRecord]
       private void AddRecord()
        {
            string pass = MD5Encrypt.Encrypt(t_matkhau.Text);
            try
            {
                string query = string.Format("SPBSH_NSD_NH");
                SqlParameter[] para = {
                new SqlParameter("@madv",t_madv.Text),
                new SqlParameter("@nsd", t_nsd.Text),
                new SqlParameter("@matkhau", pass),
                new SqlParameter("@manv", t_manv.Text),
                new SqlParameter("@ngaydk", d_ngaydk.Text),
                new SqlParameter("@ngayhh", d_ngayhh.Text),
                new SqlParameter("@quyendn",c_quyen.Text),
                new SqlParameter("@email", t_email.Text),
                new SqlParameter("@StatementType", "ADD")

            };
                bool i = db.AddRecord(query, para);
                if (i == true)
                {
                    XtraMessageBox.Show("Thêm mới bản ghi thành công !");
                    LoadData();
                }
                else
                    XtraMessageBox.Show("Thêm mới bản ghi lỗi !");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        // xóa bản ghi 
        #region[DeleteRecord]
        private void DeleteRecord()
        {
            string madv = gridview.CurrentRow.Cells[0].Value.ToString().Trim();
            string nsd = gridview.CurrentRow.Cells[1].Value.ToString().Trim();
            if (XtraMessageBox.Show("Bạn muốn xóa bản ghi  !", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string query = string.Format("SPBSH_NSD_XOA");
                    SqlParameter[] para = {
                new SqlParameter("@madv",madv),
                new SqlParameter("@nsd",nsd),
                };

                    bool i = db.DeleteRecord(query, para);
                    if (i == true)
                    {
                        XtraMessageBox.Show("Xóa bản ghi thành công !");
                        LoadData();
                    }
                    else
                        XtraMessageBox.Show("Xóa bản ghi lỗi !");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        #endregion
        #region[UpdateRecord]
        private void UpdateRecord()
        {
            string pass = MD5Encrypt.Encrypt(t_matkhau.Text);
            string madv = gridview.CurrentRow.Cells[0].Value.ToString().Trim();
            string nsd = gridview.CurrentRow.Cells[1].Value.ToString().Trim();
            try
            {
                string query = string.Format("SPBSH_NSD_NH");
                SqlParameter[] para = {
                new SqlParameter("@madv",madv),
                new SqlParameter("@nsd", nsd),
                new SqlParameter("@matkhau",pass),
                new SqlParameter("@manv", t_manv.Text),
                new SqlParameter("@ngaydk", d_ngaydk.Text),
                new SqlParameter("@ngayhh", d_ngayhh.Text),
                new SqlParameter("@quyendn",c_quyen.Text),
                new SqlParameter("@email", t_email.Text),
                new SqlParameter("@StatementType", "EDIT")

            };
                bool i = db.AddRecord(query, para);
                if (i == true)
                {
                    XtraMessageBox.Show("Sửa đổi bản ghi thành công !");
                    LoadData();
                }
                else
                    XtraMessageBox.Show("Sửa đổi bản ghi lỗi !");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
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
            AddRecord();
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            UpdateRecord();


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
            DeleteRecord();
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
           
        }

        private void grbcontrol_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}