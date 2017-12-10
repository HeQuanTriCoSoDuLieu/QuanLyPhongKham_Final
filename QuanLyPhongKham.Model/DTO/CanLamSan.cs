using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyPhongKham.Model.DTO
{
    public class CanLamSan
    {
        public int MaCLS { get; set; }
        public string TenCLS { get; set; }
        public decimal GiaTien { get; set; }
        public int MaLoaiCLS { get; set; }

        public CanLamSan() { }

        public CanLamSan(int macls, string tencls, decimal giatien, int maloaicls)
        {
            MaCLS = macls;
            TenCLS = tencls;
            GiaTien = giatien;
            MaLoaiCLS = maloaicls;
        }
        public CanLamSan(DataRow row)
        {
            MaCLS = (int)row["MACLS"];
            TenCLS = row["TENCLS"].ToString();
            GiaTien = (decimal)row["GIATIEN"];
            MaLoaiCLS = (int)row["MALOAICLS"];
        }
    }
}
