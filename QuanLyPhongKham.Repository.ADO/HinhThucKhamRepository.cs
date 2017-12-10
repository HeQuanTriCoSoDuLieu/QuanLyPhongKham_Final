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
    public class HinhThucKhamRepository : IHinhThucKhamRepository
    {
        public List<HinhThucKham> DanhSachHinhThucKham()
        {
            List<HinhThucKham> list = new List<HinhThucKham>();

            DataTable table = DataProvider.Instane.ExecuteReader("EXEC dbo.SP_DanhSachHinhThucKham");

            foreach (DataRow row in table.Rows)
            {
                HinhThucKham hinhThucKham = new HinhThucKham(row);
                list.Add(hinhThucKham);
            }


            return list;
        }
    }
}
