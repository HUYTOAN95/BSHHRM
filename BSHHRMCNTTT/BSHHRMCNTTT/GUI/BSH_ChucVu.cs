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
    public partial class BSH_ChucVu : DevExpress.XtraEditors.XtraForm
    {
        private DBConnection db;
        public BSH_ChucVu()
        {
            db = new DBConnection();
            InitializeComponent();
        }

        private void grbinfo_Enter(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        // Xử lý đổ dữ liệu ra bảng  
        #region[LoadData]
        private void LoadData()
        {
            try
            {
                string query = string.Format("SPBSH_CVU_LKE");
                SqlParameter[] para = new SqlParameter[0];
                GridView.DataSource = db.LKE(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        #endregion
        private void ClearData()
        {
            txtma.Text = "";
            txtten.Text = "";
        }
        // Xử lý thêm bản ghi vào bảng 
        #region
        private void AddRecord()
        {
            try
            {
                string query = string.Format("SPBSH_CVU_NH");
                SqlParameter[] para = {
                new SqlParameter("@macv",txtma.Text),
                new SqlParameter("@tencv", txtten.Text),
                
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
            if (XtraMessageBox.Show("Bạn muốn xóa bản ghi  !", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string query = string.Format("SPBSH_CVU_XOA");
                    SqlParameter[] para = {
                    new SqlParameter("@macv",ma),

                };

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
                    throw ex;
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
                string query = string.Format("SPBSH_CVU_NH");
                SqlParameter[] para = {
                new SqlParameter("@macv",ma),
                new SqlParameter("@tencv", txtten.Text),
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
                throw ex;
            }
        }

        #endregion

        private void BSH_ChucVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtma.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã không được để trống!");
                txtten.Focus();
                return;
            }
            if (txtten.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên không được để trống!");
                txtten.Focus();
                return;
            }
            AddRecord();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            UpdateRecord();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void GridView_Click(object sender, EventArgs e)
        {
            txtma.Text = GridView.CurrentRow.Cells[0].Value.ToString().Trim();
            txtten.Text = GridView.CurrentRow.Cells[1].Value.ToString().Trim();
        }
    }
}