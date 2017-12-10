using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class ChucVu
    {
        public ChucVu() { }

        public ChucVu(int machucvu,string tenchucvu)
        {
            MaChucVu = machucvu;
            TenChucVu = tenchucvu;
        }

        public ChucVu(DataRow row)
        {
            MaChucVu = (int)row["MACHUCVU"];
            TenChucVu = row["TENCHUCVU"].ToString();
        }
        public int MaChucVu { get; set; }
        public string TenChucVu { get; set; }

    }
}
