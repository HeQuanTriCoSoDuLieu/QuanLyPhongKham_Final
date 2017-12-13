using QuanLyPhongKham.Model.UI_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.Interfaces
{
    public interface IDichVuCLSRepository
    {
        List<DichVuCLSGUI> DanhSachDVCLS();
        bool ThuPhiCLS(int maNV, int maDV);
    }
}
