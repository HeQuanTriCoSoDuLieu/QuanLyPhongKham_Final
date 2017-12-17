using QuanLyPhongKham.Infrastructure;
using QuanLyPhongKham.Model.DTO;
using QuanLyPhongKham.Model.UI_DTO;
using QuanLyPhongKham.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyPhongKham.Winform
{
    public partial class fAdmin : Form
    {
        #region Global vars

        private TaiKhoan taiKhoan;
        private LibraryService libraryService;
        private static List<ThuocGUI> listThuoc;
        public static List<ChiTietThuocGUI> listChiTietThuoc;

        #endregion Global vars

        public fAdmin(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);

            txtTimKiemThuoc.Focus();
            cbbTimKiemThuoc.SelectedIndex = 1;

            listChiTietThuoc = new List<ChiTietThuocGUI>();

            //load danh sach thuoc
            listThuoc = libraryService.DanhSachThuoc();
            LoadDanhSachThuoc(listThuoc);
        }

        private void LoadDanhSachThuoc(List<ThuocGUI> listThuoc)
        {
            int stt = 1;
            dgvThuoc.Rows.Clear();
            foreach (var item in listThuoc)
            {
                dgvThuoc.Rows.Add(stt++, item.MaThuoc, item.TenThuoc, item.SoLuongTon, item.DonViTinh, item.LoaiThuoc);
            }
        }

        #region Events

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExtensionMethod.ExportToExcel(dgvThuoc, "Danh sách thuốc", taiKhoan.TenHienThi, DateTime.Now.ToString("dd/MM/yyyy HH:mm"), "danhsachthuoc");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int number = cbbTimKiemThuoc.SelectedIndex;
            string column = "";
            switch (number)
            {
                case 0:
                    LoadDanhSachThuoc(listThuoc);
                    break;

                case 1:
                    column = "MATHUOC";
                    break;

                case 2:
                    column = "TENTHUOC";
                    break;
            }
            if (number != 0)
            {
                if (txtTimKiemThuoc.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    List<ThuocGUI> listThuocTemp = libraryService.TimKiemThuocAdmin(column, txtTimKiemThuoc.Text);
                    if (listThuocTemp.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        LoadDanhSachThuoc(listThuocTemp);
                    }
                }
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvThuoc.SelectedRows.Count > 0)
            {
                int maThuoc = (int)dgvThuoc.SelectedRows[0].Cells[1].Value;
                fChiTietThuoc f = new fChiTietThuoc(maThuoc);
                Hide();
                f.ShowDialog();
                Show();
            }
        }

        #endregion Events

        #region Quản lý thuốc

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            fAddEditThuoc f = new fAddEditThuoc();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                listThuoc = libraryService.DanhSachThuoc();
                LoadDanhSachThuoc(listThuoc);
            }
        }

        #endregion Quản lý thuốc

        #region nhập thuốc

        private void btnThemThuocPhieuNhap_Click(object sender, EventArgs e)
        {
            fChiTietPhieuNhapThuoc f = new fChiTietPhieuNhapThuoc();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                //load lại danh sách chi tiết nhập thuốc
                LoadChiTietNhapThuoc(listChiTietThuoc);
            }
        }

        private void LoadChiTietNhapThuoc(List<ChiTietThuocGUI> listChiTietThuocGUI)
        {
            dgvChiTietPhieuNhap.Rows.Clear();
            int stt = 1;
            foreach (ChiTietThuocGUI item in listChiTietThuocGUI)
            {
                dgvChiTietPhieuNhap.Rows.Add(stt++, item.MaThuoc, item.TenThuoc, item.SoLuong, item.NgaySX, item.NgayHH, item.GiaNhap, item.GiaBanLe, item.TenHSX, item.TenNhaCC);
            }
        }

        #endregion nhập thuốc

        private void btnXoaThuocPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dgvChiTietPhieuNhap.Rows.Count > 0)
            {
                int maThuoc = (int)dgvChiTietPhieuNhap.SelectedRows[0].Cells[1].Value;
                listChiTietThuoc.Remove(listChiTietThuoc.Single(p => p.MaThuoc == maThuoc));
                LoadChiTietNhapThuoc(listChiTietThuoc);
            }
        }

        private void btnXoaPhieuNhap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa phiếu nhập","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                listChiTietThuoc.Clear();
                LoadChiTietNhapThuoc(listChiTietThuoc);
            }
           
        }

        private void btnExcelPhieuNhap_Click(object sender, EventArgs e)
        {
            ExtensionMethod.ExportToExcel(dgvChiTietPhieuNhap, "Phiếu nhập thuốc", taiKhoan.TenHienThi, DateTime.Now.ToString("dd-MM-yyyy"), "chitietphieunhapthuoc");
        }

        /// <summary>
        /// lưu phiêu nhập thuốc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            PhieuNhap phieuNhap = libraryService.InsertPhieuNhap(taiKhoan.MaNV);
            if (phieuNhap != null)
            {
                foreach (var item in listChiTietThuoc)
                {
                    ChiTietPhieuNhapThuoc chiTietPhieuNhapThuoc = new ChiTietPhieuNhapThuoc
                    {
                        MaPhieuNhap = phieuNhap.MaPhieuNhap,
                        MaThuoc = item.MaThuoc,
                        SoLuong = item.SoLuong,
                        NgaySX = item.dtNgaySX,
                        NgayHetHan = item.dtNgayHH,
                        GiaNhap = decimal.Parse(item.GiaNhap),
                        GiaBanLe = decimal.Parse(item.GiaBanLe),
                        MaHSX = item.MaHSX,
                        MaNhaCC = item.MaNhaCC
                    };
                    if (libraryService.InsertChiTietPhieuNhapThuoc(chiTietPhieuNhapThuoc) == false)
                    {
                        MessageBox.Show("Thêm chi tiết cho phiếu nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("Thêm phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listThuoc = libraryService.DanhSachThuoc();
                LoadDanhSachThuoc(listThuoc);
            }
            else
            {
                MessageBox.Show("Thêm phiếu nhập thất bại");
            }
        }
    }
}