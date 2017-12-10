using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Services
{
    public class ServiceFactory
    {
        public static LibraryService GetLibraryService(string persistanceStrategry)
        {
            LibraryService libraryService = null;
            if (persistanceStrategry == "ADO")
            {
                libraryService = new LibraryService(
                                                    new QuanLyPhongKham.Repository.ADO.BenhNhanRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.CanLamSanRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.ChiTietCLSRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.ChiTietDonThuocRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.ChiTietNhapVatTuRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.ChiTietNhapThuocRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.ChucDanhRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.ChucVuRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.DichVuCLSRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.DonThuocRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.DonViTinhRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.HangSanXuatRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.HinhThucKhamRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.HoaDonRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.KhoaRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.LoaiCanLamSangRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.LoaiThuocRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.NhaCungCapRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.NhanVienRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.PhanQuyenRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.PhieuKhamRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.PhieuNhapRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.QuocGiaRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.TaiKhoanRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.ThuocRepository(),
                                                    new QuanLyPhongKham.Repository.ADO.VatTuYTeRepository()
                                                    );
            }
            //else
            //{
            //    libraryService = new LibraryService(new QuanLyPhongKham.Repository.EF.TaiKhoanRepository());
            //}
            return libraryService;
        }
    }
}
