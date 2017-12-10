using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class NhaCungCap
    {
        public NhaCungCap() { }

        public NhaCungCap(int manhacc,string tennhacc,string diachi,string sodt,string email,int maquocgia)
        {
            MaNhaCC = manhacc;
            TenNhaCC = tennhacc;
            DiaChi = diachi;
            SoDT = sodt;
            Email = email;
            MaQuocGia = maquocgia;
        }
        public NhaCungCap(DataRow row)
        {
            MaNhaCC = (int)row["MANHACC"];
            TenNhaCC = row["TENNHACC"].ToString();
            DiaChi = row["DIACHI"].ToString();
            SoDT = row["SODT"].ToString();
            Email = row["EMAIL"].ToString();
            MaQuocGia = (int)row["MAQUOCGIA"];
        }

        public int MaNhaCC { get; set; }
        public string TenNhaCC { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public string Email { get; set; }
        public int MaQuocGia { get; set; }
    }
}
