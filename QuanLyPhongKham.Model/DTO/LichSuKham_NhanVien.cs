using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class LichSuKham_NhanVien
    {      
        public int STT { get; set; }
        public int MaBn { get; set; }
        public int MaPhieuKham { get; set; }
        public string HoTen { get; set; }
        public DateTime NgayKham { get; set; }
        public bool DaThanhToan { get; set; }

        public LichSuKham_NhanVien() { }
        public LichSuKham_NhanVien(int mabn, int maphieu, string hoten, DateTime ngaykham, bool dathanhtoan)
        {
            this.MaBn = mabn;
            this.MaPhieuKham = maphieu;
            this.HoTen = hoten;
            this.NgayKham = ngaykham;
            this.DaThanhToan = dathanhtoan;
        }
        public LichSuKham_NhanVien(DataRow row)
        {
            this.MaBn = (int)row["MABN"];
            this.MaPhieuKham = (int)row["MAPHIEUKHAM"];
            this.HoTen = row["HOTEN"].ToString();             
            this.NgayKham =(DateTime) row["NGAYKHAM"];
            this.DaThanhToan = (bool)row["DATHANHTOAN"];
        }

    }
}
