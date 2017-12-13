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
            TinhTrang = (bool)row["TINHTRANG"]; //daty - 11/12
            NguoiThu = (int)row["NGUOITHU"]; //daty - 11/12
        }
        public int MADONTHUOC { get; set; }
        public int MAPHIEUKHAM { get; set; }
        public decimal? TONGCONG { get; set; }
        public bool TinhTrang { get; set; } // tình trạng của dịch vụ daty - 11/12
        public int NguoiThu { get; set; } // mã nhân viên thu tiền daty - 11/12
    }
}
