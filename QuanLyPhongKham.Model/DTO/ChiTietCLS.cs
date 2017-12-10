using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class ChiTietCLS
    {
        public int MaDichVuCLS { get; set; }
        public int MaCLS { get; set; }
        public string KetQua { get; set; }
        public ChiTietCLS()
        {
        }
        public ChiTietCLS(int MaDichVuCLS, int MaCLS, string KetQua)
        {
            this.MaDichVuCLS = MaDichVuCLS;
            this.MaCLS = MaCLS;
            this.KetQua = KetQua;
        }
        public ChiTietCLS(DataRow row)
        {
            this.MaDichVuCLS = (int)row["MADICHVUCLS"];
            this.MaCLS = (int)row["MACLS"];
            this.KetQua = row["KETQUA"].ToString();
        }
    }
}
