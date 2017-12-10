using QuanLyPhongKham.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongKham.Model.DTO;
using System.Data;

namespace QuanLyPhongKham.Repository.ADO
{
    public class PhieuKhamRepository : IPhieuKhamRepository
    {
        /// <summary>
        /// hàm load danh sách phiếu khám chưa hoàn thành cho fkhambenhnhan
        /// </summary>
        /// <param name="manv"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<PhieuKham_BenhNhanChoKham> DanhSachChoKham(int manv,string date)
        {
            List<PhieuKham_BenhNhanChoKham> list = new List<PhieuKham_BenhNhanChoKham>();

            DataTable table = DataProvider.Instane.ExecuteReader("EXECUTE dbo.SP_Select_Phieukham_Chokham @MANV , @NGKHAM", new object[] { manv, date});
            foreach (DataRow row in table.Rows)
            {
                list.Add(new PhieuKham_BenhNhanChoKham(row));
            }
            return list;
        }

        /// <summary>
        /// Hàm trả về table danh sach phiếu khám sau khi tìm kiếm
        /// </summary>
        /// <param name="ten"></param>
        /// <param name="manv"></param>
        /// <returns></returns>
        public List<PhieuKham_BenhNhanTimKiem> KetQuaTimPhieuKham(string ten, int manv)
        {
            List<PhieuKham_BenhNhanTimKiem> list = new List<PhieuKham_BenhNhanTimKiem>();
            DataTable table = DataProvider.Instane.ExecuteReader(" EXECUTE dbo.SP_Search_Phieukham_By_Ten @TEN , @MANV", new object[] { ten, manv });

            foreach (DataRow row in table.Rows)
            {
                list.Add(new PhieuKham_BenhNhanTimKiem(row));
            }
            return list;
        }

        /// <summary>
        /// Hàm lấy thông tin phiếu khám load lên form
        /// </summary>
        /// <param name="maphieu"></param>
        /// <returns></returns>
        public List<PhieuKham_BenhNhanLamSang> ThongTinPhieuKham()
        {
            List<PhieuKham_BenhNhanLamSang> listpk = new List<PhieuKham_BenhNhanLamSang>();
            DataTable table = DataProvider.Instane.ExecuteReader("EXECUTE dbo.SP_Search_All_Phieukham_BenhNhan ", new object[] {});

            foreach (DataRow row in table.Rows)
            {
                listpk.Add(new PhieuKham_BenhNhanLamSang(row));
            }
            return listpk;
        }

        /// <summary>
        /// Hàm lưu phiếu khám
        /// </summary>
        /// <param name="pkbn"></param>
        /// <returns></returns>
        public int LuuPhieuKham(PhieuKham_BenhNhanLamSang pkbn)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXECUTE dbo.SP_Update_Phieukham @MAPHIEUKHAM , @MABN , @CHUANDOAN , @NHIPTIM , @NHIETDO , @HUYETAP , @CANNANG , @CHIEUCAO , @MAICD , @NGAYKHAM , @KETLUAN , @TIENSU", new object[] { pkbn.MaPhieuKham, pkbn.MaBN, pkbn.ChuanDoan, pkbn.NhipTim, pkbn.NhietDo, pkbn.HuyetAp, pkbn.CanNang, pkbn.ChieuCao, pkbn.MaICD, pkbn.NgayKham, pkbn.KetLuan, pkbn.TienSu });
            return row;
        }

        /// <summary>
        /// Hàm trả về bảng lịch sử khám của bệnh nhân được chọn
        /// </summary>
        /// <param name="mabn"></param>
        /// <returns></returns>
        public List<PhieuKham_LichSuKham> LichSuKham(int mabn)
        {
            List<PhieuKham_LichSuKham> list = new List<PhieuKham_LichSuKham>();
            DataTable table = DataProvider.Instane.ExecuteReader(" EXECUTE dbo.SP_LichSuKham @MABN", new object[] { mabn });

            foreach (DataRow row in table.Rows)
            {
                list.Add(new PhieuKham_LichSuKham(row));
            }
            return list;
        }

        /// <summary>
        /// hàm load danh sách tất cả phiếu khám của nhân viên được chọn fkhambenhnhan
        /// </summary>
        /// <param name="manv"></param>
        /// <returns></returns>
        public List<PhieuKham_BenhNhanTimKiem> DanhSachPhieuKham(int manv)
        {
            List<PhieuKham_BenhNhanTimKiem> list = new List<PhieuKham_BenhNhanTimKiem>();
            DataTable table = DataProvider.Instane.ExecuteReader(" EXECUTE dbo.SP_Select_Phieukham_All @MANV", new object[] { manv });

            foreach (DataRow row in table.Rows)
            {
                list.Add(new PhieuKham_BenhNhanTimKiem(row));
            }
            return list;
        }

        /// <summary>
        /// Hàm set hoàn thành của phiếu khám thành 1
        /// </summary>
        /// <param name="maphieu"></param>
        /// <returns></returns>
        public int HoanThanhPhieuKham(int maphieu)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXECUTE dbo.SP_Update_HoanThanhPhieuKham  @MAPHIEU", new object[] { maphieu });
            return row;
        }


        /// <summary>
        /// hàm load danh sách phiếu khám cho fTiepNhanBenhNhan
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public List<PhieuKhamGUI> DanhSachPhieuKhamGUI(DateTime dateTime)
        {
            List<PhieuKhamGUI> list = new List<PhieuKhamGUI>();

            DataTable table = DataProvider.Instane.ExecuteReader("EXEC  dbo.SP_DanhSachKham_fKhamBenNhan @NgayKham ", new object[] { dateTime });

            foreach (DataRow row in table.Rows)
            {
                PhieuKhamGUI phieuKhamGUI = new PhieuKhamGUI(row);
                list.Add(phieuKhamGUI);
            }

            return list;
        }

        /// <summary>
        /// Tạo phiếu khám
        /// </summary>
        /// <param name="phieuKham"></param>
        /// <returns></returns>
        public bool InsertPhieuKham(PhieuKham phieuKham)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXEC dbo.InsertPhieuKham @MABN , @MANV , @NVTIEPNHAN , @CHUANDOAN , @MAHINHTHUCKHAM ", new object[] { phieuKham.MaBN, phieuKham.MaNV, phieuKham.NVTiepNhan, phieuKham.ChuanDoan, phieuKham.MaHinhThucKham });

            return row > 0;
        }

        /// <summary>
        /// Huỷ phiếu khám
        /// </summary>
        /// <param name="maPhieuKham"></param>
        /// <param name="nhanvien"></param>
        public void HuyKham(int maPhieuKham, int nhanvien)
        {
            DataProvider.Instane.ExecuteNonQuery("EXEC dbo.HuyKham @MAPHIEUKHAM , @nhanvien", new object[] { maPhieuKham, nhanvien });

        }

        /// <summary>
        /// Cập nhật phiếu khám
        /// </summary>
        /// <param name="phieuKham"></param>
        public void CapNhatPhieuKham(PhieuKham phieuKham)
        {

            DataProvider.Instane.ExecuteNonQuery("EXEC dbo.SP_UpdatePhieuKham @MAPHIEUKHAM , @MANV , @NVTIEPNHAN , @CHUANDOAN , @MAHINHTHUCKHAM", new object[] { phieuKham.MaPhieuKham, phieuKham.MaNV, phieuKham.NVTiepNhan, phieuKham.ChuanDoan, phieuKham.MaHinhThucKham });
        }

    }
}

