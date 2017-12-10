using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class Thuoc_Loaithuoc
    {
        public Thuoc_Loaithuoc() { }

        public Thuoc_Loaithuoc(int Mathuoc, String Tenthuoc, string Tendonvitinh, string Tenloaithuoc, int Soluongton, String Ghichu)
        {
           this. MATHUOC = Mathuoc;
            TENTHUOC = Tenthuoc;
            TENDONVITINH = Tendonvitinh;
            TENLOAITHUOC = Tenloaithuoc;
            SOLUONGTON = Soluongton;
            GHICHU = Ghichu;
        }

        public Thuoc_Loaithuoc(DataRow row)
        {
            MATHUOC = (int)row["MATHUOC"];
            TENTHUOC = row["TENTHUOC"].ToString();
            TENDONVITINH = row["TENDVT"].ToString();
            TENLOAITHUOC = row["TENLOAI"].ToString();
            SOLUONGTON = (int)row["SOLUONGTON"];
            GHICHU = row["GHICHU"].ToString();
        }

        public int MATHUOC { get; set; }
        public string TENTHUOC { get; set; }
        public string TENDONVITINH { get; set; }
        public string TENLOAITHUOC { get; set; }
        public int SOLUONGTON { get; set; }
        public string GHICHU { get; set; }
    }
}
