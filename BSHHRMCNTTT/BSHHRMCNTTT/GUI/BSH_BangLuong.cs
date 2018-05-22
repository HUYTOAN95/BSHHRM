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
using System.Globalization;
using System.Data.SqlClient;
using BSHHRMCNTTT.SO;

namespace BSHHRMCNTTT.GUI
{
    public partial class BSH_BangLuong : DevExpress.XtraEditors.XtraForm
    {
        private DBConnection db; 
        public BSH_BangLuong()
        {
            db = new DBConnection();
            InitializeComponent();
        }

        private void BSH_BangLuong_Load(object sender, EventArgs e)
        {
            LoadData();
            txtNam.Text = DateTime.Today.ToString("yyyy");
            cbbthang.Text = DateTime.Today.ToString("MM");
        }
        private void LoadData()
        {
            try
            {
                string query = string.Format("SPBSH_LUONG_LKE_TEST");
            SqlParameter[] para = new SqlParameter[0];
            GridView.DataSource = db.LKE(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // đổi đơn vị tiền thành chữ 
        public static string ConvertDecimalToString(decimal number)
        {
            string s = number.ToString("#");
            string[] so = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hang = new string[] { "", "nghìn", "triệu", "tỷ" };
            int i, j, donvi, chuc, tram;
            string str = " ";
            bool booAm = false;
            decimal decS = 0;
            //Tung addnew
            try
            {
                decS = Convert.ToDecimal(s.ToString());
            }
            catch
            {
            }
            if (decS < 0)
            {
                decS = -decS;
                s = decS.ToString();
                booAm = true;
            }
            i = s.Length;
            if (i == 0)
                str = so[0] + str;
            else
            {
                j = 0;
                while (i > 0)
                {
                    donvi = Convert.ToInt32(s.Substring(i - 1, 1));
                    i--;
                    if (i > 0)
                        chuc = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        chuc = -1;
                    i--;
                    if (i > 0)
                        tram = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        tram = -1;
                    i--;
                    if ((donvi > 0) || (chuc > 0) || (tram > 0) || (j == 3))
                        str = hang[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if ((donvi == 1) && (chuc > 1))
                        str = "một " + str;
                    else
                    {
                        if ((donvi == 5) && (chuc > 0))
                            str = "lăm " + str;
                        else if (donvi > 0)
                            str = so[donvi] + " " + str;
                    }
                    if (chuc < 0)
                        break;
                    else
                    {
                        if ((chuc == 0) && (donvi > 0)) str = "lẻ " + str;
                        if (chuc == 1) str = "mười " + str;
                        if (chuc > 1) str = so[chuc] + " mươi " + str;
                    }
                    if (tram < 0) break;
                    else
                    {
                        if ((tram > 0) || (chuc > 0) || (donvi > 0)) str = so[tram] + " trăm " + str;
                    }
                    str = " " + str;
                }
            }
            if (booAm) str = "Âm " + str;
            return str + "đồng chẵn";
        }

        private void GridView_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal luongnhan = Decimal.Parse(GridView.CurrentRow.Cells[5].Value.ToString().Trim());
                labelvnd.Text = "Số lương nhận bằng chữ : " + ConvertDecimalToString(luongnhan);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            try
            {
                int vthang = Int32.Parse(cbbthang.Text);
                int vnam = Int32.Parse(txtNam.Text);
                string query = string.Format("SELECT * FROM LuongNV WHERE Thang = '"+vthang+"' AND Nam ='"+vnam+"'");
                SqlParameter[] para = new SqlParameter[0];
                GridView.DataSource = db.LKE_TIM(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            BSH_Report frm = new BSH_Report("LuongNV.rpt", "SELECT * FROM LuongNV");
            frm.ShowDialog();
        }
    }
}