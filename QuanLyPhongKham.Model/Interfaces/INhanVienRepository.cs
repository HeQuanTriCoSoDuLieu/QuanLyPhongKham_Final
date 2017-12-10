using QuanLyPhongKham.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.Interfaces
{
    public interface INhanVienRepository
    {
        /// <summary>
        /// Load danh sách nhân viên từ database lên
        /// </summary>
        /// <returns></returns>
        List<NhanVien> DanhSachNhanVien();
        List<LichSuKham_NhanVien> LichSuKhamNhanVien(string col, string value,int manv);
        List<LichSuKham_NhanVien> LichSuKhamNhanVien(int manv);
    }
}
