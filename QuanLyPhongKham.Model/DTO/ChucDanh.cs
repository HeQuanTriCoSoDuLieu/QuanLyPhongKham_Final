using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class ChucDanh
    {
        public ChucDanh() { }

        public ChucDanh(int machucdanh,string tenchucdanh)
        {
            MaChucDanh = machucdanh;
            TenChucDanh = tenchucdanh;
        }
        public ChucDanh(DataRow row)
        {
            MaChucDanh = (int)row["MACHUCDANH"];
            TenChucDanh = row["TENCHUCDANH"].ToString();
        }
        public int MaChucDanh { get; set; }
        public string TenChucDanh { get; set; }

    }
}
