using QuanLyPhongKham.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Repositories.EF
{
    public class TaiKhoanRepository : ITaiKhoanRepository
    {
        public bool Login(string userName, string passWord)
        {
            return QuanLyPhongKhamDbContext.Instance.TAIKHOAN.Where(a => a.TenDangNhap==userName && a.MatKhau==passWord).Count() > 0;
        }
    }
}
