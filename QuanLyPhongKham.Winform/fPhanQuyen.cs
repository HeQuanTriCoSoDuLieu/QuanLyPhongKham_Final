using QuanLyPhongKham.Infrastructure;
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
    public partial class fPhanQuyen : Form
    {
        private LibraryService libraryService;

        public fPhanQuyen()
        {
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
            InitializeComponent();
        }

        private void fPhanQuyen_Load(object sender, EventArgs e)
        {
            Load_Dgv();
        }

        private void chkhienthimk_CheckedChanged(object sender, EventArgs e)
        {
            if (txtmatkhau.PasswordChar == '*')
            {
                txtmatkhau.PasswordChar = '\0';
                txtmatkhau.Text = txtmatkhau.Text;
            }
            else
            {
                txtmatkhau.PasswordChar = '*';
                txtmatkhau.Text = txtmatkhau.Text;
            }
        }

        private void dgvdstaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvdstaikhoan.SelectedRows)
            {
                txtmanv.Text = row.Cells[1].Value.ToString();
                txttenhienthi.Text = row.Cells[4].Value.ToString();
                txtmatkhau.Text = row.Cells[3].Value.ToString();
                txttendangnhap.Text = row.Cells[2].Value.ToString();
                cbphanquyen.SelectedIndex = (int) row.Cells[5].Value-2;            
                cbtrangthai.SelectedIndex = (bool)row.Cells[6].Value ? 1 : 0;
            }       
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {

            try
            {
                if (libraryService.CapNhatTaiKhoan(int.Parse(txtmanv.Text), txttendangnhap.Text, txtmatkhau.Text, txttenhienthi.Text, cbphanquyen.SelectedIndex + 2, cbtrangthai.SelectedIndex) > 0)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_Dgv();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Cập nhật không thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Load_Dgv()
        {
            dgvdstaikhoan.DataSource = libraryService.DanhSachTaiKhoan();
            dgvdstaikhoan.Columns[0].HeaderText = "Mã tài khoản"; dgvdstaikhoan.Columns[0].Width = 50;
            dgvdstaikhoan.Columns[1].HeaderText = "Mã nhân viên"; dgvdstaikhoan.Columns[1].Width = 70;
            dgvdstaikhoan.Columns[2].HeaderText = "Tên đăng nhập"; dgvdstaikhoan.Columns[2].Width = 125;
            dgvdstaikhoan.Columns[3].HeaderText = "Mật khẩu"; dgvdstaikhoan.Columns[3].Width = 125;
            dgvdstaikhoan.Columns[4].HeaderText = "Tên hiện thị"; dgvdstaikhoan.Columns[4].Width = 100;
            dgvdstaikhoan.Columns[5].HeaderText = "Mã phân quyền"; dgvdstaikhoan.Columns[5].Width = 80;
            dgvdstaikhoan.Columns[6].HeaderText = "Trạng thái"; dgvdstaikhoan.Columns[6].Width = 50;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (libraryService.ThemTaiKhoan(int.Parse(txtmanv.Text), txttendangnhap.Text, txtmatkhau.Text, txttenhienthi.Text, cbphanquyen.SelectedIndex + 2, cbtrangthai.SelectedIndex) > 0)
                {
                    MessageBox.Show("Thêm tài khoản thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_Dgv();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản không thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Thêm tài khoản không thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
