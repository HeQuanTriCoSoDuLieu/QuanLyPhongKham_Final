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
    public class VatTuYTeRepository : IVatTuYTeRepository
    {
        public List<Vattuyte_DVT> DanhsachVTYT()
        {
            List<Vattuyte_DVT> list = new List<Vattuyte_DVT>();
            DataTable table = DataProvider.Instane.ExecuteReader("EXECUTE dbo.SP_Vattuyte_selectall");

            foreach (DataRow row in table.Rows)
            {
                list.Add(new Vattuyte_DVT(row));
            }
            return list;
        }

        public List<Vattuyte_DVT> TimkiemVTYT(String thongtin, String dulieu)
        {
            List<Vattuyte_DVT> list = new List<Vattuyte_DVT>();
            DataTable table = DataProvider.Instane.ExecuteReader("EXECUTE dbo.SP_Vattuyte_search @thongtin , @duLieu", new object[] { thongtin,dulieu });
            foreach (DataRow row in table.Rows)
            {
                list.Add(new Vattuyte_DVT(row));
            }
            return list;
        }
    }
}
