using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.UI_DTO
{
    public class DonThuocGUI
    {
        public DonThuocGUI(int maBn, string hoTen, string gioiTinh, string ngaySinh, decimal thanhTien, bool trangThai)
        {
            MaBN = maBn;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            ThanhTien = thanhTien;
            TrangThai = trangThai;
        }
        public DonThuocGUI(DataRow row)
        {
            MaBN = (int) row["MABN"];
            MaDonThuoc = (int)row["MADONTHUOC"];
            HoTen = row["HOTEN"].ToString();
            GioiTinh = (bool)row["GIOITINH"] == true ? "Nam" : "Nữ";
            NgaySinh = row["NGAYSINH"].ToString();
            ThanhTien = (decimal)row["TONGCONG"];
            TrangThai = (bool) row["TRANGTHAI"];
        }
        public int MaBN { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public decimal ThanhTien { get; set; }
        public bool TrangThai { get; set; }
        public int MaDonThuoc { get; set; }
    }
}
