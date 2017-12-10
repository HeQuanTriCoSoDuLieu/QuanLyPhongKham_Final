using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class DanhSachKham
    {
        public DanhSachKham() { }
        public DanhSachKham(int mADSK, int mAPHIEUKHAM, DateTime nGAYKHAM, bool hOANTHANH)
        {
            MaDSK = mADSK;
            MaPhieuKham = mAPHIEUKHAM;
            NgayKham = nGAYKHAM;
            HoanThanh = hOANTHANH;
        }
        public DanhSachKham (DataRow row)
        {
            MaDSK = (int)row["MaDSK"];
            MaPhieuKham = (int)row["MaPhieuKham"];
            NgayKham = (DateTime)row["NgayKham"];
            HoanThanh = (bool)row["HoanThanh"];  
            
        }
        public int MaDSK { get; set; }
        public int MaPhieuKham { get; set; }
        public DateTime NgayKham { get; set; }
        public bool HoanThanh { get; set; }
    }
}
