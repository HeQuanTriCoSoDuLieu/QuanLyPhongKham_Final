using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class ChiTietNhapVatTu
    {
        public ChiTietNhapVatTu() { }
        public ChiTietNhapVatTu (int mAPHIEUNHAP, int mAVTYT, int sOLUONG, int mANHSX, DateTime nGAYSX, DateTime nGAYHETHAN, int gIANHAP, int gIABANLE, int mANCC)
        {
            MaPhieuNhap = mAPHIEUNHAP;
            MaVTYT = mAVTYT;
            SoLuong = sOLUONG;
            MaNHSX = mANHSX;
            NgaySX = nGAYSX;
            NgayHetHan = nGAYHETHAN;
            GiaNhap = gIANHAP;
            GiaBanLe = GiaBanLe;
            MaNCC = mANCC;
        }
        public ChiTietNhapVatTu (DataRow row)
        {
            MaPhieuNhap = (int)row["MaPhieuNhap"];
            MaVTYT = (int)row["MaVTYT"];
            SoLuong = (int)row["SoLuong"];
            MaNHSX = (int)row["MaNHSX"];
            NgaySX = (DateTime)row["NgaySX"];
            NgayHetHan = (DateTime)row["NgayHetHan"];
            GiaNhap = (int)row["GiaNhap"];
            GiaBanLe = (int)row["GiaBanLe"];
            MaNCC = (int)row["MaNCC"];
        }

        public int MaPhieuNhap { get; set; }
        public int MaVTYT { get; set; }
        public int SoLuong { get; set; }
        public int MaNHSX { get; set; }
        public DateTime NgaySX { get; set; }
        public DateTime NgayHetHan { get; set; }
        public int GiaNhap { get; set; }
        public int GiaBanLe { get; set; }
        public int MaNCC { get; set; }

     
    }
}
