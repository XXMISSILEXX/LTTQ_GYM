using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
    public class TaiKhoanDTO
    {
        private string _id;
        private string _user;
        private string _password;
        public string ID_NV
        {
            get { return _id; }
            set { _id = value; }
        }

        public string UserName
        {
            get { return _user; }
            set { _user = value; }
        }

        public string PassWord
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
