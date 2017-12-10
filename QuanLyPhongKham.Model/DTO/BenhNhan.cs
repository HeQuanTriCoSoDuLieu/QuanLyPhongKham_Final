using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class BenhNhan
    {
        public int MaBN { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DanToc { get; set; }
        public string SoCMND { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public string TienSu { get; set; }


        public BenhNhan() { }

        public BenhNhan(DataRow row)
        {
            this.MaBN = (int)row["MABN"];
            this.HoTen = row["HOTEN"].ToString();
            GioiTinh = (bool)row["GIOITINH"] ? "Nam" : "Nữ";
            DanToc = row["DANTOC"].ToString();
            this.NgaySinh = (DateTime) row["NGAYSINH"];
            NgaySinh = DateTime.ParseExact(NgaySinh.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            this.SoCMND = row["SOCMND"].ToString();
            this.DiaChi = row["DIACHI"].ToString();
            this.SoDT = row["SODT"].ToString();
            TienSu = row["TIENSU"].ToString();
        }
        
    }
    
}
