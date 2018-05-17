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

namespace BSHHRMCNTTT.GUI
{
    public partial class BSH_BacLuong : DevExpress.XtraEditors.XtraForm
    {
        private bool AddNew = false;
        private DBConnection db;
        public BSH_BacLuong()
        {
            db = new DBConnection();
            InitializeComponent();
        }
        //load dữ liệu
        #region[LoadData]
        private void LoadData()
        {
            try
            {
                string query = string.Format("SPBSH_BLU_LKE");
                SqlParameter[] para = new SqlParameter[0];
                GridView.DataSource = db.LKE(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        #endregion
        // Xử lý thêm bản ghi vào bảng 
        #region[AddRecord]
        private void AddRecord()
        {
            try
            {
                string query = string.Format("SPBSH_BLU_NH");
                SqlParameter[] para = {
                new SqlParameter("@ma",txtma.Text),
                new SqlParameter("@bac",txtbac.Text),
                new SqlParameter("@hsl", txthsl.Text),
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
                    string query = string.Format("SPBSH_BLU_XOA");
                    SqlParameter[] para = {
                     new SqlParameter("@ma",ma),
                     new SqlParameter("@bac",bac)

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
                    MessageBox.Show("Error" + ex);
                }
            }
        }
        #endregion
        #region[UpdateRecord]
        private void UpdateRecord()
        {
            string ma = GridView.CurrentRow.Cells[0].Value.ToString().Trim();
            string bac = GridView.CurrentRow.Cells[1].Value.ToString().Trim();
            try
            {
                string query = string.Format("SPBSH_BLU_NH");
                SqlParameter[] para = {
                new SqlParameter("@ma",ma),
                new SqlParameter("@bac",bac),
                new SqlParameter("@hsl", txthsl.Text),
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
            txtbac.Text = "";
            txtma.Text = "";
            txthsl.Text = "";

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
                if (txtma.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã không được để trống!");
                    txtma.Focus();
                    return;
                }
                if (txtbac.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Bậc không được để trống!");
                    txtbac.Focus();
                    return;
                }
                if (txthsl.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Hệ số lương không được để trống!");
                    txthsl.Focus();
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

        private void BSH_BacLuong_KeyDown(object sender, KeyEventArgs e)
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

        private void BSH_BacLuong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void GridView_Click(object sender, EventArgs e)
        {
            txtma.Text = GridView.CurrentRow.Cells[0].Value.ToString().Trim();
            txtbac.Text = GridView.CurrentRow.Cells[1].Value.ToString().Trim();
            txthsl.Text = GridView.CurrentRow.Cells[2].Value.ToString().Trim();
            btnadd.Enabled = true;
            AddNew = false;
        }
        public string Selected2 { get { return GridView.CurrentRow.Cells[2].Value.ToString(); } }
        //public string Selected1 { get { return GridView.CurrentRow.Cells[1].Value.ToString(); } }

    }
}