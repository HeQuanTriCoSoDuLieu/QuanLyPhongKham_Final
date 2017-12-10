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
    public class NhanVienRepository : INhanVienRepository
    {
        public List<LichSuKham_NhanVien> LichSuKhamNhanVien(int manv)
        {
            List<LichSuKham_NhanVien> list = new List<LichSuKham_NhanVien>();
            DataTable table = DataProvider.Instane.ExecuteReader("EXEC dbo.SP_LichSuKhamNhanVien @MaNhanVien", new object[] { manv });

            foreach (DataRow row in table.Rows)
            {
                list.Add(new LichSuKham_NhanVien(row));
            }
            return list;
        }

        public List<LichSuKham_NhanVien> LichSuKhamNhanVien(string cot,string value, int manv)
        {
            List<LichSuKham_NhanVien> list = new List<LichSuKham_NhanVien>();        
            DataTable table = DataProvider.Instane.ExecuteReader("EXEC dbo.SP_TimKiemLichSuKhamNhanVien @ThongTin , @DuLieu , @MaNhanVien  ", new object[] { cot, value, manv });
            foreach (DataRow row in table.Rows)
            {
                list.Add(new LichSuKham_NhanVien(row));
            }
            return list;
        }


        /// <summary>
        /// dùng cho ftiepnhanbenhnhan
        /// </summary>
        /// <returns></returns>
        public List<NhanVien> DanhSachNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            DataTable table = DataProvider.Instane.ExecuteReader(" EXEC dbo.SP_DanhSachNhanVien");
            foreach (DataRow row in table.Rows)
            {
                NhanVien nhanVien = new NhanVien(row);
                list.Add(nhanVien);
            }
            return list;
        }
    }
}
