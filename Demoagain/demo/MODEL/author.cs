using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.MODEL
{
    class author
    {
        private string _tacgia;
        public string tacgia
        {
            get { return _tacgia; }
            set { _tacgia = value; }
        }

        private string _namsinh;
        public string namsinh
        {
            get { return _namsinh; }
            set { _namsinh = value; }
        }
        private string _quequan;
        public string quequan
        {
            get { return _quequan; }
            set { _quequan = value; }
        }

       public author(string tacGia, string namSinh, string queQuan)
        {
            this._tacgia = tacGia;
            this._namsinh = namSinh;
            this._quequan = queQuan;
        }
    }
}
