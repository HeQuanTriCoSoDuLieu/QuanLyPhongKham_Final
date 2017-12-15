using QuanLyPhongKham.Model.DTO;
using QuanLyPhongKham.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongKham.Model.UI_DTO;

namespace QuanLyPhongKham.Repository.ADO
{
    public class ThuocRepository : IThuocRepository
    {
        public List<ChiTietThuocGUI> ChiTietThuoc(int maThuoc)
        {
            DataTable table = DataProvider.Instane.ExecuteReader("EXEC dbo.SP_ChiTietThuoc @mathuoc", new object[] { maThuoc});

            List<ChiTietThuocGUI> list = new List<ChiTietThuocGUI>();

            foreach (DataRow row in table.Rows)
            {
                list.Add(new ChiTietThuocGUI(row));
            }

            return list;


        }

        public List<ThuocGUI> DanhSachThuoc()
        {
            List<ThuocGUI> list = new List<ThuocGUI>();

            DataTable table = DataProvider.Instane.ExecuteReader("EXEC dbo.SP_DanhSachThuoc",null);
            foreach (DataRow row in table.Rows)
            {
                list.Add(new ThuocGUI(row));
            }
            return list;

        }

        public bool InsertThuoc(Thuoc thuoc)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXEC dbo.SP_InserThuoc @TenThuoc , @LoaiThuoc , @DonViTinh , @SoLuongTon , @GhiChu ", new object[] {thuoc.TenThuoc, thuoc.LoaiThuoc, thuoc.DonViTinh, thuoc.SoLuongTon, thuoc.GhiChu });
            return row > 0;
        }

        public List<TimKiemThuoc> TimKiemThuoc(string timkiemthuoc, int timtheo, int loaithuoc)
        {
            List<TimKiemThuoc> list = new List<TimKiemThuoc>();
            DataTable table = DataProvider.Instane.ExecuteReader("EXEC dbo.SP_timkiemthuoc @timkiemthuoc , @timtheo , @loaithuoc ", new object[] { timkiemthuoc, timtheo, loaithuoc });

            foreach (DataRow row in table.Rows)
            {
                list.Add(new TimKiemThuoc(row));
            }
            return list;
        }

        public List<ThuocGUI> TimKiemThuocAdmin(string column, string info)
        {
            DataTable table = DataProvider.Instane.ExecuteReader("EXEC dbo.SP_Admin_TimKiemThuoc @info ,  @column ",new object[] { info,column});
            List<ThuocGUI> list = new List<ThuocGUI>();
            foreach (DataRow item in table.Rows)
            {
                list.Add(new ThuocGUI(item));
            }
            return list;
        }
    }
}
