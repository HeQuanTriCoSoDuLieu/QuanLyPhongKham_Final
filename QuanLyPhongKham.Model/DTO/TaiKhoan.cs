using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyPhongKham.Model.DTO
{
    public class TaiKhoan
    {
        public TaiKhoan(int maTK, int maNV, string tenDangNhap, string matKhau, string tenHienThi, int maPhanQuyen, bool trangThai)
        {
            MaTK = maTK;
            MaNV = maNV;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            TenHienThi = tenHienThi;
            MaPhanQuyen = maPhanQuyen;
            TrangThai = trangThai;
        }

        public TaiKhoan(DataRow row)
        {
            MaTK = (int)row["MATK"];
            MaNV = (int)row["MANV"];
            TenDangNhap = (string)row["TENDANGNHAP"];
            MatKhau = (string)row["MATKHAU"];
            TenHienThi = (string)row["TENHIENTHI"];
            MaPhanQuyen = (int)row["MAPHANQUYEN"];
            TrangThai = (bool)row["TRANGTHAI"];
        }

        public TaiKhoan() { }



        public int MaTK { get; set; }
        public int MaNV { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string TenHienThi { get; set; }
        public int MaPhanQuyen { get; set; }
        public bool TrangThai { get; set; }

    }
}
