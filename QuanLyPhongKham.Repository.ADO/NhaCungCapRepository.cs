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
    public class NhaCungCapRepository : INhaCungCapRepository
    {
        public List<NhaCungCap> DanhSachNhaCungCap()
        {
            DataTable table = DataProvider.Instane.ExecuteReader(" EXEC dbo.SP_DanhSachNhaCungCap");

            List<NhaCungCap> list = new List<NhaCungCap>();

            foreach (DataRow row in table.Rows)
            {
                list.Add(new NhaCungCap(row));
            }

            return list;
        }
    }
}
