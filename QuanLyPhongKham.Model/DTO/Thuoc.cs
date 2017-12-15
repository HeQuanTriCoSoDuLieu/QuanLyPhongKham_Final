using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class Thuoc
    {
        public Thuoc() { }

        public Thuoc(int Mathuoc, String Tenthuoc, int Donvitinh, int Loaithuoc, int Soluongton, String Ghichu)
        {
            MaThuoc = Mathuoc;
            TenThuoc = Tenthuoc;
            DonViTinh = Donvitinh;
            LoaiThuoc = Loaithuoc;
            SoLuongTon = Soluongton;
            GhiChu = Ghichu;
        }

        public Thuoc(DataRow row)
        {
            MaThuoc = (int)row["MATHUOC"];
            TenThuoc = row["TENTHUOC"].ToString();
            DonViTinh = (int)row["DONVITINH"];
            LoaiThuoc = (int)row["LOAITHUOC"];
            SoLuongTon = (int)row["SOLUONGTON"];
            GhiChu = row["GHICHU"].ToString();
        }

        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public int DonViTinh { get; set; }
        public int LoaiThuoc { get; set; }
        public int SoLuongTon { get; set; }
        public string GhiChu { get; set; }
    }
}
