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
        }
        public int MADICHVUCLS { get; set; }
        public int MAPHIEUKHAM { get; set; }
        public decimal? TONGCONG { get; set; }
    }
}
