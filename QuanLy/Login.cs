using QuanLy.BUS;
using QuanLy.DAO;
using QuanLy.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
    public partial class Login : Form
    {
        private TaiKhoanCTL taikhoanCTL = new TaiKhoanCTL();
        private TaiKhoanDTO tk = new TaiKhoanDTO();
        private TaiKhoanDAO tkdao = new TaiKhoanDAO();
        public Login()
        {
            InitializeComponent();
        }
      
        public void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (tkdao.CheckLogin(txtUsername.Text, txtPassword.Text).Count<1)
            {
                MessageBox.Show("Tên đăng nhập hoặc tài khoản không tồn tại!");
            }
            else
            {
                Form1 fmain = new Form1();
                this.Hide();
                fmain.ShowDialog();
                this.Show();
            }
        }
    }
}
