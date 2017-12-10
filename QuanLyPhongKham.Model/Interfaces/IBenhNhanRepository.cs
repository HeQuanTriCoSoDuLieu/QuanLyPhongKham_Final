using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhongKham.Model.DTO;
namespace QuanLyPhongKham.Model.Interfaces
{
    public interface IBenhNhanRepository
    {
        List<BenhNhan> DanhSachBenhNhan();
        List<BenhNhan> TimKiemBenhNhan(string col, string info);
        bool ThemBenhNhan(BenhNhan benhNhan);
        bool UpdateBenhNhan(BenhNhan benhNhan);
    }
}
