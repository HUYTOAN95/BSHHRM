using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHHRMCNTTT.SO
{
    class DBConnection
    {
        public static SqlConnection cnn;
        private SqlDataAdapter da;
        public  static void  InforConnect(string ser, string db, string user, string pass)
        {
            string cnnstring = "Data Source=" + ser + ";Initial Catalog=" + db + ";User ID=" + user + ";Password=" + pass + ";Integrated Security=True";
            cnn = new SqlConnection(cnnstring);
            
        }
        public static SqlConnection OpenConnection()
        {  
            try
            {
              
                if (cnn.State == ConnectionState.Closed || cnn.State==ConnectionState.Broken)
                    cnn.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return cnn;
        }
        /// <summary>
        /// hàm đóng kết nối
        /// </summary>
        public static SqlConnection CloseConnection()
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return cnn;
        }
        #region[LKE]
        public DataTable LKE (string v_query , SqlParameter [] sqlprameter, CommandType Type)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter();
            dt = null;
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = v_query;
                cmd.CommandType = Type;
                cmd.Parameters.AddRange(sqlprameter);
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (SqlException)
            {
                return null;
            }
            finally
            {

            }
            return dt;
        }
        #endregion
        // Xử lý thêm bản ghi 
        #region [NH]
        public bool NH(string v_query, SqlParameter[] sqlparameter, CommandType Type)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = v_query;
                cmd.CommandType = Type;
                cmd.Parameters.AddRange(sqlparameter);
                da.InsertCommand = cmd;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException )
            {
                return false;
            }
            finally
            {
            }
            return true;
        }
        #endregion
        //Xử lý sửa cập nhật bản ghi 
        #region[SUA]
        public bool SUA(string v_query, SqlParameter[] sqlparameter, CommandType Type)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandType = Type;
                cmd.CommandText = v_query;
                cmd.Parameters.AddRange(sqlparameter);
                da.UpdateCommand = cmd;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException )
            {
                return false;
            }
            finally
            {
            }
            return true;
        }
        #endregion
    }
}
