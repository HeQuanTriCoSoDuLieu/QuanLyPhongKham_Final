using QuanLyPhongKham.Model;
using QuanLyPhongKham.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyPhongKham.Model.DTO;

namespace QuanLyPhongKham.Repository.ADO
{
    public class TaiKhoanRepository : ITaiKhoanRepository
    {
        public int CapNhatTaiKhoan(int manv, string tendangnhap, string matkhau, string tenhienthi, int maphanquyen, int trangthai)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXEC dbo.SP_Update_TaiKhoan @MANV , @TENDANGNHAP , @MATKHAU , @TENHIENTHI , @MAPHANQUYEN , @TRANGTHAI", new object[] { manv,tendangnhap,matkhau,tenhienthi,maphanquyen,trangthai});
            return row;
        }

        public List<TaiKhoan> DanhSachTaiKhoan()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            DataTable dataTable = DataProvider.Instane.ExecuteReader("EXEC dbo.SP_Select_TaiKhoan", new object[] { });
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(new TaiKhoan(row));
            }
            return list;

        }

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

        public int ThemTaiKhoan(int manv, string tendangnhap, string matkhau, string tenhienthi, int maphanquyen, int trangthai)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXEC dbo.SP_Insert_TaiKhoan @MANV , @TENDANGNHAP , @MATKHAU , @TENHIENTHI , @MAPHANQUYEN , @TRANGTHAI", new object[] { manv, tendangnhap, matkhau, tenhienthi, maphanquyen, trangthai });
            return row;
        }
    }
}
