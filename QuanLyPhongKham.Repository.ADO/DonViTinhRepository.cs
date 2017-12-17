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
    public class DonViTinhRepository : IDonViTinhRepository
    {
        public List<DonViTinh> DanhSachDonViTinh()
        {
            DataTable table = DataProvider.Instane.ExecuteReader("EXEC dbo.SP_DanhSachDonViTinh");
            List<DonViTinh> list = new List<DonViTinh>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(new DonViTinh(row));
            }

            return list;
        }
    }
}
