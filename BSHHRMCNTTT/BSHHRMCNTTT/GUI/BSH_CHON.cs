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

namespace BSHHRMCNTTT.SysForm
{
   
    public partial class frmlselect : DevExpress.XtraEditors.XtraForm
    {
        public string query { get; set; }
        public string caption { get; set; }
        string _Filter = "";
        public frmlselect()
        {
            InitializeComponent();
        }

        private void frmConnectDB_Load(object sender, EventArgs e)
        {
            loaddata();
            this.Text = caption;
        }
        private void loaddata()
        {

                string v_query = query +" "+ _Filter;
           
                SqlDataAdapter da = new SqlDataAdapter(v_query, DBConnection.cnn);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                 
                DataSet ds = new DataSet();
              
                da.Fill(ds);
                gridview.DataSource = ds.Tables[0];
            




        }
        public string Selected { get { return gridview.CurrentRow.Cells[0].Value.ToString(); } }
        public string Selected2 { get { return gridview.CurrentRow.Cells[1].Value.ToString(); } }

        private void frmlselect_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Escape:
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
                default:
                    break;
            }

        }

        private void frmlselect_FormClosed(object sender, FormClosedEventArgs e)
        {
            cbbitem.Items.Clear();
        }

        private void b_choose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void b_filter_Click(object sender, EventArgs e)
        {
            _Filter = "WHERE [" + cbbitem.Text + "] LIKE '%" + t_fillter.Text + "%'";
            loaddata();
        }
    }
}