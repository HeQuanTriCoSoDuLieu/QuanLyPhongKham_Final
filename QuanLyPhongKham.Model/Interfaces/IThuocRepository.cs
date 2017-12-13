using QuanLyPhongKham.Model.DTO;
using QuanLyPhongKham.Model.UI_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.Interfaces
{
    public interface IThuocRepository
    {
        List<TimKiemThuoc> TimKiemThuoc(string timkiemthuoc, int timtheo, int loaithuoc);

        List<ThuocGUI> DanhSachThuoc();

        List<ThuocGUI> TimKiemThuocAdmin(string column, string info);
        List<ChiTietThuocGUI> ChiTietThuoc(int maThuoc);

        bool InsertThuoc(Thuoc thuoc);
    }
}
