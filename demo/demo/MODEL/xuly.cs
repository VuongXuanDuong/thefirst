using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace demo.MODEL
{

    class xuly
    {
        //String conString = ConfigurationManager.ConnectionStrings.["Quanlysach"].toString();
        public static SqlConnection connection ;
        public static SqlCommand cmd;
        public static DataTable dt;
        public static SqlDataAdapter da;
        public static String con = ConfigurationManager.ConnectionStrings["quanlysach"].ConnectionString.ToString();
        public static DataTable TaoBang(String sql)
        {
            //String conString = ConfigurationManager.ConnectionStrings.["Quanlysach"].ConnectionStrings.toString();
            connection = new SqlConnection(con);
            connection.Open();
            da = new SqlDataAdapter(sql, connection);
            dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }
        public static int ExcuteNonQuery(String sql)
        {
            int re = 0;
            connection = new SqlConnection(con);
            connection.Open();
            cmd = new SqlCommand(sql, connection);
            re = cmd.ExecuteNonQuery();
            return re;
        }

    }
}
