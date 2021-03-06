﻿using System;
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
    public partial class BSH_PBAN : DevExpress.XtraEditors.XtraForm
    {
        private bool AddNew = false;
        private DBConnection db;
        public BSH_PBAN()
        {
            db = new DBConnection();
            InitializeComponent();
        }

        private void BSH_PBAN_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        // Xử lý đổ dữ liệu ra bảng  
        #region[LoadData]
        private void LoadData()
        {
            try
            {
                string query = string.Format("SPBSH_PBAN_LKE");
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
        #region
        private void AddRecord()
        {
            try
            {
                string query = string.Format("SPBSH_PBAN_NH");
                SqlParameter[] para = {
                new SqlParameter("@mapb",DBNull.Value),
                new SqlParameter("@tenpb", txtten.Text),
                new SqlParameter("@ghichu", txtghichu.Text),
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
                    string query = string.Format("SPBSH_PBAN_XOA");
                    SqlParameter[] para = {
                     new SqlParameter("@mapb",ma)
                  

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
                    MessageBox.Show( "Error"+ex);
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
                string query = string.Format("SPBSH_PBAN_NH");
                SqlParameter[] para = {
                new SqlParameter("@mapb",ma),
                new SqlParameter("@tenpb", txtten.Text),
                new SqlParameter("@ghichu", txtghichu.Text),
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
            txtghichu.Text = "";
            txtten.Text = "";
        }
        
        
        private void btnthem_Click(object sender, EventArgs e)
        {
            AddNew = true;
            ClearData();
            btnthem.Enabled = false;

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (AddNew == true)
            {
               
                if (txtten.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên không được để trống!");
                    txtten.Focus();
                    return;
                }
                AddRecord();
                btnthem.Enabled = true;
                AddNew = false;
            }
            else
                UpdateRecord();
        }

        private void GridView_Click(object sender, EventArgs e)
        {
            txtten.Text = GridView.CurrentRow.Cells[1].Value.ToString().Trim();
            txtghichu.Text = GridView.CurrentRow.Cells[2].Value.ToString().Trim();
            btnthem.Enabled = true;
            AddNew = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            BSH_Report frm = new BSH_Report("PhongBan.rpt", "SELECT * FROM PhongBan");
            frm.ShowDialog();
        }
        // lựa chon dư liệu theo dòng 
        public string Selected { get { return GridView.CurrentRow.Cells[0].Value.ToString(); } }
        public string Selected2 { get { return GridView.CurrentRow.Cells[1].Value.ToString(); } }
        private void BSH_PBAN_KeyDown(object sender, KeyEventArgs e)
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