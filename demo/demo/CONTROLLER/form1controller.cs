using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.MODEL;
using System.Data;
namespace demo.CONTROLLER
{
    class form1controller
    {
        form1model form1 = new form1model();
        public DataTable Display()
        {
            return form1.Display();
        }
        public void Insert( String id, String tensach, String tacgia, String namxuatban)
        {
            form1.Insert(id, tensach, tacgia, namxuatban);
        }
        public void Delete(String id)
        {
            form1.Delete(id);
        }
    }
}
