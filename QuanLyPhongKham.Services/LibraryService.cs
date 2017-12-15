using QuanLyPhongKham.Model.DTO;
using QuanLyPhongKham.Model.Interfaces;
using QuanLyPhongKham.Model.UI_DTO.fTiepNhanBenhNhan;
using System;
using System.Collections.Generic;
using System.Data;
using QuanLyPhongKham.Model.UI_DTO;

namespace QuanLyPhongKham.Services
{
    public class LibraryService :
        IBenhNhanRepository, ICanLamSanRepository, IChiTietCLSRepository,
        IChiTietDonThuocRepository, IChiTietNhapVatTuRepository,
        IChucDanhRepository, IChucVuRepository, IDichVuCLSRepository, IDonThuocRepository,
        IDonViTinhRepository, IHangSanXuatRepository, IHinhThucKhamRepository,
         IKhoaRepository, ILoaiCanLamSangRepository,
        ILoaiThuocRepository, INhaCungCapRepository, INhanVienRepository,
        IPhieuNhapRepository, IQuocGiaRepository, IChiTietNhapThuocRepository,
        ITaiKhoanRepository, IThuocRepository, IVatTuYTeRepository,
        IPhanQuyenRepository, IPhieuKhamRepository
    {
        #region Repositories

        private IBenhNhanRepository benhNhanRepository;
        private ICanLamSanRepository canLamSanRepository;
        private IChiTietCLSRepository chiTietCLSRepository;
        private IChiTietDonThuocRepository chiTietDonThuocRepository;
        private IChiTietNhapVatTuRepository chiTietNhapVatTuRepository;
        private IChiTietNhapThuocRepository chiTietNhapThuocRepository;
        private IChucDanhRepository chucDanhRepository;
        private IChucVuRepository chucVuRepository;
        private IDichVuCLSRepository dichVuCLSRepository;
        private IDonThuocRepository donThuocRepository;
        private IDonViTinhRepository donViTinhRepository;
        private IHangSanXuatRepository hangSanXuatRepository;
        private IHinhThucKhamRepository hinhThucKhamRepository;
        private IKhoaRepository khoaRepository;
        private ILoaiCanLamSangRepository loaiCanLamSanRepository;

        private ILoaiThuocRepository loaiThuocRepository;
        private INhaCungCapRepository nhaCungCapRepository;
        private INhanVienRepository nhanVienRepository;
        private IPhanQuyenRepository phanQuyenRepository;
        private IPhieuKhamRepository phieuKhamRepository;
        private IPhieuNhapRepository phieuNhapRepository;
        private IQuocGiaRepository quocGiaRepository;
        private ITaiKhoanRepository taiKhoanRepository;
        private IThuocRepository thuocRepository;
        private IVatTuYTeRepository vatTuYTeRepository;

        #endregion Repositories

        #region constructor

        internal LibraryService()
        {
        }

        internal LibraryService(IBenhNhanRepository benhNhanRepository, ICanLamSanRepository canLamSanRepository, IChiTietCLSRepository chiTietCLSRepository, IChiTietDonThuocRepository chiTietDonThuocRepository, IChiTietNhapVatTuRepository chiTietNhapVatTuRepository, IChiTietNhapThuocRepository chiTietNhapThuocRepository, IChucDanhRepository chucDanhRepository, IChucVuRepository chucVuRepository, IDichVuCLSRepository dichVuCLSRepository, IDonThuocRepository donThuocRepository, IDonViTinhRepository donViTinhRepository, IHangSanXuatRepository hangSanXuatRepository, IHinhThucKhamRepository hinhThucKhamRepository,  IKhoaRepository khoaRepository, ILoaiCanLamSangRepository loaiCanLamSanRepository, ILoaiThuocRepository loaiThuocRepository, INhaCungCapRepository nhaCungCapRepository, INhanVienRepository nhanVienRepository, IPhanQuyenRepository phanQuyenRepository, IPhieuKhamRepository phieuKhamRepository, IPhieuNhapRepository phieuNhapRepository, IQuocGiaRepository quocGiaRepository, ITaiKhoanRepository taiKhoanRepository, IThuocRepository thuocRepository, IVatTuYTeRepository vatTuYTeRepository)
        {
            this.benhNhanRepository = benhNhanRepository;
            this.canLamSanRepository = canLamSanRepository;
            this.chiTietCLSRepository = chiTietCLSRepository;
            this.chiTietDonThuocRepository = chiTietDonThuocRepository;
            this.chiTietNhapVatTuRepository = chiTietNhapVatTuRepository;
            this.chiTietNhapThuocRepository = chiTietNhapThuocRepository;
            this.chucDanhRepository = chucDanhRepository;
            this.chucVuRepository = chucVuRepository;
            this.dichVuCLSRepository = dichVuCLSRepository;
            this.donThuocRepository = donThuocRepository;
            this.donViTinhRepository = donViTinhRepository;
            this.hangSanXuatRepository = hangSanXuatRepository;
            this.hinhThucKhamRepository = hinhThucKhamRepository;
            this.khoaRepository = khoaRepository;
            this.loaiCanLamSanRepository = loaiCanLamSanRepository;
            this.loaiThuocRepository = loaiThuocRepository;
            this.nhaCungCapRepository = nhaCungCapRepository;
            this.nhanVienRepository = nhanVienRepository;
            this.phanQuyenRepository = phanQuyenRepository;
            this.phieuKhamRepository = phieuKhamRepository;
            this.phieuNhapRepository = phieuNhapRepository;
            this.quocGiaRepository = quocGiaRepository;
            this.taiKhoanRepository = taiKhoanRepository;
            this.thuocRepository = thuocRepository;
            this.vatTuYTeRepository = vatTuYTeRepository;
        }

        #endregion constructor

        #region Services cho tài khoản

        public DataTable Login(string userName, string passWord)
        {
            return taiKhoanRepository.Login(userName, passWord);
        }
        public int DoiMatKhau(string userName,string passWord, string newPassWord,int manv)
        {
            return taiKhoanRepository.DoiMatKhau(userName, passWord, newPassWord, manv);
        }

        #endregion Services cho tài khoản

        #region BenhNhanServices

        public List<BenhNhan> DanhSachBenhNhan()
        {
            return benhNhanRepository.DanhSachBenhNhan();
        }

        public List<BenhNhan> TimKiemBenhNhan(string col, string info)
        {
            return benhNhanRepository.TimKiemBenhNhan(col, info);
        }

        public bool ThemBenhNhan(BenhNhan benhNhan)
        {
            return benhNhanRepository.ThemBenhNhan(benhNhan);
        }

        public bool UpdateBenhNhan(BenhNhan benhNhan)
        {
            return benhNhanRepository.UpdateBenhNhan(benhNhan);
        }

        #endregion BenhNhanServices

        #region PhieuKhamServices

        /// <summary>
        /// load danh sach kham cho fTiepNhanBenhNhan
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public List<PhieuKhamGUI> DanhSachPhieuKhamGUI(DateTime dateTime)
        {
            return phieuKhamRepository.DanhSachPhieuKhamGUI(dateTime);
        }

        public bool InsertPhieuKham(PhieuKham phieuKham)
        {
            return phieuKhamRepository.InsertPhieuKham(phieuKham);
        }

        public void HuyKham(int maPhieuKham, int nhanVien)
        {
            phieuKhamRepository.HuyKham(maPhieuKham, nhanVien);
        }

        public void CapNhatPhieuKham(PhieuKham phieuKham)
        {
            phieuKhamRepository.CapNhatPhieuKham(phieuKham);
        }

        public List<PhieuKham_BenhNhanChoKham> DanhSachChoKham(int manv, string date)
        {
            return phieuKhamRepository.DanhSachChoKham(manv, date);
        }

        public List<PhieuKham_BenhNhanTimKiem> KetQuaTimPhieuKham(string ten, int manv)
        {
            return phieuKhamRepository.KetQuaTimPhieuKham(ten, manv);
        }
        public List<PhieuKham_BenhNhanLamSang> ThongTinPhieuKham()
        {
            return phieuKhamRepository.ThongTinPhieuKham();
        }

        public int LuuPhieuKham(PhieuKham_BenhNhanLamSang pkbn)
        {
            int row = phieuKhamRepository.LuuPhieuKham(pkbn);
            return row;
        }

        public List<PhieuKham_LichSuKham> LichSuKham(int mabn)
        {
            return phieuKhamRepository.LichSuKham(mabn);
        }

        public List<PhieuKham_BenhNhanTimKiem> DanhSachPhieuKham(int manv)
        {
            return phieuKhamRepository.DanhSachPhieuKham(manv);
        }

        public int HoanThanhPhieuKham(int maphieu)
        {
            return phieuKhamRepository.HoanThanhPhieuKham(maphieu);
        }

        public List<HinhThucKham> DanhSachHinhThucKham()
        {
            return hinhThucKhamRepository.DanhSachHinhThucKham();
        }

        public List<PhieuKhamGUI> LichSuTiepNhanByID(int id)
        {
            return phieuKhamRepository.LichSuTiepNhanByID(id);
        }

        public List<PhieuKhamGUI> TimKiemLichSuTiepNhan(int maNV, string column, string value)
        {
            return phieuKhamRepository.TimKiemLichSuTiepNhan(maNV,column,value);
        }

        #endregion PhieuKhamServices

        #region DonThuocServices

        public int ThemDonThuoc(DonThuoc donthuoc)
        {
            int row = donThuocRepository.ThemDonThuoc(donthuoc);
            return row;
        }

        public int TaoChiTietDonThuoc(ChiTietDonThuoc ctdt, int maphieu)
        {
            int row = chiTietDonThuocRepository.TaoChiTietDonThuoc(ctdt, maphieu);
            return row;
        }

        public List<ChiTietDonThuoc_Thuoc> DanhSachChiTietDonThuoc(int maphieu)
        {
            return chiTietDonThuocRepository.DanhSachChiTietDonThuoc(maphieu);
        }

        #endregion DonThuocServices

        #region CAN LAM SANG Services

        public List<CanLamSan> DanhSachLoaiCLS(int macls)
        {
            return canLamSanRepository.DanhSachLoaiCLS(macls);
        }

        public int InsertChiTietCLS(string getmaphieu, string getmacls, string link)
        {
            return chiTietCLSRepository.InsertChiTietCLS(getmaphieu, getmacls, link);
        }

        public DataTable GetCLS(string filePath)
        {
            return canLamSanRepository.GetCLS(filePath);
        }

        public ChiTietCLS LayketQua(string maphieu, string macls)
        {
            return chiTietCLSRepository.LayketQua(maphieu, macls);
        }

        #endregion CAN LAM SANG Services

        #region NhanVienServices

        public List<LichSuKham_NhanVien> LichSuKhamNhanVien(string col, string value, int manv)
        {
            return nhanVienRepository.LichSuKhamNhanVien(col, value, manv);
        }

        public List<LichSuKham_NhanVien> LichSuKhamNhanVien(int manv)
        {
            return nhanVienRepository.LichSuKhamNhanVien(manv);
        }

        public List<NhanVien> DanhSachNhanVien()
        {
            return nhanVienRepository.DanhSachNhanVien();
        }

        #endregion NhanVienServices

        #region form tìm kiếm thuốc

        public List<TimKiemThuoc> TimKiemThuoc(string timkiemthuoc, int timtheo, int loaithuoc)
        {
            return thuocRepository.TimKiemThuoc(timkiemthuoc, timtheo, loaithuoc);
        }

    

        #endregion form tìm kiếm thuốc

        #region VatTuYTeServices

        public List<Vattuyte_DVT> DanhsachVTYT()
        {
            return vatTuYTeRepository.DanhsachVTYT();
        }

        public List<Vattuyte_DVT> TimkiemVTYT(string thongtin, string dulieu)
        {
            return vatTuYTeRepository.TimkiemVTYT(thongtin, dulieu);
        }




        #endregion VatTuYTeServices

        #region ThuocServices

        //public List<Thuoc_Loaithuoc> Danhsachthuoc()
        //{
        //    return thuocRepository.Danhsachthuoc();
        //}

        //public List<Thuoc_Loaithuoc> Danhsachthuoc(string Thongtin, string Dulieu)
        //{
        //    return thuocRepository.Danhsachthuoc(Thongtin, Dulieu);
        //}






        #endregion ThuocServices


        #region Đơn thuốc
        public List<DonThuocGUI> DanhSachDonThuoc(DateTime date)
        {
            return donThuocRepository.DanhSachDonThuoc(date);
        }

        public bool ThuPhiDonThuoc(int maDonThuoc, int maNV)
        {
            return donThuocRepository.ThuPhiDonThuoc(maDonThuoc,maNV);
        }


        #endregion


        #region Dịch vụ CLS
        public List<DichVuCLSGUI> DanhSachDVCLS()
        {
            return dichVuCLSRepository.DanhSachDVCLS();
        }

        public bool ThuPhiCLS(int maNV, int maDV)
        {
            return dichVuCLSRepository.ThuPhiCLS(maNV,maDV);
        }


        #endregion


        #region Admin Thuốc
        public List<ThuocGUI> DanhSachThuoc()
        {
            return thuocRepository.DanhSachThuoc();
        }

        public List<ThuocGUI> TimKiemThuocAdmin(string column, string info)
        {
            return thuocRepository.TimKiemThuocAdmin(column, info);
        }

        public List<ChiTietThuocGUI> ChiTietThuoc(int maThuoc)
        {
            return thuocRepository.ChiTietThuoc(maThuoc);
        }

        public bool InsertThuoc(Thuoc thuoc)
        {
            return thuocRepository.InsertThuoc(thuoc);
        }

        #endregion
        #region DonViTinh
        public List<DonViTinh> DanhSachDonViTinh()
        {
            return donViTinhRepository.DanhSachDonViTinh();
        }
        #endregion


        #region LoaiThuoc
        public List<LoaiThuoc> DanhSachLoaiThuoc()
        {
            return loaiThuocRepository.DanhSachLoaiThuoc();
        }

        

        #endregion
    }
}