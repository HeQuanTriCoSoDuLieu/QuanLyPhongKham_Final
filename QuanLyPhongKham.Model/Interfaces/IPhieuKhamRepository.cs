using QuanLyPhongKham.Model.DTO;
using QuanLyPhongKham.Model.UI_DTO.fTiepNhanBenhNhan;
using System;
using System.Collections.Generic;

namespace QuanLyPhongKham.Model.Interfaces
{
    public interface IPhieuKhamRepository
    {
        List<PhieuKham_BenhNhanTimKiem> KetQuaTimPhieuKham(string ten, int manv);

        List<PhieuKham_BenhNhanChoKham> DanhSachChoKham(int manv, string date);

        List<PhieuKham_BenhNhanTimKiem> DanhSachPhieuKham(int manv);

        

        List<PhieuKham_BenhNhanLamSang> ThongTinPhieuKham();
        int LuuPhieuKham(PhieuKham_BenhNhanLamSang pkbn);

        List<PhieuKham_LichSuKham> LichSuKham(int mabn);

        List<PhieuKhamGUI> DanhSachPhieuKhamGUI(DateTime dateTime);

        bool InsertPhieuKham(PhieuKham phieuKham);

        void HuyKham(int maPhieuKham, int nhanvien);

        void CapNhatPhieuKham(PhieuKham phieuKham);

        int HoanThanhPhieuKham(int maphieu);

        /// <summary>
        /// hàm lấy ra danh sách phiếu khám bởi một nhân viên
        /// </summary>
        /// <param name="id">mã nhân viên</param>
        /// <returns></returns>
        List<PhieuKhamGUI> LichSuTiepNhanByID(int id);

        /// <summary>
        /// tìm kiếm lich su tiep nhan
        /// </summary>
        /// <param name="column">cột dữ liệu trong db</param>
        /// <param name="value">dữ liệu cần tìm</param>
        /// <returns></returns>
        List<PhieuKhamGUI> TimKiemLichSuTiepNhan(int maNV,string column, string value);
    }
}