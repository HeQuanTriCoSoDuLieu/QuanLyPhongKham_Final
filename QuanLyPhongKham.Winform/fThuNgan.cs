using QuanLyPhongKham.Infrastructure;
using QuanLyPhongKham.Model.DTO;
using QuanLyPhongKham.Model.UI_DTO;
using QuanLyPhongKham.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.Winform
{
    public partial class fThuNgan : Form
    {
        #region global var
        private TaiKhoan taiKhoan;
        private LibraryService libraryService;
        List<DonThuocGUI> listDonThuoc;
        List<DichVuCLSGUI> listDVCLS;
        #endregion


        #region Constructor
        public fThuNgan()
        {
            InitializeComponent();
        }
        public fThuNgan(TaiKhoan taiKhoan)
        {
            InitializeComponent();

            this.taiKhoan = taiKhoan;
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);



            //load danh sách đơn thuốc của ngày hôm nay
            listDonThuoc = libraryService.DanhSachDonThuoc(DateTime.Now);
            LoadDanhSachDonThuoc(listDonThuoc);

            //load danh sach dịch vụ cls
            listDVCLS = libraryService.DanhSachDVCLS();
            LoadDanhSachDVCLS(listDVCLS);
                 

        }

        



        #endregion


        #region Methods
        private void LoadDanhSachDonThuoc(List<DonThuocGUI> list)
        {
            dgvDonThuoc.Rows.Clear();
            int stt = 1;
            foreach (var item in list)
            {
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");  
                string cost = double.Parse(item.ThanhTien.ToString()).ToString("#,###", cul.NumberFormat);
                dgvDonThuoc.Rows.Add(stt++,item.MaDonThuoc, item.MaBN, item.HoTen,item.GioiTinh, item.NgaySinh, cost, item.TrangThai == true ? "Đã thanh toán" : "Chưa thanh toán");
            }
        }

        private void LoadDanhSachDVCLS(List<DichVuCLSGUI> listDVCLS)
        {
            int stt = 1;
            dgvDichVu.Rows.Clear();
            foreach (DichVuCLSGUI item in listDVCLS)
            {

                dgvDichVu.Rows.Add(stt++,item.MaBN,item.HoTen,item.GioiTinh,item.NgaySinh,item.TenDichVu,item.ThanhTien,item.TinhTrang);
            }
        }
        #endregion

        #region Events


        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        #endregion



        private void btnThuDonThuoc_Click(object sender, EventArgs e)
        {
            if (dgvDonThuoc.SelectedRows.Count > 0)
            {
                int maDonThuoc = (int)dgvDonThuoc.SelectedRows[0].Cells[1].Value;
                if (libraryService.ThuPhiDonThuoc(maDonThuoc,taiKhoan.MaNV))
                {
                    MessageBox.Show("Cập nhật thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon
                        .Information);
                    listDonThuoc = libraryService.DanhSachDonThuoc(DateTime.Now);
                    LoadDanhSachDonThuoc(listDonThuoc);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon
                        .Error);
                }
            }
            
        }

        private void btnThuPhiDichVu_Click(object sender, EventArgs e)
        {
            if (dgvDichVu.SelectedRows.Count > 0)
            {
                int maBN = (int)dgvDichVu.SelectedRows[0].Cells[1].Value;
                DichVuCLSGUI dichVuCLSGUI = listDVCLS.Single(p=>p.MaBN == maBN);
                if (libraryService.ThuPhiCLS(taiKhoan.MaNV,dichVuCLSGUI.MADVCLS))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon
                        .Information);
                    listDVCLS = libraryService.DanhSachDVCLS();
                    LoadDanhSachDVCLS(listDVCLS);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon
                        .Error);
                }
            }
        }
    }
}
