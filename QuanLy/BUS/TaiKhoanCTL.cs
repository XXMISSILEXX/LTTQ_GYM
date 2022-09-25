using QuanLy.DAO;
using QuanLy.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.BUS
{
    public class TaiKhoanCTL
    {
        private TaiKhoanDAO data = new TaiKhoanDAO();
        private TaiKhoanDTO info = new TaiKhoanDTO();
        public TaiKhoanDTO TaiKhoan{
            get { return info; }
            set { info = value; }
        }
    }
}
