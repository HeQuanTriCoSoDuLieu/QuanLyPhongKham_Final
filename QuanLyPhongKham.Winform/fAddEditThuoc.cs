using QuanLyPhongKham.Infrastructure;
using QuanLyPhongKham.Model.DTO;
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
    public partial class fAddEditThuoc : Form
    {
        LibraryService libraryService;
        static List<DonViTinh> listDonViTinh;
        static List<LoaiThuoc> listLoaiThuoc;
        public fAddEditThuoc()
        {
            InitializeComponent();
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
            //load cbb loai thuoc
            listDonViTinh = libraryService.DanhSachDonViTinh();
            listLoaiThuoc = libraryService.DanhSachLoaiThuoc();
            LoadLoaiThuoc(listLoaiThuoc);
            LoadDonViTinh(listDonViTinh);
        }

        private void LoadDonViTinh(List<DonViTinh> listDonViTinh)
        {
            cbbDVT.DataSource = listDonViTinh;
            cbbDVT.DisplayMember = "TenDVT";
            cbbDVT.ValueMember = "MaDVT";
        }

        private void LoadLoaiThuoc(List<LoaiThuoc> listLoaiThuoc)
        {
            cbbLoaiThuoc.DataSource = listLoaiThuoc;
            cbbLoaiThuoc.DisplayMember = "TenLoaiThuoc";
            cbbLoaiThuoc.ValueMember = "MaLoaiThuoc";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            Thuoc thuoc = new Thuoc {
                TenThuoc = txtTenThuoc.Text.Trim(),
                DonViTinh =(int) cbbDVT.SelectedValue,
                LoaiThuoc = (int)cbbLoaiThuoc.SelectedValue,
                GhiChu = txtGhiChu.Text.Trim(),
                SoLuongTon = 0
            };
            if (string.IsNullOrEmpty(thuoc.TenThuoc))
            {
                MessageBox.Show("Tên thuốc không được rỗng","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (libraryService.InsertThuoc(thuoc))
                {
                    MessageBox.Show("Thêm thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            
        }
    }
}
