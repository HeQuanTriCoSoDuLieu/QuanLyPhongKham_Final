using QuanLyPhongKham.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.Interfaces
{
    public interface IVatTuYTeRepository
    {
        List<Vattuyte_DVT> DanhsachVTYT();

        List<Vattuyte_DVT> TimkiemVTYT(String thongtin, String dulieu);
    }
}
