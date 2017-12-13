using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class DonViTinh
    {
        public DonViTinh() { }
        public DonViTinh(int madvt, String tendvt)
        {
            MaDVT = madvt;
            TenDVT = tendvt;
        }
        public DonViTinh(DataRow row)
        {
            MaDVT = (int)row["MADVT"];
            TenDVT = row["TENDVT"].ToString();
        }
        public int MaDVT { get; set; }
        public string TenDVT { get; set; }
    }
}
