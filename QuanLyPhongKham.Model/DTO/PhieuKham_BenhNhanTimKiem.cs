using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class PhieuKham_BenhNhanTimKiem 
    {

        public int MaPhieuKham { get; set; }
        public string HOTEN { get; set; }
        public DateTime NgayKham { get; set; }
        public int HoanThanh { get; set; }
        public PhieuKham_BenhNhanTimKiem() { }

        public PhieuKham_BenhNhanTimKiem(int maphieukham,string ten, DateTime ngaykham, int hoanthanh)
        {
            MaPhieuKham = maphieukham;           
            HOTEN = ten;
            NgayKham = ngaykham;
            HoanThanh = hoanthanh;
        }

        public PhieuKham_BenhNhanTimKiem(DataRow row)
        {
            this.MaPhieuKham = (int)row["MAPHIEUKHAM"];
            this.HOTEN = row["HOTEN"].ToString();
            this.NgayKham =(DateTime) row["NGAYKHAM"];
            HoanThanh = (int)row["HOANTHANH"];
        }
    }
}
