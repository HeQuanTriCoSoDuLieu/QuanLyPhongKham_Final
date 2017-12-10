using QuanLyPhongKham.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Model.Interfaces
{
    public interface ICanLamSanRepository
    {
        List<CanLamSan> DanhSachLoaiCLS(int macls);


        /// thêm

        DataTable GetCLS(string filePath);
    }
}
