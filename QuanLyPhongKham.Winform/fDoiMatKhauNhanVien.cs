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
    public partial class fDoiMatKhauNhanVien : Form
    {
        private LibraryService libraryService;
        string username;
        int manv;
        public fDoiMatKhauNhanVien(string username, int manv)
        {
            this.manv = manv;
            this.username = username;
            InitializeComponent();
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string passWordHienTai = txtPassWordHienTai.Text.Trim();
            string newpassWord = txtnewPassword.Text.Trim();
            if (libraryService.DoiMatKhau(username, passWordHienTai, newpassWord,manv) > 0)
            {
                MessageBox.Show("Thay đổi mật khẩu thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
