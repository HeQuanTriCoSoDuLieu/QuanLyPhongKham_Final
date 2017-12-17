using QuanLyPhongKham.Model.Interfaces;
using QuanLyPhongKham.Model.UI_DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyPhongKham.Repository.ADO
{
    public class DichVuCLSRepository : IDichVuCLSRepository
    {
        public List<DichVuCLSGUI> DanhSachDVCLS()
        {
            DataTable table = DataProvider.Instane.ExecuteReader("EXEC dbo.SP_DANHSACHDVCLS", null);
            List<DichVuCLSGUI> list = new List<DichVuCLSGUI>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(new DichVuCLSGUI(row));
            }
            return list;
        }

        public bool ThuPhiCLS(int maNV, int maDV)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXEC dbo.SP_THUPHIDVCLS @MADV , @MANV ", new object[] { maDV, maNV });
            return row > 0;
        }
    }
}