using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace demo.MODEL
{
    class book
    {
        private string _id;
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _tensach;
        public string tensach
        {
            get { return _tensach; }
            set { _tensach = value; }
        }
        private string _tacgia;
        public string tacgia
        {
            get { return _tacgia; }
            set { _tacgia = value; }
        }

        private string _namxuatban;
        public string namxuatban
        {
            get { return _namxuatban; }
            set { _namxuatban = value; }
        }

        
       
        public book(string iD, string tenSach, string tacGia, string namXuatban)
        {
            this._id = iD;
            this._tensach = tenSach;
            this._tacgia = tacGia;
            this._namxuatban = namXuatban;
            
        }
    }
}
