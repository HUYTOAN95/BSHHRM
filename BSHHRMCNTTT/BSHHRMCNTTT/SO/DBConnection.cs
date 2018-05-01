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
            //string cnnstring = "Data Source=127.0.0.1,1433;Initial Catalog=BSHHRM;User ID=admin;Password=admin;Integrated Security=True";
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
        // xử lý liệt kê bản ghi 
        #region[LKE]
        public DataTable LKE (string v_nameproc)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter();
            dt = null;
            DataSet ds = new DataSet();
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = v_nameproc;
                cmd.CommandType = CommandType.StoredProcedure;
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
        // xử lý tìm kiếm bản ghi 
        #region[TIMKIEM] 
        public DataTable LKE_TIM(string v_query)
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
                cmd.CommandType = CommandType.Text;
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
        #region [AddRecord]
        public bool AddRecord(string v_nameprc, SqlParameter[] sqlparameter)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandText = v_nameprc;
                cmd.CommandType = CommandType.StoredProcedure;
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
        #region[UpdateRecord]
        public bool UpdateRecord(string v_nameprc, SqlParameter[] sqlparameter)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = v_nameprc;
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
        // xủ lý xóa bản ghi 
        #region[DeleteRecord]
        public bool DeleteRecord (string v_nameproc, SqlParameter[] sqlparameter)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = v_nameproc;
                cmd.Parameters.AddRange(sqlparameter);
                da.DeleteCommand = cmd;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
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
