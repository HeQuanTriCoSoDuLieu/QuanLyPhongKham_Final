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
    public class LoaiThuocRepository : ILoaiThuocRepository
    {
        public List<LoaiThuoc> DanhSachLoaiThuoc()
        {
            DataTable table = DataProvider.Instane.ExecuteReader("EXEC dbo.SP_DanhSachLoaiThuoc ");
            List<LoaiThuoc> list = new List<LoaiThuoc>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(new LoaiThuoc(row));
            }
            return list;
        }
    }
}
