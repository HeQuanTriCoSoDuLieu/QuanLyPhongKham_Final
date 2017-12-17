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
    public class PhieuNhapRepository : IPhieuNhapRepository
    {
        public PhieuNhap InsertPhieuNhap(int maNV)
        {
            DataTable table = DataProvider.Instane.ExecuteReader("EXEC dbo.SP_InsertPhieuNhapThuoc @manv", new object[] {maNV });
            PhieuNhap phieuNhap = null;
            if (table.Rows.Count>0)
            {
                foreach (DataRow row in table.Rows)
                {
                    phieuNhap = new PhieuNhap(row);
                }
            }
            
            return phieuNhap;
        }
    }
}
