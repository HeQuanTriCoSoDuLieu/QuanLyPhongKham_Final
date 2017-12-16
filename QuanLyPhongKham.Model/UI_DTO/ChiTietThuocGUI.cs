using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.UI_DTO
{
    public class ChiTietThuocGUI
    {
        public ChiTietThuocGUI(DataRow row)
        {
            MaThuoc = (int) row["MATHUOC"];
            TenThuoc = row["TENTHUOC"].ToString();
            MaPhieu = (int)row["MAPHIEUNHAP"];
            SoLuong = (int)row["SOLUONG"];
            NgayNhap = row["NGAYNHAP"].ToString();
            NgaySX = row["NGAYSX"].ToString();
            NgayHH = row["NGAYHETHAN"].ToString();
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            //ThanhTien = double.Parse(row["TONGCONG"].ToString()).ToString("#,###", cul.NumberFormat);
            GiaNhap = double.Parse(row["GIANHAP"].ToString()).ToString("#,###", cul.NumberFormat);
            GiaBanLe = double.Parse(row["GIABANLE"].ToString()).ToString("#,###", cul.NumberFormat);
            TenHSX = row["TENHSX"].ToString();
            TenNhaCC = row["TENNHACC"].ToString();
        }

        public ChiTietThuocGUI(int maThuoc, string tenThuoc, int maPhieu, int soLuong, string ngayNhap, string ngaySX, string ngayHH, string giaNhap, string giaBanLe, string tenHSX, string tenNhaCC)
        {
            MaThuoc = maThuoc;
            TenThuoc = tenThuoc;
            MaPhieu = maPhieu;
            SoLuong = soLuong;
            NgayNhap = ngayNhap;
            NgaySX = ngaySX;
            NgayHH = ngayHH;
            GiaNhap = giaNhap;
            GiaBanLe = giaBanLe;
            TenHSX = tenHSX;
            TenNhaCC = tenNhaCC;
        }

        public ChiTietThuocGUI()
        {
        }

        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public int MaPhieu { get; set; }
        public int SoLuong { get; set; }
        public string NgayNhap { get; set; }
        public string NgaySX { get; set; }
        public string NgayHH { get; set; }
        public string GiaNhap { get; set; }
        public string GiaBanLe { get; set; }
        public string TenHSX { get; set; }
        public string TenNhaCC { get; set; }
        public DateTime dtNgaySX { get; set; }
        public DateTime dtNgayHH { get; set; }
        public int MaHSX { get; set; }
        public int MaNhaCC { get; set; }
    }
}
