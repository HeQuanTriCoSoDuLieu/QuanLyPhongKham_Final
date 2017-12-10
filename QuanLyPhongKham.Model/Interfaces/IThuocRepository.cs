using QuanLyPhongKham.Model.DTO;
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
        //List<Thuoc_Loaithuoc> Danhsachthuoc(string Thongtin, string Dulieu);
        //List<Thuoc_Loaithuoc> Danhsachthuoc();

    }
}
