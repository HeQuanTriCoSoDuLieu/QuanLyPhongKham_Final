using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class QuocGia
    {
        public QuocGia() { }
        public QuocGia (int mAQUOCGIA, string tENQUOCGIA)
        {
            MaQuocGia = mAQUOCGIA;
            TenQuocGia = tENQUOCGIA;
        }
        public QuocGia (DataRow row)
        {
            MaQuocGia = (int)row["MaQuocGia"];
            TenQuocGia = row["TenQuocGia"].ToString();
        }

        public int MaQuocGia { get; set; }
        public string TenQuocGia { get; set; }

    }
}
