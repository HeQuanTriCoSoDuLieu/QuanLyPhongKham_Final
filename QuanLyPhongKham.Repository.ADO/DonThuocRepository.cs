using QuanLyPhongKham.Model.DTO;
using QuanLyPhongKham.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongKham.Model.UI_DTO;
using System.Data;

namespace QuanLyPhongKham.Repository.ADO
{
    public class DonThuocRepository : IDonThuocRepository
    {
        public List<DonThuocGUI> DanhSachDonThuoc(DateTime date)
        {
            string strDate = string.Format("{0}-{1}-{2}", date.Year,date.Month,date.Day);
            DataTable table = DataProvider.Instane.ExecuteReader("dbo.SP_DANHSACHDONTHUOC @NGAYKHAM ", new object[] { strDate });
            List<DonThuocGUI> list = new List<DonThuocGUI>();
            foreach (DataRow row in table.Rows)
            {
                DonThuocGUI donThuocGUI = new DonThuocGUI(row);
                list.Add(donThuocGUI);
            }
            return list;


        }

        public int ThemDonThuoc(DonThuoc DonThuoc)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXECUTE dbo.SP_Insert_DonThuoc @MAPHIEUKHAM", new object[] { DonThuoc.MAPHIEUKHAM } );
            return row;
        }

        public bool ThuPhiDonThuoc(int maDonThuoc, int maNV)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXEC dbo.SP_THUPHIDONTHUOC  @MADONTHUOC , @MANV  ", new object[] { maDonThuoc, maNV });
            return row > 0;
        }
    }
}
