using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace demo.MODEL
{
    class form1model
    {
        //public string tensach{get; set;} 
        //public string tacgia { get;set }
        //public string namxuatban { get;set }
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        public static String con = ConfigurationManager.ConnectionStrings["quanlysach"].ConnectionString.ToString();
        SqlConnection connection = new SqlConnection(con);
        public DataTable TaoBang(String sql)
        {
            //String conString = ConfigurationManager.ConnectionStrings.["Quanlysach"].ConnectionStrings.toString();
            
            connection.Open();
            da = new SqlDataAdapter(sql, connection);
            dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }


        public DataTable Display()
        {
            DataTable re;
            String con = "SELECT * FROM book";
            re = TaoBang(con);
            return re;
        }
        public void Insert(String id, String tensach, String tacgia, String namxuatban)
        {
            cmd = new SqlCommand("INSERT INTO book(id,tensach,tacgia,namxuatban) VALUES('" + id + "','" + tensach + "','" + tacgia + "','" + namxuatban + "')", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        public void Delete(String id)
        {
            cmd = new SqlCommand("DELETE FROM book WHERE id='"+id+"' ", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

    }
}
