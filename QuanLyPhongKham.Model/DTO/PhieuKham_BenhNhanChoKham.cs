using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class PhieuKham_BenhNhanChoKham
    {
        public int STT { get; set; }

        public int MaPhieuKham { get; set; }
        public string HOTEN { get; set; }
       public DateTime NgayKham { get; set; }
        
        public PhieuKham_BenhNhanChoKham() { }

        public PhieuKham_BenhNhanChoKham(int maphieukham,string ten, DateTime ngaykham)
        {
            MaPhieuKham = maphieukham;
          //  HoanThanh = hoanthanh;
            HOTEN = ten;
            NgayKham = ngaykham;
        }

        public PhieuKham_BenhNhanChoKham(DataRow row)
        {
            MaPhieuKham = (int)row["MAPHIEUKHAM"];
            HOTEN = row["HOTEN"].ToString();
            NgayKham = (DateTime)row["NGAYKHAM"];

        }
    }
}
