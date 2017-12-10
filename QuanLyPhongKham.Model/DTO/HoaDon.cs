using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class HoaDon
    {
        public HoaDon() { }
        public HoaDon(int mAHOADON, int mAPHIEUKHAM, int tONGCONG)
        {
            MaHoaDon = mAHOADON;
            MaPhieuKham = mAPHIEUKHAM;
            TongCong = TongCong;
        }
        public HoaDon(DataRow row)
        {
            MaHoaDon = (int)row["MaHoaDon"];
            MaPhieuKham = (int)row["MaPhieuKham"];
            TongCong = (int)row["TongCong"];
        }
        public int MaHoaDon { get; set; }
        public int MaPhieuKham { get; set; }
        public int TongCong { get; set; }
    }
}
