using System.Data;

namespace QuanLyPhongKham.Model.DTO
{
    public class LoaiThuoc
    {
        public LoaiThuoc(int maLoaiThuoc, string tenLoaiThuoc)
        {
            MaLoaiThuoc = maLoaiThuoc;
            TenLoaiThuoc = tenLoaiThuoc;
        }

        public LoaiThuoc(DataRow row)
        {
            MaLoaiThuoc = (int)row["MALOAITHUOC"];
            TenLoaiThuoc = row["TENLOAI"].ToString();
        }

        public int MaLoaiThuoc { get; set; }
        public string TenLoaiThuoc { get; set; }
    }
}