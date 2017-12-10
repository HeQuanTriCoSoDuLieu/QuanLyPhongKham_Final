using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class HinhThucKham
    {
        public int MaHinhThucKham { get; set; }
        public string TenHinhThucKham { get; set; }

        public HinhThucKham()
        {
        }
        public HinhThucKham(int MaHinhThucKham, string TenHinhThucKham)
        {
            this.MaHinhThucKham = MaHinhThucKham;
            this.TenHinhThucKham = TenHinhThucKham;
        }
        public HinhThucKham (DataRow row)
        {
            this.MaHinhThucKham = (int)row["MAHINHTHUCKHAM"];
            this.TenHinhThucKham = row["TENHINHTHUCKHAM"].ToString();
        }
    }
}
