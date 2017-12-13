using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.UI_DTO
{
   public  class DichVuCLSGUI
    {
        public DichVuCLSGUI(DataRow row)
        {
            MADVCLS = (int) row["MADICHVUCLS"];
            MaBN = (int)row["MABN"];
            HoTen = row["HOTEN"].ToString();
            GioiTinh = (bool)row["GIOITINH"] == true ? "Nam": "Nữ";
            NgaySinh = row["NGAYSINH"].ToString();
            TenDichVu = row["TENCLS"].ToString();
            TinhTrang = (bool)row["TINHTRANG"] == true ? "Đã thu" : "Chưa thu";
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            ThanhTien = double.Parse(row["TONGCONG"].ToString()).ToString("#,###", cul.NumberFormat);
            
        }

        public int MADVCLS  { get; set; }
        public int MaBN { get; set; }
        public string  HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string TenDichVu { get; set; }
        public string TinhTrang { get; set; }
        public string ThanhTien { get; set; }
    }
}
