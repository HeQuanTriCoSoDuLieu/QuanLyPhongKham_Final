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


        public DataTable Login(string userName, string passWord)
        {

            DataTable dataTable = DataProvider.Instane.ExecuteReader("EXEC dbo.SP_Login @TenDangNhap , @MatKhau", new object[] { userName, passWord });

            return dataTable;

        }
    }
}
