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
    public partial class BSH_NhanVien : DevExpress.XtraEditors.XtraForm
    {
        private bool AddNew = false;
        private DBConnection db;
        private SqlDataReader dr;
        public BSH_NhanVien()
        {
            db = new DBConnection();
            InitializeComponent();
        }

        private void separatorControl1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BSH_NhanVien_Load(object sender, EventArgs e)
        {
            btnedit.Enabled = false;
        }

        private void txtmacv_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    using (BSH_ChucVu frm = new BSH_ChucVu())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txtmacv.Text = frm.Selected;
                            txtmacv.SelectionStart = txtmacv.Text.Length;
                            txttencv.Text = frm.Selected2;
                            txttencv.SelectionStart = txttencv.Text.Length;

                        }
                    }
                    break;
            }
        }

        private void txtmapb_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    using (BSH_PBAN frm = new BSH_PBAN())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txtmapb.Text = frm.Selected;
                            txtmapb.SelectionStart = txtmapb.Text.Length;
                            txttenpb.Text = frm.Selected2;
                            txttenpb.SelectionStart = txttenpb.Text.Length;

                        }
                    }
                    break;
            }

        }

        private void txttongiao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    using (BSH_TonGiao frm = new BSH_TonGiao())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txttongiao.Text = frm.Selected;
                            txttongiao.SelectionStart = txttongiao.Text.Length;

                        }
                    }
                    break;
            }
        }

        private void txtdantoc_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    using (BSH_DanToc frm = new BSH_DanToc())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txtdantoc.Text = frm.Selected;
                            txtdantoc.SelectionStart = txtdantoc.Text.Length;

                        }
                    }
                    break;
            }
        }

        private void txttentd_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtmatd_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtmatd_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    using (BSH_TrinhDo frm = new BSH_TrinhDo())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txtmatd.Text = frm.Selected;
                            txtmatd.SelectionStart = txtmatd.Text.Length;
                            txttentd.Text = frm.Selected1;
                            txttentd.SelectionStart = txttentd.Text.Length;
                            txtchuyenmon.Text = frm.Selected2;
                            txtchuyenmon.SelectionStart = txtchuyenmon.Text.Length;

                        }
                    }
                    break;
            }
        }

        private void txtmacd_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    using (BSH_CheDo frm = new BSH_CheDo())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txtmacd.Text = frm.Selected;
                            txtmacd.SelectionStart = txtmacd.Text.Length;
                            txttencd.Text = frm.Selected1;
                            txttencd.SelectionStart = txttencd.Text.Length;


                        }
                    }
                    break;
            }
        }

        private void textEdit15_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    using (BSH_BacLuong frm = new BSH_BacLuong())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txthsl.Text = frm.Selected2;
                            txthsl.SelectionStart = txthsl.Text.Length;

                        }
                    }
                    break;
            }
        }

        private void txtkyluat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    using (BSH_KyLuat frm = new BSH_KyLuat())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txtkyluat.Text = frm.Selected;
                            txtkyluat.SelectionStart = txtkyluat.Text.Length;
                            txttenkl.Text = frm.Selected1;
                            txttenkl.SelectionStart = txttenkl.Text.Length;

                        }
                    }
                    break;
            }
        }

        private void txtkhen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    using (BSH_KhenThuong frm = new BSH_KhenThuong())
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            txtkhen.Text = frm.Selected;
                            txtkhen.SelectionStart = txtkhen.Text.Length;
                            txttenkhen.Text = frm.Selected1;
                            txttenkhen.SelectionStart = txttenkhen.Text.Length;

                        }
                    }
                    break;
            }
        }

        private void txtsohd_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    try
                    {
                        string query = string.Format("SPBSH_AUTO_IDHD");
                        SqlParameter[] para = new SqlParameter[0];
                        txtsohd.Text = db.STR_LKE(query);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    break;
            }
        }

        private void cbbloaihd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbloaihd.SelectedItem.ToString().Trim() == "1 Năm")
                ngaykt.Text = DateTime.Now.AddYears(1).ToString();
            else if (cbbloaihd.SelectedItem.ToString().Trim() == "2 Năm")
                ngaykt.Text = DateTime.Now.AddYears(2).ToString();
            else if (cbbloaihd.SelectedItem.ToString().Trim() == "3 Năm")
                ngaykt.Text = DateTime.Now.AddYears(3).ToString();
            else if (cbbloaihd.SelectedItem.ToString().Trim() == "Không thời hạn")
                ngaykt.Text= ngaykt.MaxDate.ToShortDateString();
        }

        //private void txtmanv_KeyDown(object sender, KeyEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.F1:
        //            try
        //            {
        //                string query = string.Format("SPBSH_AUTO_IDNV");
        //                SqlParameter[] para = new SqlParameter[0];
        //                cbbmanv.Text = db.STR_LKE(query);
        //            }
        //            catch (Exception ex)
        //            {
        //                throw ex;
        //            }
        //            break;
        //    }
        //}

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddNew = true;
            //ClearData();
            btnadd.Enabled = false;
            btnedit.Enabled = true;
        }
        #region[AddRecord]
        private void AddRecord()
        {
            try
            {
                DateTime v_ngaysinh = DateTime.Parse(ngaysinh.Text);
            DateTime v_ngaybd = DateTime.Parse(ngaybd.Text);
            DateTime v_ngaykt = DateTime.Parse(ngaykt.Text);
            DateTime v_ngaycap = DateTime.Parse(ngaycap.Text);
            DateTime v_ngayvaolam = DateTime.Parse(ngayvaolam.Text);
            Decimal v_hsl = Decimal.Parse(txthsl.Text);
            string query = string.Format("SPBSH_NVIEN_NH");
            SqlParameter[] para = {
                new SqlParameter("@manv",cbbmanv.Text),
                new SqlParameter("@tennv",txttennv.Text),
                new SqlParameter("@gioitinh", cbbgioitinh.Text),
                new SqlParameter("@ngaysinh",v_ngaysinh) /*{Value=ngaysinh.Text }*/,
                new SqlParameter("@noisinh",txtnoisinh.Text),
                new SqlParameter("@diachi",txtdiachi.Text),
                new SqlParameter("@matg",txttongiao.Text),
                new SqlParameter("@madt",txtdantoc.Text),
                new SqlParameter("@tthn",cbbtinhtranghn.Text),
                new SqlParameter("@socmnd",socmnd.Text),
                new SqlParameter("@ngaycap",v_ngaycap) /*{ Value=ngaycap.Text}*/,
                new SqlParameter("@noicap",noicap.Text),
                new SqlParameter("@sdt",txtsdt.Text),
                new SqlParameter("@ngayvaolam",v_ngayvaolam),
                new SqlParameter("@email",txtemail.Text),
                new SqlParameter("@chucvu",txtmacv.Text),
                new SqlParameter("@phongban",txtmapb.Text),
                new SqlParameter("@trinhdo",txtmatd.Text),
                new SqlParameter("@ngoaingu",txtngoaingu.Text),
                new SqlParameter("@chedo",txtmacd.Text),
                new SqlParameter("@hsl",v_hsl),
                new SqlParameter("@makt",txtkhen.Text),
                new SqlParameter("@makl",txtkyluat.Text),
                new SqlParameter("@sohd",txtsohd.Text),
                new SqlParameter("@loaihd",cbbloaihd.Text),
                new SqlParameter("@ngaybd",v_ngaybd),
                new SqlParameter("@ngaykt",v_ngaykt),
                new SqlParameter("@StatementType", "ADD")

            };
            bool i = db.AddRecord(query, para);
            if (i == true)
            {
                XtraMessageBox.Show("Thêm mới bản ghi thành công !");
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
        //xóa bản ghi
        #region[DeleteRecord]
        private void DeleteRecord()
        {
           
            if (XtraMessageBox.Show("Bạn muốn xóa bản ghi  !", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string query = string.Format("SPBSH_NVIEN_XOA");
                    SqlParameter[] para = {
                     new SqlParameter("@manv",cbbmanv.Text)
                                  };

                    bool i = db.DeleteRecord(query, para);
                    if (i == true)
                    {
                        XtraMessageBox.Show("Xóa bản ghi thành công !");
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
        private void UpdateRecord()
        {
            try
            {
            DateTime v_ngaysinh = DateTime.Parse(ngaysinh.Text);
            DateTime v_ngaybd = DateTime.Parse(ngaybd.Text);
            DateTime v_ngaykt = DateTime.Parse(ngaykt.Text);
            DateTime v_ngaycap = DateTime.Parse(ngaycap.Text);
            DateTime v_ngayvaolam = DateTime.Parse(ngayvaolam.Text);
            Decimal v_hsl = Decimal.Parse(txthsl.Text);
            string query = string.Format("SPBSH_NVIEN_NH");
            SqlParameter[] para = {
                new SqlParameter("@manv",cbbmanv.Text),
                new SqlParameter("@tennv",txttennv.Text),
                new SqlParameter("@gioitinh", cbbgioitinh.Text),
                new SqlParameter("@ngaysinh",v_ngaysinh) /*{Value=ngaysinh.Text }*/,
                new SqlParameter("@noisinh",txtnoisinh.Text),
                new SqlParameter("@diachi",txtdiachi.Text),
                new SqlParameter("@matg",txttongiao.Text),
                new SqlParameter("@madt",txtdantoc.Text),
                new SqlParameter("@tthn",cbbtinhtranghn.Text),
                new SqlParameter("@socmnd",socmnd.Text),
                new SqlParameter("@ngaycap",v_ngaycap) /*{ Value=ngaycap.Text}*/,
                new SqlParameter("@noicap",noicap.Text),
                new SqlParameter("@sdt",txtsdt.Text),
                new SqlParameter("@ngayvaolam",v_ngayvaolam),
                new SqlParameter("@email",txtemail.Text),
                new SqlParameter("@chucvu",txtmacv.Text),
                new SqlParameter("@phongban",txtmapb.Text),
                new SqlParameter("@trinhdo",txtmatd.Text),
                new SqlParameter("@ngoaingu",txtngoaingu.Text),
                new SqlParameter("@chedo",txtmacd.Text),
                new SqlParameter("@hsl",v_hsl),
                new SqlParameter("@makt",txtkhen.Text),
                new SqlParameter("@makl",txtkyluat.Text),
                new SqlParameter("@sohd",txtsohd.Text),
                new SqlParameter("@loaihd",cbbloaihd.Text),
                new SqlParameter("@ngaybd",v_ngaybd),
                new SqlParameter("@ngaykt",v_ngaykt),
                new SqlParameter("@StatementType", "EDIT")

            };
            bool i = db.UpdateRecord(query, para);
            if (i == true)
            {
                XtraMessageBox.Show("Cập nhật bản ghi thành công !");
                ClearData();
            }
            else
                XtraMessageBox.Show("Cập nhật bản ghi lỗi !");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void ClearData()
        {
            cbbmanv.Text = ""; txttennv.Text = ""; cbbgioitinh.Text = ""; txtngoaingu.Text = ""; txtsohd.Text = ""; txttenkhen.Text = ""; txttencv.Text = "";
            txttenkl.Text = ""; txttenpb.Text = ""; txttongiao.Text = ""; txtdantoc.Text = ""; txtchuyenmon.Text = ""; txtkhen.Text = ""; txtkyluat.Text = "";
            cbbloaihd.Text = ""; socmnd.Text = ""; noicap.Text = ""; ngaycap.Text = ""; cbbtinhtranghn.Text = ""; txtnoisinh.Text = ""; txtdiachi.Text = ""; ngaysinh.Text = ""; txtsdt.Text = "";
            txtmacv.Text = ""; txtmapb.Text = ""; txtmatd.Text = ""; txtmacd.Text = ""; txthsl.Text = ""; txtemail.Text = ""; txttentd.Text = ""; txttencd.Text = "";
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (AddNew == true)
            {
                if (cbbmanv.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã nhân viên không được để trống!");
                    cbbmanv.Focus();
                    return;
                }
                if (txttennv.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên nhân viên không được để trống!");
                    txttennv.Focus();
                    return;
                }
                if (ngaysinh.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Ngày sinh không được để trống!");
                    ngaysinh.Focus();
                    return;

                }

                if (txtsohd.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Số hợp đồng không được để trống!");
                    txtsohd.Focus();
                    return;
                }
                if (ngaycap.Text.Trim().Equals(""))
                {
                    ngaycap.Text = "01/01/1753";

                }
                if (ngaysinh.Text.Trim().Equals(""))
                {
                    ngaysinh.Text = "01/01/1753";

                }
                if (txthsl.Text.Trim().Equals(""))
                {
                    txthsl.Text = "0.0";

                }
                AddRecord();
                btnadd.Enabled = true;
                AddNew = false;
                btnedit.Enabled = false;
            }
            else
                UpdateRecord();
        }



        private void cbbmanv_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void cbbmanv_KeyDown_1(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.F1:
                    try
                    {
                        string query = string.Format("SPBSH_AUTO_IDNV");
                        SqlParameter[] para = new SqlParameter[0];
                        cbbmanv.Text = db.STR_LKE(query);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    break;
            }
        }

        private void cbbmanv_DropDown(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("SPBSH_NVIEN_LKE_ID");
                SqlParameter[] para = new SqlParameter[0];
                cbbmanv.DataSource = db.LKE(query);
                cbbmanv.DisplayMember = "MaNV";
                cbbmanv.ValueMember = "MaNV";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LoadData()
        {
            try
            {
                string query = string.Format("SPBSH_NHANVIEN_LKE");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SO.DBConnection.OpenConnection();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@manv",cbbmanv.Text);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txttennv.Text = dr[1].ToString();
                    cbbgioitinh.Text = dr[2].ToString();
                    string vngaysinh = dr[3].ToString();
                    ngaysinh.Text = vngaysinh.Substring(0,10);
                    txtnoisinh.Text = dr[4].ToString();
                    txtdiachi.Text = dr[5].ToString();
                    txttongiao.Text = dr[6].ToString();
                    txtdantoc.Text = dr[7].ToString();
                    cbbtinhtranghn.Text = dr[8].ToString();
                    socmnd.Text = dr[9].ToString();
                    noicap.Text = dr[10].ToString();
                    ngaycap.Text = dr[11].ToString().Substring(0,10);
                    txtsdt.Text = dr[12].ToString();
                    ngayvaolam.Text = dr[13].ToString();
                    txtemail.Text = dr[14].ToString();
                    txtsohd.Text = dr[15].ToString();
                    txtmacv.Text = dr[16].ToString();
                    txtmapb.Text = dr[17].ToString();
                    txtmatd.Text = dr[18].ToString();
                    txtngoaingu.Text = dr[19].ToString();
                    txtmacd.Text = dr[20].ToString();
                    txthsl.Text = dr[21].ToString();
                    txtkyluat.Text = dr[22].ToString();
                    txtkhen.Text = dr[23].ToString();
                    cbbloaihd.Text = dr[24].ToString();
                    ngaybd.Text = dr[25].ToString();
                    ngaykt.Text = dr[26].ToString();
                    txttencv.Text = dr[27].ToString();
                    txttenpb.Text = dr[28].ToString();
                    txttentd.Text = dr[29].ToString();
                    txtchuyenmon.Text = dr[30].ToString();
                    txttencd.Text = dr[31].ToString();
                    txttenkl.Text = dr[32].ToString();
                    txttenkhen.Text = dr[33].ToString();

                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void cbbmanv_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadData();
            btnedit.Enabled = true;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            BSH_Report frm = new BSH_Report("TTNhanVien.rpt","SELECT * FROM NhanVien WHERE MaNV ='"+cbbmanv.Text+"'");
            frm.ShowDialog();
        }
    }
}