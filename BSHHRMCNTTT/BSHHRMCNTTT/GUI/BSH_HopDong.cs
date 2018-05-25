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
    public partial class BSH_HopDong : DevExpress.XtraEditors.XtraForm
    {
        private DBConnection db;
        private string v_Item = null;
        private string v_Info = null;
        private bool  IsFilter = false;
        public BSH_HopDong()
        {
            db = new DBConnection();
            InitializeComponent();
        }
        private void LoadData()
        {
            string v_query = string.Format("SPBSH_HD_LKE");
            SqlParameter para = new SqlParameter{};
            GridView.DataSource = db.LKE(v_query);
        }

        private void BSH_HopDong_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void FilterData()
        {
            if(cbbitem.Text=="Số hợp đồng ")
            {
                v_Item = "SoHD";
            }
            if (cbbitem.Text == "Loại hợp đồng")
            {
                v_Item = "LoaiHD";
            }
            if (cbbitem.Text == "Ngày bắt đầu")
            {
                v_Item = "NgayBD";
            }
            if (cbbitem.Text == "Ngày kết thúc")
            {
                v_Item = "NgayKT";
            }
            v_Info = txtdata.Text;
            try
            {
                string v_query = string.Format("SELECT * FROM HopDong WHERE "+v_Item+" LIKE N'%"+v_Info+"%'");
                SqlParameter para = new SqlParameter { };
                GridView.DataSource = db.LKE_TIM(v_query);
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Error" + ex);
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            FilterData();
            IsFilter = true;
            txtdata.Clear();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadData();
            IsFilter = false;
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if(IsFilter==true)
            {
                BSH_Report frm = new BSH_Report("Hopdong.rpt", "SELECT * FROM HopDong WHERE "+v_Item+" LIKE N'%"+v_Info+"%'");
                frm.ShowDialog();
            }
            else
            {
                BSH_Report frm = new BSH_Report("Hopdong.rpt", "SELECT * FROM HopDong");
                frm.ShowDialog();
            }
        }
    }
}