using QuanLyPhongKham.Infrastructure;
using QuanLyPhongKham.Model.DTO;
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
    public partial class fTiepNhanBenhNhan : Form
    {
        private LibraryService libraryService;
        private static List<BenhNhan> listBenhNhan;
        private static List<PhieuKhamGUI> listPhieuKham;
        public static BenhNhan benhNhanStatic;
        private static PhieuKhamGUI phieuKhamStatic;
        /// <summary>
        /// constructor
        /// </summary>
        public fTiepNhanBenhNhan()
        {
            InitializeComponent();
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
            benhNhanStatic = new BenhNhan();
        }



        #region Events

        /// <summary>
        /// hàm load khi chạy form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fTiepNhanBenhNhan_Load(object sender, EventArgs e)
        {

            //load danh sách bệnh nhân cho datagridview
            LoadDanhSachBenhNhan();
            LoadDanhSachBacSi();
            LoadHinhThucKham();

            //load data cho danh sach  kham
            DateTime date = DateTime.Now;
            listPhieuKham = libraryService.DanhSachPhieuKhamGUI(date);
            LoadPhieuKham(listPhieuKham);

            //set thuộc tính đầu tiên cho combobox tim kiem 
            cbxTimKiem.SelectedIndex = 1;
            cbbTimKiem1.SelectedIndex = 1;

        }


        private void dgvDanhSachBenhNhan_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDanhSachBenhNhan.SelectedRows)
            {

                benhNhanStatic = listBenhNhan.Where(b => b.MaBN == (int)row.Cells[0].Value).Single();
                LoadDataForTextBox(benhNhanStatic);
            }
        }

        private void dgvDanhSachKham_SelectionChanged(object sender, EventArgs e)
        {

            

            foreach (DataGridViewRow row in dgvDanhSachKham.SelectedRows)
            {
                int maBN = (int) row.Cells[1].Value;

                phieuKhamStatic = listPhieuKham.Where(p=>p.MaBN == maBN).First();

                benhNhanStatic = listBenhNhan.Where(b=>b.MaBN == phieuKhamStatic.MaBN).Single();

                //Đổ dữ liệu vào textbox
                LoadDataForTextBox(benhNhanStatic, phieuKhamStatic);

            }


            //MessageBox.Show(benhNhanStatic.MaBN.ToString());
        }


        /// <summary>
        /// tìm kiếm cho danh sách bệnh nhân
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string cot = "";
            switch (cbxTimKiem.SelectedIndex)
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
            if (txtTimKiem.Text == "" && cbxTimKiem.SelectedIndex != 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (libraryService.TimKiemBenhNhan(cot, txtTimKiem.Text).Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvDanhSachBenhNhan.Rows.Clear();
                    dgvDanhSachBenhNhan.Refresh();
                    foreach (BenhNhan item in libraryService.TimKiemBenhNhan(cot, txtTimKiem.Text))
                    {
                        dgvDanhSachBenhNhan.Rows.Add(item.MaBN, item.HoTen, item.GioiTinh, item.NgaySinh.ToString("dd/MM/yyyy"), item.DanToc, item.SoCMND, item.DiaChi, item.SoDT, item.TienSu);
                    }
                }
            }

        }

        /// <summary>
        /// tìm kiếm cho danh sách phieu kham
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimKiem1_Click(object sender, EventArgs e)
        {
            string txtSearch = txtTimKiem1.Text.Trim();
            int col = cbbTimKiem1.SelectedIndex;
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
        
        private void btnThemBenhNhan_Click(object sender, EventArgs e)
        {

            fAddEditBenhNhan f = new fAddEditBenhNhan("Thêm bệnh nhân", "Thêm");
            f.ShowDialog();
            if (f.DialogResult != DialogResult.Cancel)
            {
                LoadDanhSachBenhNhan();
                benhNhanStatic = listBenhNhan[listBenhNhan.Count - 1];
                LoadDataForTextBox(benhNhanStatic);
            }


        }

        private void btnCapNhatBenhNhan_Click(object sender, EventArgs e)
        {

            fAddEditBenhNhan f = new fAddEditBenhNhan("Cập nhật thông tin bệnh nhân", "Cập nhật", benhNhanStatic);
            f.ShowDialog();

            if (f.DialogResult != DialogResult.Cancel)
            {
                LoadDanhSachBenhNhan();
                LoadPhieuKham();


            }

        }

        private void btnChoKham_Click(object sender, EventArgs e)
        {
            int hinhThucKham = (int)cbbHinhThucKham.SelectedValue;
            int bacSi = (int) cbbBacSi.SelectedValue;
            int nhanVienTiepNhan = Int32.Parse(Properties.Settings.Default.id);
            MessageBox.Show(nhanVienTiepNhan.ToString());
            PhieuKham phieuKham = new PhieuKham
            {
                MaBN = benhNhanStatic.MaBN,
                MaHinhThucKham = hinhThucKham,
                MaNV = bacSi,
                ChuanDoan = rtbChuanDoan.Text,
                NVTiepNhan = nhanVienTiepNhan
            };

            if (libraryService.InsertPhieuKham(phieuKham))
            {
                MessageBox.Show("Thêm phiếu khám thành công", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                listPhieuKham = libraryService.DanhSachPhieuKhamGUI(DateTime.Now);
                LoadPhieuKham(listPhieuKham);
            }
            else
            {
                MessageBox.Show("Thêm phiếu khám thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnHuyKham_Click(object sender, EventArgs e)
        {
            int nhanVienTiepNhan = Int32.Parse(Properties.Settings.Default.id);
            libraryService.HuyKham(phieuKhamStatic.MaPhieuKham, nhanVienTiepNhan);
            LoadPhieuKham();
        }

        private void btnCapNhatPhieu_Click(object sender, EventArgs e)
        {
            int hinhThucKham = (int)cbbHinhThucKham.SelectedValue;
            int bacSi = (int)cbbBacSi.SelectedValue;
            PhieuKham phieuKham = new PhieuKham
            {
                MaBN = benhNhanStatic.MaBN,
                MaHinhThucKham = hinhThucKham,
                MaNV = bacSi,
                ChuanDoan = rtbChuanDoan.Text,
                NVTiepNhan = 1,
                MaPhieuKham = phieuKhamStatic.MaPhieuKham
            };
            libraryService.CapNhatPhieuKham(phieuKham);
            MessageBox.Show("Cập nhật phiếu khám thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadPhieuKham();
        }


        #endregion


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

        private void LoadDanhSachBacSi()
        {
            cbbBacSi.DataSource = libraryService.DanhSachNhanVien();
            cbbBacSi.DisplayMember = "HOTEN";
            cbbBacSi.ValueMember =  "MANV";
        }

        private void LoadHinhThucKham()
        {
            cbbHinhThucKham.DataSource = libraryService.DanhSachHinhThucKham();
            cbbHinhThucKham.DisplayMember = "TENHINHTHUCKHAM";
            cbbHinhThucKham.ValueMember = "MAHINHTHUCKHAM";
        }

        private void LoadPhieuKham(List<PhieuKhamGUI> listPhieuKham)
        {
            dgvDanhSachKham.Rows.Clear();
            dgvDanhSachKham.Refresh();

            int SttDanhSachKham = 1;
            foreach (PhieuKhamGUI item in listPhieuKham)
            {
                dgvDanhSachKham.Rows.Add(SttDanhSachKham++, item.MaBN, item.HoTen, item.DiaChi, item.GioiTinh, item.NgaySinh.ToString("dd/MM/yyyy"), item.ChuanDoan, item.HinhThucKham, item.BacSi);
            }
        }

        private void LoadPhieuKham()
        {
            listPhieuKham = libraryService.DanhSachPhieuKhamGUI(DateTime.Now);
            dgvDanhSachKham.Rows.Clear();
            dgvDanhSachKham.Refresh();

            int SttDanhSachKham = 1;
            foreach (PhieuKhamGUI item in listPhieuKham)
            {
                dgvDanhSachKham.Rows.Add(SttDanhSachKham++, item.MaBN, item.HoTen, item.DiaChi, item.GioiTinh, item.NgaySinh.ToString("dd/MM/yyyy"), item.ChuanDoan, item.HinhThucKham, item.BacSi);
            }
        }


        /// <summary>
        /// load dữ liệu từ bệnh nhân static vào cho các textbox
        /// </summary>
        /// <param name="benhNhan"></param>
        private void LoadDataForTextBox(BenhNhan benhNhan)
        {
            rtbChuanDoan.Text = "";
            txtHoTen.Text = benhNhan.HoTen;
            if (benhNhan.GioiTinh.Equals("Nam"))
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }
            txtSDT.Text = benhNhan.SoDT;
            dtpNgaySinh.Value = benhNhan.NgaySinh;
            txtDanToc.Text = benhNhan.DanToc;
            txtCMND.Text = benhNhan.SoCMND;
            txtDiaChi.Text = benhNhan.DiaChi;
            txtTienSuBenh.Text = benhNhan.TienSu;

        }

        private void LoadDataForTextBox(BenhNhan benhNhan, PhieuKhamGUI phieuKhamGUI)
        {
            LoadDataForTextBox(benhNhan);
            rtbChuanDoan.Text = phieuKhamGUI.ChuanDoan;
        }





        #endregion

        
    }

}
