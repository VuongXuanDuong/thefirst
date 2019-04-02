using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using demo.VIEW;


namespace demo.MODEL
{
    class form1model
    {
        //public string tensach{get; set;} 
        //public string tacgia { get;set }
        //public string namxuatban { get;set }

        
        public DataTable Display()
        {
            DataTable re;
            String con = "SELECT * FROM book";
            re = xuly.TaoBang(con);
            return re;
        }
        //public DataTable Insall()
        //{
        //    DataTable re;
            
        //    return re;
        //}

    }
}
