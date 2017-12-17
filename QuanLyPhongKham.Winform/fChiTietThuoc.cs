using QuanLyPhongKham.Infrastructure;
using QuanLyPhongKham.Model.UI_DTO;
using QuanLyPhongKham.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.Winform
{
    public partial class fChiTietThuoc : Form
    {
        LibraryService libraryService;
        List<ChiTietThuocGUI> listChiTietThuoc;
        public fChiTietThuoc(int maThuoc)
        {
            InitializeComponent();
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
            listChiTietThuoc = libraryService.ChiTietThuoc(maThuoc);
            LoadChiTietThuoc(listChiTietThuoc);
        }

        private void LoadChiTietThuoc(List<ChiTietThuocGUI> listChiTietThuoc)
        {
            int stt = 1;
            dgvChiTietThuoc.Rows.Clear();
            foreach (var item in listChiTietThuoc)
            {
                dgvChiTietThuoc.Rows.Add(stt++,item.MaThuoc,item.TenThuoc,item.MaPhieu, item.SoLuong, item.NgayNhap, item.NgaySX, item.NgayHH, item.GiaNhap, item.GiaBanLe, item.TenHSX, item.TenNhaCC);
            }
        }
    }
}
