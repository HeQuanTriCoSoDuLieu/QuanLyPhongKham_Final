using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class ChiTietDonThuoc_Thuoc
    {


        public ChiTietDonThuoc_Thuoc(DataRow row)
        {
            this.MATHUOC = (int)row["MATHUOC"];
            this.TENTHUOC = row["TENTHUOC"].ToString();
            this.SOLUONG = (int)row["SOLUONG"];
            this.HUONGDAN = row["HUONGDAN"].ToString();
        }

        public ChiTietDonThuoc_Thuoc() { }
        public ChiTietDonThuoc_Thuoc(int stt, int mathuoc, string tenthuoc, int soluong, string huongdan)
        {
            this.STT = stt;
            this.MATHUOC = mathuoc;
            this.TENTHUOC = tenthuoc;
            this.SOLUONG = soluong;
            this.HUONGDAN = huongdan;
        }

        public int STT { get; set; }
        public int MATHUOC { get; set; }
        public string  TENTHUOC { get; set; }
        public int SOLUONG { get; set; }
        public string HUONGDAN { get; set; }
    }
}
