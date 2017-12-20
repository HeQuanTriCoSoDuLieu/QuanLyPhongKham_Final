using QuanLyPhongKham.Model.Interfaces;
using QuanLyPhongKham.Repository.EF.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyPhongKham.Model.DTO;

namespace QuanLyPhongKham.Repository.EF
{
    public class TaiKhoanRepository : ITaiKhoanRepository
    {
        public int CapNhatTaiKhoan(int manv, string tendangnhap, string matkhau, string tenhienthi, int maphanquyen, int trangthai)
        {
            throw new NotImplementedException();
        }

        public List<TaiKhoan> DanhSachTaiKhoan()
        {
            throw new NotImplementedException();
        }

        public int DoiMatKhau(string userName, string passWord, string newPassWord, int manv)
        {
            throw new NotImplementedException();
        }

        public DataTable Login(string userName, string passWord)
        {
            throw new NotImplementedException();
        }

        public int ThemTaiKhoan(int manv, string tendangnhap, string matkhau, string tenhienthi, int maphanquyen, int trangthai)
        {
            throw new NotImplementedException();
        }
    }
}

