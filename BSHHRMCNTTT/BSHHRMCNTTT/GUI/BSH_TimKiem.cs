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
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using BSHHRMCNTTT.SO;

namespace BSHHRMCNTTT.GUI
{
    public partial class BSH_TimKiem : DevExpress.XtraEditors.XtraForm
    {
        private DBConnection db;
        private bool IsPrint = false;
        private string v_fill;
        private string v_data;
        public BSH_TimKiem()
        {
            db = new DBConnection();
           
            InitializeComponent();
        }
        private void LoadItem()
        {
            if (cbbitem.Text.Equals("Nhân Viên"))
            {
                cbbfill.Items.Add("Mã nhân viên");
                cbbfill.Items.Add("Tên nhân viên");
                cbbfill.Items.Add("Phòng ban");
                cbbfill.Items.Add("Trình độ");
                cbbfill.Items.Add("Dân tộc");
                cbbfill.Items.Add("Tôn Giáo");
            }
            if (cbbitem.Text.Equals("Bảng Lương"))
            {
                cbbfill.Items.Add("Mã nhân viên");
                cbbfill.Items.Add("Tháng");
                cbbfill.Items.Add("Năm");

            }
            if (cbbitem.Text.Equals("Phòng Ban"))
            {
                cbbfill.Items.Add("Mã phòng ban");
                cbbfill.Items.Add("Tên phòng ban");

            }
        }

        private void cbbitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbfill.Items.Clear();
            LoadItem();
            txtdata.Clear();
        }
        string vItem = "";
        string vReport = "";
        private void btnloc_Click(object sender, EventArgs e)
        {

            if (cbbitem.Text.Equals("Nhân Viên"))
            {
                vItem = "NhanVien";
                vReport = "NhanVien.rpt";
            }
            if (cbbitem.Text.Equals("Bảng Lương"))
            {
                vItem = "BangLuong";
                vReport = "LuongNV.rpt";
            }
            if (cbbitem.Text.Equals("Phòng Ban"))
            {
                vItem = "PhongBan";
                vReport = "PhongBan.rpt";

            }
            v_fill = cbbfill.Text;
            v_data = txtdata.Text;

            try
            {
                string query = "";
                if (cbbfill.Text.Equals(""))
                    query = string.Format("SELECT * FROM View_" + vItem + "");
                else
                {
                    query = string.Format("SELECT * FROM View_" + vItem + " WHERE [" + v_fill + "] LIKE N'%" + v_data + "'");
                    IsPrint = true;
                }
                SqlParameter[] para = new SqlParameter[0];
                GridView.DataSource = db.LKE_TIM(query);
                if (vItem == "PhongBan" || vItem == "NhanVien")
                { GridView.Columns[1].Width = 200; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            v_fill = cbbfill.Text;
            v_data = txtdata.Text;
            if (IsPrint == true)
            {
                BSH_Report frm = new BSH_Report(vReport, "SELECT * FROM View_" + vItem + " WHERE [" + v_fill + "] LIKE N'%" + v_data + "'");
                frm.ShowDialog();
            }
            else
            {
                BSH_Report frm = new BSH_Report(vReport, "SELECT * FROM View_" + vItem + "");
                frm.ShowDialog();

            }
            IsPrint = false;

           
        }
    }
}