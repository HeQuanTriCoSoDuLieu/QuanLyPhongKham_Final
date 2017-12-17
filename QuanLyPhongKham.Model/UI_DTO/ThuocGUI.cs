using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.UI_DTO
{
    public class ThuocGUI
    {
        public ThuocGUI(DataRow row)
        {
            MaThuoc = (int) row["MATHUOC"];
            TenThuoc = row["TENTHUOC"].ToString();
            SoLuongTon = (int)row["SOLUONGTON"];
            DonViTinh = row["TENDVT"].ToString();
            LoaiThuoc = row["TENLOAI"].ToString();
        }

        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public int SoLuongTon { get; set; }
        public string DonViTinh { get; set; }
        public string LoaiThuoc { get; set; }
    }

}
