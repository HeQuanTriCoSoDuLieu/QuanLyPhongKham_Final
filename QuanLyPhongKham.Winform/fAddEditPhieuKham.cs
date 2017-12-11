using QuanLyPhongKham.Infrastructure;
using QuanLyPhongKham.Model.DTO;
using QuanLyPhongKham.Model.UI_DTO.fTiepNhanBenhNhan;
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
    public partial class fAddEditPhieuKham : Form
    {
        private bool isNew;
        private int IDNhanVien;
        private BenhNhan benhNhan;
        private PhieuKhamGUI phieuKham;
        private LibraryService libraryService;
        public fAddEditPhieuKham()
        {
            InitializeComponent();
        }

        public fAddEditPhieuKham(string title, BenhNhan benhNhan, int ID)
        {
            InitializeComponent();
            isNew = true;
            IDNhanVien = ID;
            this.benhNhan = benhNhan;
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
            //load data cho các textbox
            LoadData(title, this.benhNhan);
            LoadDanhSachBacSi(null);
            LoadHinhThucKham(null);
        }

        public fAddEditPhieuKham(string title, PhieuKhamGUI phieuKham, BenhNhan benhNhan)
        {
            InitializeComponent();
            isNew = false;
            this.phieuKham = phieuKham;
            this.benhNhan = benhNhan;
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
            //load data cho các textbox
            LoadData(title, this.phieuKham, benhNhan);

            LoadDanhSachBacSi(phieuKham.BacSi);
            LoadHinhThucKham(phieuKham.HinhThucKham);
        }

        private void LoadData(string title, PhieuKhamGUI phieuKham, BenhNhan benhNhan)
        {
            //set title cho form
            Text = title;
            btnAddEdit.Text = "Cập nhật";
            // load data cho các textbox
            txtHoTen.Text = phieuKham.HoTen;
            txtSDT.Text = benhNhan.SoDT;
            txtDanToc.Text = phieuKham.DanToc;
            txtDiaChi.Text = phieuKham.DiaChi;
            txtNgaySinh.Text = phieuKham.NgaySinh.ToString("dd-MM-yyyy");
            txtTienSuBenh.Text = benhNhan.TienSu;
            txtCMND.Text = benhNhan.SoCMND;
            rtbChuanDoan.Text = phieuKham.ChuanDoan;
            //load cbbBacSi
            cbbBacSi.SelectedIndex = cbbBacSi.Items.IndexOf(phieuKham.BacSi);
            
            //load cbbHinhThucKham
            if (benhNhan.GioiTinh.Equals("Nam"))
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }

        }

        private void LoadData(string title, BenhNhan benhNhan)
        {
            //title
            Text = title;
            //load data cho textbox
            txtHoTen.Text = benhNhan.HoTen;
            txtSDT.Text = benhNhan.SoDT;
            txtDanToc.Text = benhNhan.DanToc;
            txtDiaChi.Text = benhNhan.DiaChi;
            txtTienSuBenh.Text = benhNhan.TienSu;
            txtNgaySinh.Text = benhNhan.NgaySinh.ToString("dd-MM-yyyy");
            txtCMND.Text = benhNhan.SoCMND;
            if (benhNhan.GioiTinh.Equals("Nam"))
            {
                rdoNam.Checked = true;
            }
            else
            {
                rdoNu.Checked = true;
            }

            rtbChuanDoan.Focus();
            btnAddEdit.Text = "Thêm phiếu";




        }

        private void LoadDanhSachBacSi(string bacSi)
        {
            cbbBacSi.DataSource = libraryService.DanhSachNhanVien();
            cbbBacSi.DisplayMember = "HOTEN";
            cbbBacSi.ValueMember = "MANV";
            //set selectedindex cho cbb
            if (bacSi!=null)
            {
                cbbBacSi.SelectedIndex = cbbBacSi.FindStringExact(bacSi);
            }
            
        }
        
        private void LoadHinhThucKham(string hinhThucKham)
        {
            cbbHinhThucKham.DataSource = libraryService.DanhSachHinhThucKham();
            cbbHinhThucKham.DisplayMember = "TENHINHTHUCKHAM";
            cbbHinhThucKham.ValueMember = "MAHINHTHUCKHAM";
            if (hinhThucKham!=null)
            {
                cbbHinhThucKham.SelectedIndex = cbbHinhThucKham.FindStringExact(hinhThucKham);
            }
        }

       


        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHuyKham_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                int hinhThucKham = (int)cbbHinhThucKham.SelectedValue;
                int bacSi = (int)cbbBacSi.SelectedValue;
                PhieuKham phieuKham = new PhieuKham
                {
                    MaBN = benhNhan.MaBN,
                    MaHinhThucKham = hinhThucKham,
                    MaNV = bacSi,
                    ChuanDoan = rtbChuanDoan.Text,
                    NVTiepNhan = IDNhanVien
                };

                if (libraryService.InsertPhieuKham(phieuKham))
                {
                    MessageBox.Show("Thêm phiếu khám thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("Thêm phiếu khám thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                int hinhThucKham = (int)cbbHinhThucKham.SelectedValue;
                int bacSi = (int)cbbBacSi.SelectedValue;
                PhieuKham phieuKham = new PhieuKham
                {
                    MaBN = benhNhan.MaBN,
                    MaHinhThucKham = hinhThucKham,
                    MaNV = bacSi,
                    ChuanDoan = rtbChuanDoan.Text,
                    NVTiepNhan = IDNhanVien,
                    MaPhieuKham = this.phieuKham.MaPhieuKham
                };
                libraryService.CapNhatPhieuKham(phieuKham);
                MessageBox.Show("Cập nhật phiếu khám thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;

            }
        }

        private void fAddEditPhieuKham_Load(object sender, EventArgs e)
        {
            
           
        }
    }
}
