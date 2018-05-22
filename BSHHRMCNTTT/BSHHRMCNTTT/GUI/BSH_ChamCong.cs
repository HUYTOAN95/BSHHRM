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
using BSHHRMCNTTT.SysForm;

namespace BSHHRMCNTTT.GUI
{
    public partial class BSH_ChamCong : DevExpress.XtraEditors.XtraForm
    {   
        private DBConnection db;
        private bool AddNew = false;
        public BSH_ChamCong()
        {
            db = new DBConnection();
            InitializeComponent();
        }
        #region[LoadData]
        private void LoadData()
        {
            try
            {
                string query = string.Format("SPBSH_CHAMC_LKE");
                SqlParameter[] para = new SqlParameter[0];
                GridView.DataSource = db.LKE(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        #endregion
        #region[AddRecord]
        private void AddRecord()
        {
            try
            {
                string query = string.Format("SPBSH_CHAMC_NH");
                SqlParameter[] para = {
                new SqlParameter("@manv",txtmanv.Text),
                new SqlParameter("@sonc",txtSNC.Text),
                new SqlParameter("@sonn", txtSNN.Text),
                new SqlParameter("@StatementType", "ADD")

            };
                bool i = db.AddRecord(query, para);
                if (i == true)
                {
                    XtraMessageBox.Show("Thêm mới bản ghi thành công !");
                    LoadData();
                    ClearData();
                }
                else
                    XtraMessageBox.Show("Thêm mới bản ghi lỗi !");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        // xóa bản ghi 
        #region[DeleteRecord]
        private void DeleteRecord()
        {
            string ma = GridView.CurrentRow.Cells[0].Value.ToString().Trim();
            string bac = GridView.CurrentRow.Cells[1].Value.ToString().Trim();
            if (XtraMessageBox.Show("Bạn muốn xóa bản ghi  !", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string query = string.Format("SPBSH_CHAMC_XOA");
                    SqlParameter[] para = {
                     new SqlParameter("@ma",ma) };
                                                       

                    bool i = db.DeleteRecord(query, para);
                    if (i == true)
                    {
                        XtraMessageBox.Show("Xóa bản ghi thành công !");
                        LoadData();
                        ClearData();
                    }
                    else
                        XtraMessageBox.Show("Xóa bản ghi lỗi !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
        }
        #endregion
        #region[UpdateRecord]
        private void UpdateRecord()
        {
            string ma = GridView.CurrentRow.Cells[0].Value.ToString().Trim();
          
            try
            {
                string query = string.Format("SPBSH_CHAMC_NH");
                SqlParameter[] para = {
                new SqlParameter("@manv",ma),
                new SqlParameter("@sonc",txtSNC.Text),
                new SqlParameter("@sonn", txtSNN.Text),
                new SqlParameter("@StatementType", "EDIT")

            };
                bool i = db.AddRecord(query, para);
                if (i == true)
                {
                    XtraMessageBox.Show("Sửa đổi bản ghi thành công !");
                    LoadData();
                    ClearData();

                }
                else
                    XtraMessageBox.Show("Sửa đổi bản ghi lỗi !");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        #endregion
        private void ClearData()
        {
            txtmanv.Text = "";
            txtSNC.Text = "";
            txtSNN.Text = "";

        }

        private void BSH_ChamCong_Load(object sender, EventArgs e)
        {
            LoadData();
           
        }

        private void GridView_Click(object sender, EventArgs e)
        {
            txtmanv.Text = GridView.CurrentRow.Cells[0].Value.ToString().Trim();
            txtSNC.Text = GridView.CurrentRow.Cells[1].Value.ToString().Trim();
            txtSNN.Text = GridView.CurrentRow.Cells[2].Value.ToString().Trim();
            btnadd.Enabled = true;
            AddNew = false;
           
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddNew = true;
            ClearData();
            btnadd.Enabled = false;
           
          
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (AddNew == true)
            {
                if (txtmanv.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã nhân viên không được để trống!");
                    txtmanv.Focus();
                    return;
                }
                if (txtSNC.Text.Trim().Equals(""))
                {
                    MessageBox.Show("số ngày công không được để trống hoặc nhập giá trị {0}!");
                    txtSNC.Focus();
                    return;
                }
                if (txtSNN.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Số ngày nghỉ không được để trống hoặc nhập giá trị {0}!");
                    txtSNN.Focus();
                    return;
                }
                AddRecord();
                btnadd.Enabled = true;
                AddNew = false;
            }
            else
                UpdateRecord();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void txtmanv_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    {
                        frmlselect frm = new frmlselect();
                        frm.caption = "Danh sách nhân viên";
                        frm.query = "SELECT * FROM View_NhanVien_Select";
                        frm.cbbitem.Items.Add("Mã nhân viên");
                        frm.cbbitem.Items.Add("Tên nhân viên");

                        using (frm)
                        {
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                txtmanv.Text = frm.Selected;
                                txtmanv.SelectionStart = txtmanv.Text.Length;

                            }
                        }
                    }
                    break;
            }
        }
    }
}