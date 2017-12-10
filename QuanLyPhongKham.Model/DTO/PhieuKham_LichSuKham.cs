using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class PhieuKham_LichSuKham
    {
        public int STT { get; set; }
        public int MaPhieuKham { get; set; }
        public DateTime NgayKham { get; set; }
        public string ChuanDoan { get; set; }
        public string KetLuan { get; set; }

        public PhieuKham_LichSuKham() { }


        public PhieuKham_LichSuKham(int MaPhieuKham, DateTime NgayKham, string ChuanDoan, string KetLuan)
        {
            this.MaPhieuKham = MaPhieuKham;
            this.ChuanDoan = ChuanDoan;
            this.NgayKham = NgayKham;
            this.KetLuan = KetLuan;
        }

        public PhieuKham_LichSuKham(DataRow row)
        {
            this.MaPhieuKham = (int)row["MAPHIEUKHAM"];
            this.NgayKham = (DateTime)row["NGAYKHAM"];
            this.ChuanDoan = row["CHUANDOAN"].ToString();
            this.KetLuan = row["KETLUAN"].ToString();

        }

    }
}