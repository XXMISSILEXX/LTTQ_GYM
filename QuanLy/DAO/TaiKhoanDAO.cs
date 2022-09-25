using QuanLy.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLy.DAO
{
    public class TaiKhoanDAO: DataProvider
    {
        public ArrayList CheckLogin(string username, string password)
        {
            connect();

            string cmd = "SELECT * FROM TaiKhoan WHERE username = '" + username+"' and password ='"+password+"'";
            adapter = new SqlDataAdapter(cmd, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ArrayList arr = ConvertDataSetToArrayList(dataset);
            return arr;
        }
    }
}
