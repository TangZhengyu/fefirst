using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Security;

namespace register.DAL
{
    public static class DbHelper
    {
        private static string Constring =ConfigurationManager.ConnectionStrings["***"].ConnectionString;
        private static SqlCommand GetCommand(string sql, bool isProc = false, params SqlParameter[] paras)
        {
            SqlConnection con = new SqlConnection(Constring);
            SqlCommand com = new SqlCommand(sql, con);
            if (isProc)
            {
                com.CommandType = CommandType.StoredProcedure;
            }
            if (paras.Length > 0)
            {

                com.Parameters.AddRange(paras);
            }
            return com;

        }

        public static int Execu(string sql, bool isProc = false, params SqlParameter[] paras)
        {
            SqlCommand com = GetCommand(sql, isProc, paras);
            try
            {
                com.Connection.Open();
                return com.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                com.Connection.Close();
            }

        }
        public static DataTable selectTable(string sql, bool isProc = false, params SqlParameter[] paras)
        {
            SqlCommand com = GetCommand(sql, isProc, paras);
            SqlDataAdapter dt = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            try
            {
                com.Connection.Open();
                dt.Fill(table);
                return table;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                com.Connection.Close();
            }
        }

    }

}