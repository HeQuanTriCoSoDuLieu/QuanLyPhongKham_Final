using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class ChiTietDonThuoc
    {

        public ChiTietDonThuoc() { }
        public ChiTietDonThuoc(int madonthuoc, int mathuoc, int soluong, String huongdan)
        {
            MADONTHUOC = madonthuoc;
            MATHUOC = mathuoc;
            SOLUONG = soluong;
            HUONGDAN = huongdan;
        }
        public ChiTietDonThuoc(DataRow row)
        {
            MADONTHUOC = (int)row["MADONTHUOC"];
            MATHUOC = (int)row["MATHUOC"];
            SOLUONG = (int)row["SOLUONG"];
            HUONGDAN = row["HUONGDAN"].ToString();
        }
        public int STT { get; set; }
        public int MADONTHUOC { get; set; }
        public int MATHUOC { get; set; }
        public int SOLUONG { get; set; }
        public string HUONGDAN { get; set; }
    }
}
