using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.Interfaces
{
    public interface ITaiKhoanRepository
    {
        int DoiMatKhau(string userName, string passWord, string newPassWord, int manv);
        DataTable Login(string userName, string passWord);
    }
}
