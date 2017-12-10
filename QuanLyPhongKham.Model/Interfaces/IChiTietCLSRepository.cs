using QuanLyPhongKham.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.Interfaces
{
    public interface IChiTietCLSRepository
    {
        int InsertChiTietCLS(string maphieu, string macls, string link);

        ChiTietCLS LayketQua(string maphieu, string macls);
    }
}
