using QuanLyPhongKham.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.Interfaces
{
    public interface IChiTietDonThuocRepository
    {
        int TaoChiTietDonThuoc(ChiTietDonThuoc ctdt, int maphieu);
        List<ChiTietDonThuoc_Thuoc> DanhSachChiTietDonThuoc(int maphieu);
    }
}
