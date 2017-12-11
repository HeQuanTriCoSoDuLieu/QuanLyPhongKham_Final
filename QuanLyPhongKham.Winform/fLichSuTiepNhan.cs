using QuanLyPhongKham.Infrastructure;
using QuanLyPhongKham.Model.DTO;
using QuanLyPhongKham.Model.UI_DTO.fTiepNhanBenhNhan;
using QuanLyPhongKham.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyPhongKham.Winform
{
    public partial class fLichSuTiepNhan : Form
    {
        #region properties

        private LibraryService librarySerVice;
        private TaiKhoan nhanVien;
        private List<PhieuKhamGUI> sttListLichSu;

        #endregion properties

        public fLichSuTiepNhan()
        {
            InitializeComponent();
        }

        public fLichSuTiepNhan(TaiKhoan nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
        }

        private void fLichSuTiepNhan_Load(object sender, System.EventArgs e)
        {
            // khởi tạo service
            librarySerVice = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
            // đổ dữ liệu cho label
            lblNgayHeThong.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblNhanVien.Text = nhanVien.TenHienThi;
            //set index cho cbb
            cbbTimKiemLichSu.SelectedIndex = 1;

            // lấy dữ liệu cho list static
            sttListLichSu = librarySerVice.LichSuTiepNhanByID(nhanVien.MaNV);

            // load danh sách phiêu khám theo ma nhan vien
            LoadLichSuTiepNhan(null);
        }

        private void LoadLichSuTiepNhan(List<PhieuKhamGUI> list)
        {
            dgvLichSuTiepNhan.Rows.Clear();
            int stt = 1;
            List<PhieuKhamGUI> listPhieuKham = list == null ? sttListLichSu : list;
            foreach (var item in listPhieuKham)
            {
                dgvLichSuTiepNhan.Rows.Add(new object[] { stt++, item.MaBN, item.HoTen, item.NgayKham.ToString("dd/MM/yyyy"), item.DiaChi, item.GioiTinh, item.ChuanDoan, item.HinhThucKham, item.BacSi });
            }
        }

        private void btnTimKiemLichSu_Click(object sender, EventArgs e)
        {
            string cot = "";

            switch (cbbTimKiemLichSu.SelectedIndex)
            {
                case 0:
                    cot = "all";
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

                case 5:
                    cot = "NGAYKHAM";
                    break;
            }
            if (txtTimKiemLichSu.Text == "" && cbbTimKiemLichSu.SelectedIndex != 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cot == "all")
                {
                    LoadLichSuTiepNhan(sttListLichSu);
                }
                else
                {
                    int maNV = nhanVien.MaNV;
                    string value = txtTimKiemLichSu.Text.Trim();
                    List<PhieuKhamGUI> list = librarySerVice.TimKiemLichSuTiepNhan(maNV, cot, value);
                    if (list.Count == 0 && cbbTimKiemLichSu.SelectedIndex != 0)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        LoadLichSuTiepNhan(list);
                    }
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            
            ExtensionMethod.ExportToExcel(dgvLichSuTiepNhan,"Lịch sử tiếp nhận",nhanVien.TenHienThi,DateTime.Now.ToString("dd/MM/yyyy HH:mm"),"lichsutiepnhan");
        }
    }
}