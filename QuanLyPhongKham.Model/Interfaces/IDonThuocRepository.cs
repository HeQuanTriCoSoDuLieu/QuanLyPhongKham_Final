using QuanLyPhongKham.Model.DTO;
using QuanLyPhongKham.Model.UI_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.Interfaces
{
    public interface IDonThuocRepository
    {
        int ThemDonThuoc(DonThuoc donthuoc);

        List<DonThuocGUI> DanhSachDonThuoc(DateTime date);
        bool ThuPhiDonThuoc(int maDonThuoc, int maNV);
    }
}
