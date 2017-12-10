using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class CanLamSang
    {
        public int MaLoaiCLS { get; set; }
        public string TenLoai { get; set; }

        public CanLamSang()
        {
        }
        public CanLamSang(int MaLoaiCLS, string TenLoai)
        {
            this.MaLoaiCLS = MaLoaiCLS;
            this.TenLoai = TenLoai;
        }
        public CanLamSang (DataRow row)
        {
            this.MaLoaiCLS = (int)row["MALOAICLS"];
            this.TenLoai = row["TENLOAI"].ToString();
        }
    }
}
