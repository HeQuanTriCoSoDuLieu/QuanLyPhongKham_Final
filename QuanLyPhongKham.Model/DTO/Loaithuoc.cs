using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class LoaiThuoc
    {
        public LoaiThuoc() { }

        public LoaiThuoc(int madvt, String tendvt)
        {
            MADVT = madvt;
            TENDVT = tendvt;
        }
        public LoaiThuoc(DataRow row)
        {
            MADVT = (int)row["MADVT"];
            TENDVT = row["TENDVT"].ToString();
        }

        public int MADVT { get; set; }
        public string TENDVT { get; set; }
    }
}
