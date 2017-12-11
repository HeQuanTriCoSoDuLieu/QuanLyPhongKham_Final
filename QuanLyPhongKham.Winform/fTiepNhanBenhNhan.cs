using QuanLyPhongKham.Infrastructure;
using QuanLyPhongKham.Model.DTO;
using QuanLyPhongKham.Model.UI_DTO.fTiepNhanBenhNhan;
using QuanLyPhongKham.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyPhongKham.Winform
{
    public partial class fTiepNhanBenhNhan : Form
    {
        private TaiKhoan nhanVien;
        private LibraryService libraryService;
        private static List<BenhNhan> listBenhNhan;
        private static List<PhieuKhamGUI> listPhieuKham;
        public static BenhNhan benhNhanStatic;

        /// <summary>
        /// constructor
        /// </summary>
        public fTiepNhanBenhNhan()
        {
            InitializeComponent();
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
            benhNhanStatic = new BenhNhan();
        }

        public fTiepNhanBenhNhan(TaiKhoan nhanVien)
        {
            InitializeComponent();
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
            benhNhanStatic = new BenhNhan();
            this.nhanVien = nhanVien;
        }

        /// <summary>
        /// hàm load khi chạy form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fTiepNhanBenhNhan_Load(object sender, EventArgs e)
        {
            //load danh sách bệnh nhân cho datagridview
            LoadDanhSachBenhNhan();

            //load danh sach phieu kham cho dgvDanhSachPhieuKham
            DateTime date = DateTime.Now;
            listPhieuKham = libraryService.DanhSachPhieuKhamGUI(date);
            LoadPhieuKham(listPhieuKham);

            //set thuộc tính đầu tiên cho combobox tim kiem
            cbxTimKiemBenhNhan.SelectedIndex = 1;
            cbbTimKiemPhieuKham.SelectedIndex = 1;
        }

       

        #region Method

        /// <summary>
        /// load danh sách bệnh nhân cho datagridview bệnh nhân
        /// </summary>
        private void LoadDanhSachBenhNhan()
        {
            listBenhNhan = libraryService.DanhSachBenhNhan();
            dgvDanhSachBenhNhan.Rows.Clear();
            dgvDanhSachBenhNhan.Refresh();
            foreach (BenhNhan item in listBenhNhan)
            {
                dgvDanhSachBenhNhan.Rows.Add(item.MaBN, item.HoTen, item.GioiTinh, item.NgaySinh.ToString("dd/MM/yyyy"), item.DanToc, item.SoCMND, item.DiaChi, item.SoDT, item.TienSu);
            }
        }

        /// <summary>
        /// hàm load danh sach phieu kham
        /// </summary>
        /// <param name="listPhieuKham"></param>
        private void LoadPhieuKham(List<PhieuKhamGUI> listPhieuKham)
        {
            dgvDanhSachKham.Rows.Clear();
            dgvDanhSachKham.Refresh();

            int SttDanhSachKham = 1;
            foreach (PhieuKhamGUI item in listPhieuKham)
            {
                dgvDanhSachKham.Rows.Add(SttDanhSachKham++, item.MaBN, item.MaPhieuKham, item.HoTen, item.NgaySinh.ToString("dd/MM/yyyy"), item.GioiTinh, item.DiaChi, item.ChuanDoan, item.HinhThucKham, item.BacSi);
            }
        }

        /// <summary>
        /// hàm load danh sach phieu kham
        /// </summary>
        private void LoadPhieuKham()
        {
            listPhieuKham = libraryService.DanhSachPhieuKhamGUI(DateTime.Now);
            dgvDanhSachKham.Rows.Clear();
            dgvDanhSachKham.Refresh();

            int SttDanhSachKham = 1;
            foreach (PhieuKhamGUI item in listPhieuKham)
            {
                dgvDanhSachKham.Rows.Add(SttDanhSachKham++, item.MaBN, item.MaPhieuKham, item.HoTen, item.NgaySinh.ToString("dd/MM/yyyy"), item.GioiTinh, item.DiaChi, item.ChuanDoan, item.HinhThucKham, item.BacSi);
            }
        }

        #endregion Method

        #region MenuStrip Events

        private void thêmBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAddEditBenhNhan f = new fAddEditBenhNhan("Thêm bệnh nhân", "Thêm");
            f.ShowDialog();
            if (f.DialogResult != DialogResult.Cancel)
            {
                LoadDanhSachBenhNhan();
                benhNhanStatic = listBenhNhan[listBenhNhan.Count - 1];
            }
        }

        private void lịchSửKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fLichSuTiepNhan f = new fLichSuTiepNhan(nhanVien);
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        #endregion MenuStrip Events

        /// <summary>
        /// Thêm bệnh nhân
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThemBenhNhan_Click(object sender, EventArgs e)
        {
            fAddEditBenhNhan f = new fAddEditBenhNhan("Thêm bệnh nhân", "Thêm");
            f.ShowDialog();
            if (f.DialogResult != DialogResult.Cancel)
            {
                LoadDanhSachBenhNhan();
                benhNhanStatic = listBenhNhan[listBenhNhan.Count - 1];
            }
        }

        private void btnCapNhatBenhNhan_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachBenhNhan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvDanhSachBenhNhan.SelectedRows[0];
                BenhNhan benhNhan = listBenhNhan.Single(p => p.MaBN == (int)row.Cells[0].Value);

                fAddEditBenhNhan f = new fAddEditBenhNhan("Cập nhật thông tin bệnh nhân", "Cập nhật", benhNhan);
                f.ShowDialog();

                if (f.DialogResult != DialogResult.Cancel)
                {
                    LoadDanhSachBenhNhan();
                    LoadPhieuKham();
                }
            }
        }

        /// <summary>
        /// tìm kiếm bệnh nhân
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimKiemBenhNhan_Click(object sender, EventArgs e)
        {
            string cot = "";
            switch (cbxTimKiemBenhNhan.SelectedIndex)
            {
                case 0:
                    cot = "*";
                    break;

                case 1:
                    cot = "MABN";
                    break;

                case 2:
                    cot = "HOTEN";
                    break;

                case 3:
                    cot = "SODT";
                    break;

                case 4:
                    cot = "SOCMND";
                    break;
            }
            if (txtTimKiemBenhNhan.Text == "" && cbxTimKiemBenhNhan.SelectedIndex != 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (libraryService.TimKiemBenhNhan(cot, txtTimKiemBenhNhan.Text).Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvDanhSachBenhNhan.Rows.Clear();
                    dgvDanhSachBenhNhan.Refresh();
                    foreach (BenhNhan item in libraryService.TimKiemBenhNhan(cot, txtTimKiemBenhNhan.Text))
                    {
                        dgvDanhSachBenhNhan.Rows.Add(item.MaBN, item.HoTen, item.GioiTinh, item.NgaySinh.ToString("dd/MM/yyyy"), item.DanToc, item.SoCMND, item.DiaChi, item.SoDT, item.TienSu);
                    }
                }
            }
        }

        /// <summary>
        /// Tìm kiếm phiếu khám
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimKiemPhieuKham_Click(object sender, EventArgs e)
        {
            string txtSearch = txtTimKiemPhieuKham.Text.Trim();
            int col = cbbTimKiemPhieuKham.SelectedIndex;
            List<PhieuKhamGUI> list;
            if (string.IsNullOrEmpty(txtSearch) && col != 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switch (col)
                {
                    case 0:
                        LoadPhieuKham(listPhieuKham);
                        break;

                    case 1:
                        list = listPhieuKham.Where(p => p.MaBN.ToString().Equals(txtSearch)).ToList();
                        if (list.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            LoadPhieuKham(list);
                        }
                        break;

                    case 2:
                        list = listPhieuKham.Where(p => p.HoTen.ToString().ToUpper().Contains(txtSearch.ToUpper())).ToList();
                        if (list.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            LoadPhieuKham(list);
                        }
                        break;

                    case 3:
                        list = listPhieuKham.Where(p => p.SoDT.Contains(txtSearch.ToUpper())).ToList();
                        if (list.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            LoadPhieuKham(list);
                        }
                        break;

                    case 4:
                        list = listPhieuKham.Where(p => p.SOCMND.Contains(txtSearch.ToUpper())).ToList();
                        if (list.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            LoadPhieuKham(list);
                        }
                        break;
                }
            }
        }

        private void btnCapNhatPhieuKham_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachKham.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dgvDanhSachKham.SelectedRows[0];
                //MessageBox.Show(row.Cells[2].Value.ToString());
                PhieuKhamGUI phieuKham = listPhieuKham.Single(p => p.MaPhieuKham == (int)row.Cells[2].Value);
                BenhNhan benhNhan = listBenhNhan.Single(p => p.MaBN == (int)row.Cells[1].Value);
                fAddEditPhieuKham f = new fAddEditPhieuKham("Cập nhật phiếu khám", phieuKham, benhNhan);
                f.ShowDialog();
                if (f.DialogResult == DialogResult.OK)
                {
                    listPhieuKham = libraryService.DanhSachPhieuKhamGUI(DateTime.Now);
                    LoadPhieuKham(listPhieuKham);
                }
            }
        }

        private void btnHuyKham_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachKham.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dgvDanhSachKham.SelectedRows[0];
                int maPhieuKham = (int)row.Cells[2].Value;

                string message = string.Format("Hủy khám cho bệnh nhân {0}?", row.Cells[3].Value.ToString());
                if (MessageBox.Show(message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    //int nhanVienTiepNhan = Int32.Parse(Properties.Settings.Default.id);
                    libraryService.HuyKham(maPhieuKham, nhanVien.MaNV);
                    LoadPhieuKham();
                }
            }
        }

        private void btnThemPhieuKham_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachBenhNhan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDanhSachBenhNhan.SelectedRows[0];

                BenhNhan benhNhan = listBenhNhan.Single(p => p.MaBN == (int)row.Cells[0].Value);
                fAddEditPhieuKham f = new fAddEditPhieuKham("Thêm phiếu khám", benhNhan,nhanVien.MaNV);
                f.ShowDialog();
                if (f.DialogResult == DialogResult.OK)
                {
                    listPhieuKham = libraryService.DanhSachPhieuKhamGUI(DateTime.Now);
                    LoadPhieuKham(listPhieuKham);
                    tabControl1.SelectTab(1);
                }
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}