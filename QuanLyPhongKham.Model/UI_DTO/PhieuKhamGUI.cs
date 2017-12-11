using System;
using System.Data;
using System.Globalization;

namespace QuanLyPhongKham.Model.UI_DTO.fTiepNhanBenhNhan
{
    public class PhieuKhamGUI
    {
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
            MaBN = (int)row["MaBN"];
            DanToc = row["DANTOC"].ToString();
            NgayKham = DateTime.ParseExact(row["NGAYKHAM"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            KetLuan = row["KETLUAN"].ToString();
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
        public string DanToc { get; set; }
        public DateTime NgayKham { get; set; }
        public string KetLuan { get; set; }
    }
}