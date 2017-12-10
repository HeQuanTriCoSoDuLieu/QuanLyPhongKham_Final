using QuanLyPhongKham.Model.DTO;
using QuanLyPhongKham.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Repository.ADO
{
    public class ChiTietCLSRepository: IChiTietCLSRepository
    {

        public int InsertChiTietCLS(string getmaphieu, string getmacls, string link)
        {
            int result = DataProvider.Instane.ExecuteNonQuery("EXEC [dbo].[SP_INSERT_DICHVUCLS] @maphieu , @macls , @duongdan ", new object[] { getmaphieu, getmacls, link });
            return result;
        }

        public ChiTietCLS LayketQua(string maphieu, string macls)
        {
            ChiTietCLS cls = new ChiTietCLS();
            DataTable table = DataProvider.Instane.ExecuteReader("EXECUTE dbo.SP_LayKetQuaCLS @maphieu , @macls", new object[] { maphieu, macls });

            foreach (DataRow row in table.Rows)
            {
                cls = new ChiTietCLS(row);
            }
            return cls;
        }
    }
}
