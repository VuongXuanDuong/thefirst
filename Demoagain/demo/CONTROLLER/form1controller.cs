using System;
using System.Data;
using System.Data.SqlClient;
using demo.MODEL;
using demo.Util;

namespace demo.CONTROLLER
{
    class form1controller:connect
    {
        public DataTable Display()
        {
            DataTable re;
            String con = "SELECT * FROM book";
            re = Creattable(con);
            return re;
        }

        public void Insert(book book)
        {
            cmd = new SqlCommand("INSERT INTO book(id, tensach, tacgia, namxuatban) VALUES('" + book.id + "','" + book.tensach + "','" + book.tacgia + "','"+book.namxuatban+"')", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();


        }
        public void Delete(book book)
        {
            cmd = new SqlCommand("DELETE FROM book WHERE id= '" + book.id+"' ", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

    }
}
