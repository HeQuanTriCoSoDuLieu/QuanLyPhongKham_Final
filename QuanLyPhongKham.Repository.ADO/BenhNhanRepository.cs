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
    public class BenhNhanRepository : IBenhNhanRepository
    {

        /// <summary>
        /// lấy danh sách bệnh nhân trong database
        /// </summary>
        /// <returns></returns>
        public List<BenhNhan> DanhSachBenhNhan()
        {
            List<BenhNhan> list = new List<BenhNhan>();

            DataTable table = DataProvider.Instane.ExecuteReader("EXECUTE dbo.SP_DanhSachBenhNhan");



            foreach (DataRow row in table.Rows)
            {
                list.Add(new BenhNhan(row));
            }
            return list;
        }


        /// <summary>
        /// thêm bệnh nhân vào database
        /// </summary>
        /// <param name="benhNhan"></param>
        /// <returns></returns>
        public bool ThemBenhNhan(BenhNhan benhNhan)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXEC dbo.SP_InsertBenhNhan @HOTEN , @GIOITINH ," +
                                        " @NGAYSINH , @DANTOC , @SOCMND , @DIACHI ,  @SODT , @TIENSU ",
                                        new object[] { benhNhan.HoTen, benhNhan.GioiTinh.Equals("Nam")?1:0, benhNhan.NgaySinh,
                          benhNhan.DanToc, benhNhan.SoCMND, benhNhan.DiaChi, benhNhan.SoDT, benhNhan.TienSu });
            return row > 0;
        }


        /// <summary>
        /// tìm kiếm bệnh nhân, sử dụng SP_TimKiemBenhNhan
        /// </summary>
        /// <param name="col">cột trong database</param>
        /// <param name="info">thông tin cần tìm</param>
        /// <returns></returns>
        public List<BenhNhan> TimKiemBenhNhan(string col, string info)
        {
            List<BenhNhan> list = new List<BenhNhan>();
            DataTable table = DataProvider.Instane.ExecuteReader(" EXEC  dbo.SP_TimKiemBenhNhan_fTIepNhanBenhNhan  @TruongDuLieu , @ThongTin ", new object[] { col ,info  });

            foreach (DataRow row in table.Rows)
            {
                list.Add(new BenhNhan(row));
            }
            return list;
        }

        /// <summary>
        /// Cập nhật thông tin cho bệnh nhân
        /// </summary>
        /// <param name="benhNhan"></param>
        /// <returns></returns>
        public bool UpdateBenhNhan(BenhNhan benhNhan)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXEC dbo.SP_UpdateBenhNhan @MABN , @HOTEN , @GIOITINH , @NGAYSINH , @DANTOC , @SOCMND , @DIACHI , @SODT , @TIENSU ",
                          new object[] { benhNhan.MaBN, benhNhan.HoTen, benhNhan.GioiTinh.Equals("Nam")?1:0, benhNhan.NgaySinh,
                          benhNhan.DanToc, benhNhan.SoCMND, benhNhan.DiaChi, benhNhan.SoDT, benhNhan.TienSu });
            return row > 0;
        }
    }
}
