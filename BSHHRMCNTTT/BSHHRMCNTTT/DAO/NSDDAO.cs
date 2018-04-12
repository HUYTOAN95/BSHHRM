using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSHHRMCNTTT.SO;
using BSHHRMCNTTT.VO;
using System.Data.Common;

namespace BSHHRMCNTTT.DAO
{  // tạo lớp Database Access Layer - DAO
    class NSDDAO
    {
        private DBConnection cnn;
        public NSDDAO()
        {
            cnn = new DBConnection();
        }
        //Xử lý phương thức liệt kê  ở lớp Database Access Layer
        #region [NSD_LKE]
        public DataTable NSD_LKE()
        {

            string vquery = string.Format("SPBSH_NSD_LKE");
            
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return cnn.LKE(vquery, sqlParameters,CommandType.StoredProcedure);
            //using (var cmd = new SqlCommand("SPBSH_NSD_LKE", DBConnection.cnn))
            //{
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    var da = new SqlDataAdapter(cmd);
            //    var dt = new DataTable();
            //    da.Fill(dt);
            //    return dt;
            //}
        }
        #endregion
        #region [NSD_LKE_ID]
        public DataTable NSD_LKE_ID( string Filter1, string Filter2)
        {

            string vquery = string.Format("SELECT * FROM bsh_nsd WHERE ma_dv LIKE @Filter1 AND nsd LIKE @Filter2");

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Filter1", Filter1),
                new SqlParameter("@Filter2", Filter2),
            };
            return cnn.LKE(vquery, sqlParameters, CommandType.Text);
            //using (var cmd = new SqlCommand("SPBSH_NSD_LKE", DBConnection.cnn))
            //{
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    var da = new SqlDataAdapter(cmd);
            //    var dt = new DataTable();
            //    da.Fill(dt);
            //    return dt;
            //}
        }
        #endregion
        //Xử lý phương thức nhập ở lớp Database Access Layer


        #region [NSD_NH]
        public void NSD_NH(NSDInfo nsd)
        {
            string vquery = string.Format("SPBSH_NSD_NH");
            SqlParameter[] sqlParameters = {
                new SqlParameter("@madv", nsd.b_madv),
                new SqlParameter("@nsd", nsd.b_nsd),
                new SqlParameter("@matkhau", nsd.b_matkhau),
                new SqlParameter("@manv", nsd.b_manv),
                new SqlParameter("@ngaydk", nsd.b_ngaydk),
                new SqlParameter("@ngayhh", nsd.b_ngayhh),
                new SqlParameter("@quyendn", nsd.b_quyendn),
                new SqlParameter("@email", nsd.b_email),
                new SqlParameter("@StatementType", "ADD")

            };
          
            
            cnn.NH(vquery, sqlParameters, CommandType.StoredProcedure);

            //using (var cmd = new SqlCommand("SPBSH_NSD_NH", DBConnection.cnn))
            //{
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.Add(new SqlParameter("@madv", nsd.b_madv));
            //    cmd.Parameters.Add(new SqlParameter("@nsd", nsd.b_nsd));
            //    cmd.Parameters.Add(new SqlParameter("@matkhau", nsd.b_matkhau));
            //    cmd.Parameters.Add(new SqlParameter("@manv", nsd.b_manv));
            //    cmd.Parameters.Add(new SqlParameter("@ngaydk", nsd.b_ngaydk));
            //    cmd.Parameters.Add(new SqlParameter("@ngayhh", nsd.b_ngayhh));
            //    cmd.Parameters.Add(new SqlParameter("@quyendn", nsd.b_quyendn));
            //    cmd.Parameters.Add(new SqlParameter("@email", nsd.b_email));
            //    cmd.Parameters.Add(new SqlParameter("@StatementType", "ADD"));
            //    cmd.ExecuteNonQuery();
            //}
        }
        #endregion
        #region [NSD_SUA]
        public void NSD_SUA(NSDInfo nsd)
        {
        
            string vquery = string.Format("SPBSH_NSD_NH");
            SqlParameter [] SqlParameter =
             {
                new SqlParameter("@madv", nsd.b_madv),
                new SqlParameter("@nsd", nsd.b_nsd),
                new SqlParameter("@matkhau", nsd.b_matkhau),
                new SqlParameter("@manv", nsd.b_manv),
                new SqlParameter("@ngaydk", nsd.b_ngaydk),
                new SqlParameter("@ngayhh", nsd.b_ngayhh),
                new SqlParameter("@quyendn", nsd.b_quyendn),
                new SqlParameter("@email", nsd.b_email),
                new SqlParameter("@StatementType", "EDIT")
            };
            cnn.SUA(vquery, SqlParameter, CommandType.StoredProcedure);
           
        }
        #endregion
        #region [NSD_DMK]
        public void NSD_DMK(NSDInfo nsd)
        {

            
        }
        #endregion
        #region [NSD_XOA]
        public void NSD_XOA(NSDInfo nsd)
        {

            using (var cmd = new SqlCommand("SPBSH_NSD_NH", DBConnection.cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@madv", nsd.b_madv));
                cmd.Parameters.Add(new SqlParameter("@nsd", nsd.b_nsd));
                cmd.Parameters.Add(new SqlParameter("@matkhau",DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@manv", DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@ngaydk", DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@ngayhh", DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@quyendn", DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@email", DBNull.Value));
                cmd.Parameters.Add(new SqlParameter("@StatementType", "DELETE"));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region [NSD_DMK]
        //public void NSD_DMK(NSDInfo nsd)
        //{
        //    string v_query = "";
        //    using (var cmd = new SqlCommand(v_query, DBConnection.cnn))
        //    {
        //        cmd.CommandType = CommandType.Text;
        //        cmd.ExecuteNonQuery();
        //    }
        //}
        #endregion
    }
}
