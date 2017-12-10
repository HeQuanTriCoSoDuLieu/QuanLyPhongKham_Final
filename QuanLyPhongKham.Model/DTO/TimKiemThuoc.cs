using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class TimKiemThuoc
    {
        public TimKiemThuoc() { }

        public TimKiemThuoc(int Mathuoc, String Tenthuoc, string Tendvt, string Tenloai, int Soluongton)
        {
            MATHUOC = Mathuoc;
            TENTHUOC = Tenthuoc;
            TENDVT = Tendvt;
            TENLOAI = Tenloai;
            SOLUONGTON = Soluongton;

        }

        public TimKiemThuoc(DataRow row)
        {
            MATHUOC = (int)row["MATHUOC"];
            TENTHUOC = row["TENTHUOC"].ToString();
            TENDVT = row["TENDVT"].ToString();
            TENLOAI = row["TENLOAI"].ToString();
            SOLUONGTON = (int)row["SOLUONGTON"];

        }

        public int MATHUOC { get; set; }
        public string TENTHUOC { get; set; }
        public string TENDVT { get; set; }
        public string TENLOAI { get; set; }
        public int SOLUONGTON { get; set; }
    }
}
