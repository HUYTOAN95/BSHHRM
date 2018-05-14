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
    public partial class BSH_TrinhDo : DevExpress.XtraEditors.XtraForm
    {
        private DBConnection db;
        public BSH_TrinhDo()
        {
            db = new DBConnection();
            InitializeComponent();
        }
        // Xử lý đổ dữ liệu ra bảng  
        #region[LoadData]
        private void LoadData()
        {
            try
            {
                string query = string.Format("SPBSH_TDO_LKE");
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
            txttrinhdo.Text = "";
            txtchuyennganh.Text = "";
        }
        // Xử lý thêm bản ghi vào bảng 
        #region
        private void AddRecord()
        {
            try
            {
                string query = string.Format("SPBSH_TDO_NH");
                SqlParameter[] para = {
                new SqlParameter("@matd",DBNull.Value),
                new SqlParameter("@tentd", txttrinhdo.Text),
                new SqlParameter("@tencn", txtchuyennganh.Text),
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
            if (XtraMessageBox.Show("Bạn muốn xóa bản ghi có mã : "+ma+" !", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string query = string.Format("SPBSH_TDO_XOA");
                    SqlParameter[] para = {
                    new SqlParameter("@matd",ma),

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
                string query = string.Format("SPBSH_TDO_NH");
                SqlParameter[] para = {
                new SqlParameter("@matd",ma),
                new SqlParameter("@tentd", txttrinhdo.Text),
                new SqlParameter("@tencn", txtchuyennganh.Text),
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txttrinhdo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Trình Độ không được để trống!");
                txttrinhdo.Focus();
                return;
            }
            if (txtchuyennganh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chuyên Ngành không được để trống!");
                txtchuyennganh.Focus();
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
            txttrinhdo.Text = GridView.CurrentRow.Cells[1].Value.ToString().Trim();
            txtchuyennganh.Text = GridView.CurrentRow.Cells[2].Value.ToString().Trim();
        }

        private void BSH_TrinhDo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txttrinhdo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    ClearData();
                    break;
            }
        }
        public string Selected { get { return GridView.CurrentRow.Cells[0].Value.ToString(); } }
        public string Selected1{ get { return GridView.CurrentRow.Cells[1].Value.ToString(); } }
        public string Selected2 { get { return GridView.CurrentRow.Cells[2].Value.ToString(); } }

        private void BSH_TrinhDo_KeyDown(object sender, KeyEventArgs e)
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
    }
}