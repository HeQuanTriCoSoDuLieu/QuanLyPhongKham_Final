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
    public class ChiTietDonThuocRepository : IChiTietDonThuocRepository
    {
        public List<ChiTietDonThuoc_Thuoc> DanhSachChiTietDonThuoc(int maphieu)
        {
            List<ChiTietDonThuoc_Thuoc> list = new List<ChiTietDonThuoc_Thuoc>();

            DataTable table = DataProvider.Instane.ExecuteReader("EXECUTE dbo.SP_DanhSachChiTietDonThuoc @MAPHIEU",new object[] {maphieu});



            foreach (DataRow row in table.Rows)
            {
                list.Add(new ChiTietDonThuoc_Thuoc(row));
            }
            return list;
        }

        public int TaoChiTietDonThuoc(ChiTietDonThuoc ctdt,int maphieu)
        {
            int row = DataProvider.Instane.ExecuteNonQuery("EXECUTE dbo.SP_Insert_ChiTietDonThuoc @MAPHIEUKHAM , @MATHUOC , @SOLUONG , @HUONGDAN", new object[] { maphieu, ctdt.MATHUOC, ctdt.SOLUONG,ctdt.HUONGDAN });
            return row;
        }
    }
}
