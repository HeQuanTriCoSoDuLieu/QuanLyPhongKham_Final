using QuanLyPhongKham.Infrastructure;
using QuanLyPhongKham.Model.DTO;
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
    public partial class fAdmin : Form
    {

        #region Global vars
        TaiKhoan taiKhoan;
        LibraryService libraryService;
        static List<ThuocGUI> listThuoc;
        #endregion

        public fAdmin(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);

            txtTimKiemThuoc.Focus();
            cbbTimKiemThuoc.SelectedIndex = 1;

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
            if (dgvThuoc.SelectedRows.Count>0)
            {
                int maThuoc = (int) dgvThuoc.SelectedRows[0].Cells[1].Value;
                fChiTietThuoc f = new fChiTietThuoc(maThuoc);
                Hide();
                f.ShowDialog();
                Show();
            }
           
        }

        #endregion

       

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
    }
}
