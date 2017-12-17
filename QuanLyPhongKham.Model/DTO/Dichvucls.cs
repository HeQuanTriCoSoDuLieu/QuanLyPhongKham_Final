using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class DichVuCLS
    {
        public DichVuCLS() { }
        public DichVuCLS (int madichvucls, int maphieukham, decimal tongcong)
        {
            MADICHVUCLS = madichvucls;
            MAPHIEUKHAM = maphieukham;
            TONGCONG = tongcong;
        }
        public DichVuCLS(DataRow row)
        {
            MADICHVUCLS = (int)row["MADICHVUCLS"];
            MAPHIEUKHAM = (int)row["MAPHIEUKHAM"];
            TONGCONG = (decimal)row["TONGCONG"];
            TinhTrang = (bool)row["TINHTRANG"]; //daty - 11/12
            NguoiThu = (int)row["NGUOITHU"]; //daty - 11/12
        }
        public int MADICHVUCLS { get; set; }
        public int MAPHIEUKHAM { get; set; }
        public bool TinhTrang { get; set; } // tình trạng của dịch vụ daty - 11/12
        public int NguoiThu { get; set; } // mã nhân viên thu tiền daty - 11/12
        public decimal? TONGCONG { get; set; }
    }
}
