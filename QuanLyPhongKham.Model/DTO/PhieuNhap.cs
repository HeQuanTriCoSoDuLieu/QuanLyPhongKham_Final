using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class PhieuNhap
    
    {
        public PhieuNhap() { }

        public PhieuNhap(int maphieunhap,int manv,DateTime ngaynhap)
        {
            MaPhieuNhap = maphieunhap;
            MaNV = manv;
            NgayNhap = ngaynhap;
        }
        
        public PhieuNhap(DataRow row)
        {
            MaPhieuNhap = (int)row["MAPHIEUNHAP"];
            MaNV = (int)row["MANV"];
            NgayNhap = (DateTime)row["NGAYNHAP"];
        }
        public int MaPhieuNhap { get; set; }
        public int MaNV { get; set; }
        public DateTime NgayNhap { get; set; }
    }
}
