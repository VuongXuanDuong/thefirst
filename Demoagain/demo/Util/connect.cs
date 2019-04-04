using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
//using Dapper;


namespace demo.Util
{
    class connect
    {
       // SqlConnection connection;
        public SqlCommand cmd;
        public DataTable dt;
        public SqlDataAdapter da;
        public static String con = ConfigurationManager.ConnectionStrings["quanlysach"].ConnectionString.ToString();
        public SqlConnection connection = new SqlConnection(con);
        public DataTable Creattable(String sql)
        {
            connection.Open();
            da = new SqlDataAdapter(sql, connection);
            dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }

    }
}
