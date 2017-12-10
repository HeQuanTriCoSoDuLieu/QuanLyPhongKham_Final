using QuanLyPhongKham.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.Interfaces
{
    public interface IPhieuKhamRepository
    {
        List<PhieuKham_BenhNhanTimKiem> KetQuaTimPhieuKham(string ten,int manv);
        List<PhieuKham_BenhNhanChoKham> DanhSachChoKham(int manv,string date);
        List<PhieuKham_BenhNhanTimKiem> DanhSachPhieuKham(int manv);
        List<PhieuKham_BenhNhanLamSang> ThongTinPhieuKham();
        int LuuPhieuKham(PhieuKham_BenhNhanLamSang pkbn);
        List<PhieuKham_LichSuKham> LichSuKham(int mabn);
        List<PhieuKhamGUI> DanhSachPhieuKhamGUI(DateTime dateTime);
        bool InsertPhieuKham(PhieuKham phieuKham);
        void HuyKham(int maPhieuKham, int nhanvien);
        void CapNhatPhieuKham(PhieuKham phieuKham);
        int HoanThanhPhieuKham(int maphieu);




    }
}
