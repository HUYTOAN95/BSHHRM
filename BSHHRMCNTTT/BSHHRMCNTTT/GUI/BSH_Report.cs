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
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using BSHHRMCNTTT.SO;

namespace BSHHRMCNTTT.GUI
{
    public partial class BSH_Report : DevExpress.XtraEditors.XtraForm
    {
        SqlDataAdapter da;
        DataSet ds;
        public BSH_Report(string FileName, string vquery)
        {
            InitializeComponent();
            // Xử lý báo cáo 
            #region[Report]
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(System.IO.Directory.GetCurrentDirectory() + "\\Reports\\" + FileName);
            SqlCommand cmd = new SqlCommand();
            da = new SqlDataAdapter();
            ds = new DataSet();
            try
            {
                cmd.Connection = DBConnection.OpenConnection();
                cmd.CommandText = vquery;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
                cryRpt.SetDataSource(ds.Tables[0]);
                
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error" + ex);
            }

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            #endregion

        }
    }
}