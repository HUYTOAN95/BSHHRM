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
    public partial class BSH_DanToc : DevExpress.XtraEditors.XtraForm
    {
        private bool AddNew = false;
        private DBConnection db;
        public BSH_DanToc()
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
                string query = string.Format("SPBSH_DTOC_LKE");
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
                string query = string.Format("SPBSH_DTOC_NH");
                SqlParameter[] para = {
                new SqlParameter("@ma",DBNull.Value),
                new SqlParameter("@ten", txtdantoc.Text),
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
                    string query = string.Format("SPBSH_DTOC_XOA");
                    SqlParameter[] para = {
                     new SqlParameter("@ma",ma),

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

            try
            {
                string query = string.Format("SPBSH_DTOC_NH");
                SqlParameter[] para = {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten", txtdantoc.Text),

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
            txtdantoc.Text = "";

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
                if (txtdantoc.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên không được để trống!");
                    txtdantoc.Focus();
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

        private void BSH_DanToc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void GridView_Click(object sender, EventArgs e)
        {
            txtdantoc.Text = GridView.CurrentRow.Cells[1].Value.ToString().Trim();
            btnadd.Enabled = true;
            AddNew = false;
        }
        public string Selected { get { return GridView.CurrentRow.Cells[0].Value.ToString(); } }
        public string Selected2 { get { return GridView.CurrentRow.Cells[1].Value.ToString(); } }

        private void BSH_DanToc_KeyDown(object sender, KeyEventArgs e)
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