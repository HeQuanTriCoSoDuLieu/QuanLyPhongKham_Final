using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class ChiTietPhieuNhapThuoc
    {
        public ChiTietPhieuNhapThuoc()
        { }

        public ChiTietPhieuNhapThuoc(int maphieunhap,int mathuoc,int soluong,DateTime ngaysx, DateTime ngayhethan, decimal gianhap, decimal giabanle,int mahsx, int manhacc)
        {
            MaPhieuNhap = manhacc;
            MaThuoc = mathuoc;
            SoLuong = soluong;
            NgaySX = ngaysx;
            NgayHetHan = ngayhethan;
            GiaNhap = gianhap;
            GiaBanLe = giabanle;
            MaHSX = mahsx;
            MaNhaCC = manhacc;
        }
        public ChiTietPhieuNhapThuoc(DataRow row)
        {
            MaPhieuNhap = (int)row["MAPHIEUNHAP"];
            MaThuoc = (int)row["MATHUOC"];
            SoLuong = (int)row["SOLUONG"];
            NgaySX = (DateTime)row["NGAYSX"];
            NgayHetHan = (DateTime)row["NGAYHETHAN"];
            GiaNhap = (decimal)row["GIANHAP"];
            GiaBanLe = (decimal)row["GIABANLE"];
            MaHSX = (int)row["MAHSX"];
            MaNhaCC = (int)row["MANHACC"];
        }
        public int MaPhieuNhap { get; set; }
        public int MaThuoc { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgaySX { get; set; }
        public DateTime NgayHetHan { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBanLe { get; set; }
        public int MaHSX { get; set; }
        public int MaNhaCC { get; set; }
    }
}
