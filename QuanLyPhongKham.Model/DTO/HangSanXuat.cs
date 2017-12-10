using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class HangSanXuat
    {
        public HangSanXuat() { }
        public HangSanXuat(int mAHSX, string tENHSX, string dIACHI, int mAQUOCGIA)
        {
            MaHSX = mAHSX;
            TenHSX = tENHSX;
            DiaChi = dIACHI;
            MaQuocGia = mAQUOCGIA;
        }
        public HangSanXuat(DataRow row)
        {
            MaHSX = (int)row["MaHSX"];
            TenHSX = row["TenHSX"].ToString();
            DiaChi = row["DiaChi"].ToString();
            MaQuocGia = (int)row["MaQuocGia"];
        }
        public int MaHSX { get; set; }
        public string TenHSX { get; set; }
        public string DiaChi { get; set; }
        public int MaQuocGia { get; set; }
    }
}
