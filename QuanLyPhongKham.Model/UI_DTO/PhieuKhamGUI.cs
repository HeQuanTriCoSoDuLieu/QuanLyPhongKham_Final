using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class PhieuKhamGUI
    {
        public PhieuKhamGUI(int maPhieuKham, string hoTen, string diaChi, string gioiTinh, DateTime ngaySinh, string chuanDoan, string hinhThucKham, string bacSi)
        {
            MaPhieuKham = maPhieuKham;
            HoTen = hoTen;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            ChuanDoan = chuanDoan;
            HinhThucKham = hinhThucKham;
            BacSi = bacSi;
        }

        public PhieuKhamGUI()
        {
        }



        public PhieuKhamGUI(DataRow row)
        {
            MaPhieuKham = (int)row["MAPHIEUKHAM"];
            HoTen = row["HOTEN"].ToString();
            DiaChi = row["DIACHI"].ToString();
            GioiTinh = (bool)row["GIOITINH"] == true ? "Nam" : "Nữ";
            NgaySinh = DateTime.ParseExact(row["NGAYSINH"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            ChuanDoan = row["CHUANDOAN"].ToString();
            HinhThucKham = row["TENHINHTHUCKHAM"].ToString();
            BacSi = row["BACSI"].ToString();
            SOCMND = row["SOCMND"].ToString();
            SoDT = row["SODT"].ToString();
            MaBN = (int) row["MaBN"];
        }




        public int MaPhieuKham { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string ChuanDoan { get; set; }
        public string HinhThucKham { get; set; }
        public string BacSi { get; set; }
        public int MaBN { get; set; }
        public string SOCMND { get; set; }
        public string SoDT { get; set; }

    }
}
