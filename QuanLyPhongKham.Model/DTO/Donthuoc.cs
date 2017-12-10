using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class DonThuoc
    {
        public DonThuoc() { }
        public DonThuoc(int madonthuoc, int maphieukham, decimal tongcong)
        {
            MADONTHUOC = madonthuoc;
            MAPHIEUKHAM = maphieukham;
            TONGCONG = tongcong;
        }
        public DonThuoc(DataRow row)
        {
            MADONTHUOC = (int)row["MADONTHUOC"];
            MAPHIEUKHAM = (int)row["MAPHIEUKHAM"];
            TONGCONG = (decimal)row["TONGCONG"];
        }
        public int MADONTHUOC { get; set; }
        public int MAPHIEUKHAM { get; set; }
        public decimal? TONGCONG { get; set; }
    }
}
