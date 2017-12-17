using QuanLyPhongKham.Infrastructure;
using QuanLyPhongKham.Model.DTO;
using QuanLyPhongKham.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyPhongKham.Winform
{
    public partial class fLogin : MetroFramework.Forms.MetroForm
    {
        private LibraryService libraryService;

        public fLogin()
        {
            InitializeComponent();
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            txbUserName.Focus();
            if (Properties.Settings.Default.rememberMe)
            {
                txbUserName.Text = Properties.Settings.Default.username;
                txbPassWord.Text = Properties.Settings.Default.password;
                chkRememberMe.Checked = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text.Trim();
            string passWord = txbPassWord.Text.Trim();

            DataTable dataTable = libraryService.Login(userName, passWord);
            int result = 0;
            int id = 0;
            TaiKhoan taiKhoan = null;
            if (dataTable.Rows.Count > 0)
            {
                taiKhoan = new TaiKhoan(dataTable.Rows[0]);
                result = taiKhoan.MaPhanQuyen;
                id = taiKhoan.MaNV;
            }
            switch (result)
            {
                case 1:
                    fAdmin admin = new fAdmin(taiKhoan);
                    Hide();
                    admin.ShowDialog();
                    Show();
                    break;

                case 2:
                    fKhamBenhNhan khamBenhNhan = new fKhamBenhNhan(id,userName, passWord);
                    Hide();
                    khamBenhNhan.ShowDialog();
                    Show();
                    break;

                case 3:
                    fTiepNhanBenhNhan tiepNhanBenhNhan = new fTiepNhanBenhNhan(taiKhoan);
                    Hide();
                    tiepNhanBenhNhan.ShowDialog();
                    Show();
                    break;

                case 4:
                    fThuNgan thuNgan = new fThuNgan(taiKhoan);
                    Hide();
                    thuNgan.ShowDialog();
                    Show();
                    break;

                default:
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            if (result != 0 && chkRememberMe.Checked)
            {
                Properties.Settings.Default.username = txbUserName.Text;
                Properties.Settings.Default.password = txbPassWord.Text;
                Properties.Settings.Default.rememberMe = true;
                Properties.Settings.Default.id = id.ToString();
                Properties.Settings.Default.Name = taiKhoan.TenHienThi;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.rememberMe = false;
                Properties.Settings.Default.Name = "";
                Properties.Settings.Default.Save();
            }
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}