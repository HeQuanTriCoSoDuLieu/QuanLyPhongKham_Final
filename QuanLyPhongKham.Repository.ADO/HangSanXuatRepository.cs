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
    public class HangSanXuatRepository : IHangSanXuatRepository
    {
        public List<HangSanXuat> DanhSachHangSanXuat()
        {
            DataTable table = DataProvider.Instane.ExecuteReader(" EXEC dbo.SP_DanhSachHangSanXuat");
            List<HangSanXuat> list = new List<HangSanXuat>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(new HangSanXuat(row));
            }

            return list;
        }
    }
}
