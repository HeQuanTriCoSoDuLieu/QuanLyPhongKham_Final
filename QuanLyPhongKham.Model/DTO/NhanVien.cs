using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class NhanVien
    {

        public NhanVien()
        {
        }

        public NhanVien(DataRow row)
        {
            MANV = (int)row["MANV"];
            HOTEN = row["HOTEN"].ToString();
            GIOITINH = (bool)row["GIOITINH"] == true ? "Nam" : "Nữ";
            SODT = row["SODT"].ToString();
            EMAIL = row["EMAIL"].ToString();
            MACHUCDANH = (int)row["MACHUCDANH"];
            MACHUCVU = (int)row["MACHUCVU"];
            LOAINHANVIEN = row["LOAINHANVIEN"].ToString();
        }

        public NhanVien(int mANV, string hOTEN, string gIOITINH, string sODT, string eMAIL, int kHOA, int mACHUCDANH, int mACHUCVU, string lOAINHANVIEN)
        {
            MANV = mANV;
            HOTEN = hOTEN;
            GIOITINH = gIOITINH;
            SODT = sODT;
            EMAIL = eMAIL;
            KHOA = kHOA;
            MACHUCDANH = mACHUCDANH;
            MACHUCVU = mACHUCVU;
            LOAINHANVIEN = lOAINHANVIEN;
        }

        public int MANV { get; set; }
        public string HOTEN { get; set; }
        public string GIOITINH { get; set; }
        public string SODT { get; set; }
        public string EMAIL { get; set; }
        public int KHOA { get; set; }
        public int MACHUCDANH { get; set; }
        public int MACHUCVU { get; set; }
        public string LOAINHANVIEN { get; set; }
    }
}
