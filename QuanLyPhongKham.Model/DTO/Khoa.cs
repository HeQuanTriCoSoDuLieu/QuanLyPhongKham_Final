using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class Khoa
    {
        public int MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public Khoa()
        {

        }
        public Khoa(int MaKhoa, string TenKhoa)
        {
            this.MaKhoa = MaKhoa;
            this.TenKhoa = TenKhoa;
        }
        public Khoa (DataRow row)
        {
            this.MaKhoa = (int)row["MAKHOA"];
            this.TenKhoa = row["TENKHOA"].ToString();
        }
    }
}
