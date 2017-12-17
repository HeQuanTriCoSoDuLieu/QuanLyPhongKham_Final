using QuanLyPhongKham.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongKham.Model.DTO;

namespace QuanLyPhongKham.Repository.ADO
{
    public class ChiTietNhapThuocRepository : IChiTietNhapThuocRepository
    {
        public bool InsertChiTietPhieuNhapThuoc(ChiTietPhieuNhapThuoc ctpn)
        {
            int row = DataProvider.Instane.ExecuteNonQuery(" EXEC dbo.SP_InsertChiTietPhieuNhapThuoc @MaPhieuNhap ,      @MaThuoc ,      @SoLuong ,  @NgayHetHan ,  @NgaySanXuat , @GiaNhap , @GiaBanLe ,  @MaHSX ,   @MaNhaCC  ", new object[] {
                ctpn.MaPhieuNhap,ctpn.MaThuoc,ctpn.SoLuong,ctpn.NgayHetHan.ToString("yyyy-MM-dd"),ctpn.NgaySX.ToString("yyyy-MM-dd"),ctpn.GiaNhap,ctpn.GiaBanLe,ctpn.MaHSX,ctpn.MaNhaCC   
            });
            return row > 0;
        }
    }
}
