using QuanLyPhongKham.Infrastructure;
using QuanLyPhongKham.Model.DTO;
using QuanLyPhongKham.Model.UI_DTO;
using QuanLyPhongKham.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyPhongKham.Winform
{
    public partial class fChiTietPhieuNhapThuoc : Form
    {
        private LibraryService libraryService;

        public fChiTietPhieuNhapThuoc()
        {
            InitializeComponent();
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);

            //load danh sach thuoc vao cbb
            LoadDanhSachThuoc(libraryService.DanhSachThuoc());
            //load danh sách nhà cung cấp vào cbb
            LoadDanhSachNhaCungCap(libraryService.DanhSachNhaCungCap());

            LoadDanhSachHangSanXuat(libraryService.DanhSachHangSanXuat());
        }

        private void LoadDanhSachNhaCungCap(List<NhaCungCap> list)
        {
            cbbNhaCungCap.ValueMember = "MaNhaCC";
            cbbNhaCungCap.DisplayMember = "TenNhaCC";
            cbbNhaCungCap.DataSource = list;
        }

        private void LoadDanhSachHangSanXuat(List<HangSanXuat> list)
        {
            cbbHangSanXuat.ValueMember = "MaHSX";
            cbbHangSanXuat.DisplayMember = "TenHSX";
            cbbHangSanXuat.DataSource = list;
        }

        private void LoadDanhSachThuoc(List<ThuocGUI> danhSachThuoc)
        {
            cbbThuoc.ValueMember = "MaThuoc";
            cbbThuoc.DisplayMember = "TenThuoc";
            cbbThuoc.DataSource = danhSachThuoc;
        }

        private void fChiTietPhieuNhapThuoc_Load(object sender, EventArgs e)
        {
            cbbThuoc.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool flag = true;
            ChiTietThuocGUI thuoc = new ChiTietThuocGUI();

            //kiểm tra tên thuốc có tồn tại trong hệ thống chưa
            if (cbbThuoc.SelectedIndex == -1)
            {
                MessageBox.Show("Thuốc không tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            else
            {
                thuoc.MaThuoc = (int)cbbThuoc.SelectedValue;
                thuoc.TenThuoc = cbbThuoc.Text;
            }

            decimal giaThuoc = 0;

            //kiểm tra giá bán lẻ
            if (Decimal.TryParse(txtGiaBanLe.Text, out giaThuoc))
            {
                thuoc.GiaBanLe = giaThuoc.ToString();
            }
            else
            {
                MessageBox.Show("Giá bán lẻ phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }

            //kiểm tra giá nhập
            if (Decimal.TryParse(txtGiaNhap.Text, out giaThuoc))
            {
                thuoc.GiaNhap = giaThuoc.ToString();
            }
            else
            {
                MessageBox.Show("Giá nhập phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }

            thuoc.NgayHH = dtpNgayHetHan.Value.ToString("dd-MM-yyyy");
            thuoc.dtNgayHH = dtpNgayHetHan.Value;
            thuoc.NgaySX = dtpNgaySanXuat.Value.ToString("dd-MM-yyyy");
            thuoc.dtNgaySX = dtpNgaySanXuat.Value;
            thuoc.SoLuong = (int)numberSoLuong.Value;

            //cbb nha cung cap
            if (cbbNhaCungCap.SelectedIndex == -1)
            {
                MessageBox.Show("Nhà cung cấp không tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            else
            {
                thuoc.TenNhaCC = cbbNhaCungCap.Text;
                thuoc.MaNhaCC = (int)cbbNhaCungCap.SelectedValue;
            }

            //cbb hãng sản xuất
            if (cbbHangSanXuat.SelectedIndex == -1)
            {
                MessageBox.Show("Hãng sản xuất không tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            else
            {
                thuoc.TenHSX = cbbHangSanXuat.Text;
                thuoc.MaHSX = (int)cbbHangSanXuat.SelectedValue;
            }

            foreach (var item in fAdmin.listChiTietThuoc)
            {
                if (item.MaThuoc == thuoc.MaThuoc)
                {
                    flag = false;
                    MessageBox.Show("Thuốc đã tồn tại trong phiếu nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            if (flag)
            {
                fAdmin.listChiTietThuoc.Add(thuoc);
                MessageBox.Show("Thêm vào phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}