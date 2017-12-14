using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.DTO
{
    public class PhieuKham_BenhNhanLamSang
    {
        public int MaPhieuKham { get; set; }
        public int MaBN { get; set; }
        public int MaNV { get; set; }
        public string ChuanDoan { get; set; }
        public int MaHinhThucKham { get; set; }      
        public string NhipTim { get; set; }
        public string NhietDo { get; set; }
        public string HuyetAp { get; set; }
        public string CanNang { get; set; }
        public string ChieuCao { get; set; }
        public string MaICD { get; set; }
        public DateTime NgayKham { get; set; }
        public string HoanThanh { get; set; }
        public string DaThanhToan { get; set; }
        public string KetLuan { get; set; }
        public string TienSu { get; set; }

        public PhieuKham_BenhNhanLamSang() { }


        public PhieuKham_BenhNhanLamSang(int MaPhieuKham, int MaBN, int MaNV, string ChuanDoan, int MaHinhThucKham, string NhipTim, string NhietDo, string HuyetAp, string CanNang, string ChieuCao, string MaICD, DateTime NgayKham, string HoanThanh, string DaThanhToan, string KetLuan, string TienSu)
        {
            this.MaPhieuKham = MaPhieuKham;
            this.MaBN = MaBN;
            this.MaNV = MaNV;
            this.ChuanDoan = ChuanDoan;
            this.MaHinhThucKham = MaHinhThucKham;
            this.NhipTim = NhipTim;
            this.NhietDo = NhietDo;
            this.HuyetAp = HuyetAp;
            this.CanNang = CanNang;
            this.ChieuCao = ChieuCao;
            this.MaICD = MaICD;
            this.NgayKham = NgayKham;
            this.HoanThanh = HoanThanh;
            this.DaThanhToan = DaThanhToan;
            this.KetLuan = KetLuan;
            this.TienSu = TienSu;
        }

        public PhieuKham_BenhNhanLamSang(DataRow row)
        {
            this.MaPhieuKham = (int)row["MAPHIEUKHAM"];
            this.MaBN = (int)row["MABN"];
            this.MaNV = (int)row["MANV"];
            this.ChuanDoan = row["CHUANDOAN"].ToString();
            this.MaHinhThucKham = (int)row["MAHINHTHUCKHAM"];
            this.NhipTim = row["NHIPTIM"].ToString();
            this.NhietDo = row["NHIETDO"].ToString();
            this.HuyetAp = row["HUYETAP"].ToString();
            this.CanNang = row["CANNANG"].ToString();
            this.ChieuCao = row["CHIEUCAO"].ToString();
            this.MaICD = row["MAICD"].ToString();
            this.NgayKham = (DateTime)row["NGAYKHAM"];
            this.NgayKham = DateTime.ParseExact(NgayKham.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            this.HoanThanh = row["HOANTHANH"].ToString();
            this.DaThanhToan = row["DATHANHTOAN"].ToString();
            this.KetLuan = row["KETLUAN"].ToString();
            this.TienSu = row["TIENSU"].ToString();
        }
    }
}