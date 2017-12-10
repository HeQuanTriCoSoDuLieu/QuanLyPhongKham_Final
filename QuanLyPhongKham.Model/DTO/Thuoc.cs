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
            MATHUOC = Mathuoc;
            TENTHUOC = Tenthuoc;
            DONVITINH = Donvitinh;
            LOAITHUOC = Loaithuoc;
            SOLUONGTON = Soluongton;
            GHICHU = Ghichu;
        }

        public Thuoc(DataRow row)
        {
            MATHUOC = (int)row["MATHUOC"];
            TENTHUOC = row["TENTHUOC"].ToString();
            DONVITINH = (int)row["DONVITINH"];
            LOAITHUOC = (int)row["LOAITHUOC"];
            SOLUONGTON = (int)row["SOLUONGTON"];
            GHICHU = row["GHICHU"].ToString();
        }

        public int MATHUOC { get; set; }
        public string TENTHUOC { get; set; }
        public int DONVITINH { get; set; }
        public int LOAITHUOC { get; set; }
        public int SOLUONGTON { get; set; }
        public string GHICHU { get; set; }
    }
}
