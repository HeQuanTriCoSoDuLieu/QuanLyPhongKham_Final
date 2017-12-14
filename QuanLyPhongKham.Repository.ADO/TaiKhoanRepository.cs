using QuanLyPhongKham.Model;
using QuanLyPhongKham.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyPhongKham.Repository.ADO
{
    public class TaiKhoanRepository : ITaiKhoanRepository
    {
        public int DoiMatKhau(string userName, string passWord, string newPassWord, int manv)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXEC dbo.SP_Update_MatKhauByUserName @USERNAME , @PASSWORD , @NEWPASSWORD , @MANV", new object[] { userName, passWord, newPassWord, manv });
            return row;
        }

        public DataTable Login(string userName, string passWord)
        {

            DataTable dataTable = DataProvider.Instane.ExecuteReader("EXEC dbo.SP_Login @TenDangNhap , @MatKhau", new object[] { userName, passWord });

            return dataTable;

        }
    }
}
