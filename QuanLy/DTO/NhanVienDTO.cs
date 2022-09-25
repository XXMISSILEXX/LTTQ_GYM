using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
    public class NhanVienDTO
    {
        private string _id;
        private string _hoten;
        private string _gioitinh;
        private string _sdt;
        public string ID_NV
        {
            get { return _id; }
            set { _id = value; }
        }

        public string HoTen
        {
            get { return _hoten; }
            set { _hoten = value; }
        }

        public string GioiTinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }

        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
    }
}
