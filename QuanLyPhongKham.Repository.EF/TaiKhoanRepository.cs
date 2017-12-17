using QuanLyPhongKham.Model.Interfaces;
using QuanLyPhongKham.Repository.EF.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyPhongKham.Repository.EF
{
    public class TaiKhoanRepository : ITaiKhoanRepository
    {
        public int DoiMatKhau(string userName, string passWord, string newPassWord, int manv)
        {
            throw new NotImplementedException();
        }

        public DataTable Login(string userName, string passWord)
        {
            throw new NotImplementedException();
        }
    }
}

