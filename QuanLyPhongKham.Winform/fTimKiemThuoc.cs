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
    public partial class fTimKiemThuoc : Form
    {
        private LibraryService libraryService;
        public int mathuoctkt;
        public string tenthuoctkt;
        public fTimKiemThuoc()
        {
            InitializeComponent();
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);

        }

        // hàm kiểm tra là chữ hay số
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true; // nếu là số
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            int timtheo;
            int loaithuoc = cbxnhomthuoc.SelectedIndex;
            if (IsNumber(txttimkiem.Text.Trim()))
            {
                timtheo = 0;
                    if (libraryService.TimKiemThuoc(txttimkiem.Text.Trim(), timtheo, loaithuoc).Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaddulieu();
                    }
                    else
                    {
                        List<TimKiemThuoc> listlskham = new List<TimKiemThuoc>();
                        listlskham = libraryService.TimKiemThuoc(txttimkiem.Text.Trim(), timtheo, loaithuoc);
                        dgvdsthuoc.DataSource = listlskham;
                        dgvdsthuoc.Columns[0].HeaderText = "Mã thuốc"; dgvdsthuoc.Columns[0].Width = 90;
                        dgvdsthuoc.Columns[1].HeaderText = "Tên thuốc"; dgvdsthuoc.Columns[1].Width = 200;
                        dgvdsthuoc.Columns[2].HeaderText = "Đơn vị tính"; dgvdsthuoc.Columns[2].Width = 100;
                        dgvdsthuoc.Columns[3].HeaderText = "Loại thuốc"; dgvdsthuoc.Columns[3].Width = 250;
                        dgvdsthuoc.Columns[4].HeaderText = "Số lượng tồn"; dgvdsthuoc.Columns[4].Width = 90;

                        dgvdsthuoc.RowHeadersVisible = false;
                }
            }
            else
            {
                timtheo = 1;
                    if (libraryService.TimKiemThuoc(txttimkiem.Text.Trim(), timtheo, loaithuoc).Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaddulieu();
                    }
                    else
                    {
                        List<TimKiemThuoc> listlskham = new List<TimKiemThuoc>();
                        listlskham = libraryService.TimKiemThuoc(txttimkiem.Text.Trim(), timtheo, loaithuoc);
                        dgvdsthuoc.DataSource = listlskham;
                        dgvdsthuoc.Columns[0].HeaderText = "Mã thuốc"; dgvdsthuoc.Columns[0].Width = 90;
                        dgvdsthuoc.Columns[1].HeaderText = "Tên thuốc"; dgvdsthuoc.Columns[1].Width = 200;
                        dgvdsthuoc.Columns[2].HeaderText = "Đơn vị tính"; dgvdsthuoc.Columns[2].Width = 100;
                        dgvdsthuoc.Columns[3].HeaderText = "Loại thuốc"; dgvdsthuoc.Columns[3].Width = 250;
                        dgvdsthuoc.Columns[4].HeaderText = "Số lượng tồn"; dgvdsthuoc.Columns[4].Width = 90;

                        dgvdsthuoc.RowHeadersVisible = false;
                }
            }
        }

        private void dgvdsthuoc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mathuoctkt = Getmathuoctkt();
            tenthuoctkt = Gettenthuoctkt();
            this.Hide();
        }

        
        // lấy mà thuốc trong datagirdview
        private int Getmathuoctkt()
        {
            foreach (DataGridViewRow row in dgvdsthuoc.SelectedRows)
            {
                mathuoctkt = (int)row.Cells[0].Value;
            }
            return mathuoctkt;
        }

        // lấy tên thuốc trong datagirdview
        private string Gettenthuoctkt()
        {
            foreach (DataGridViewRow row in dgvdsthuoc.SelectedRows)
            {
                tenthuoctkt = (string)row.Cells[1].Value;
            }
            return tenthuoctkt;
        }

        private void fTimKiemThuoc_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }

        private void loaddulieu()
        {
            int timtheo = -1;
            int loaithuoc = 0;
            List<TimKiemThuoc> listlskham = new List<TimKiemThuoc>();
            listlskham = libraryService.TimKiemThuoc(txttimkiem.Text.Trim(), timtheo, loaithuoc);
            dgvdsthuoc.DataSource = listlskham;
            dgvdsthuoc.Columns[0].HeaderText = "Mã thuốc"; dgvdsthuoc.Columns[0].Width = 90;
            dgvdsthuoc.Columns[1].HeaderText = "Tên thuốc"; dgvdsthuoc.Columns[1].Width = 200;
            dgvdsthuoc.Columns[2].HeaderText = "Đơn vị tính"; dgvdsthuoc.Columns[2].Width = 100;
            dgvdsthuoc.Columns[3].HeaderText = "Loại thuốc"; dgvdsthuoc.Columns[3].Width = 250;
            dgvdsthuoc.Columns[4].HeaderText = "Số lượng tồn"; dgvdsthuoc.Columns[4].Width = 90;
            dgvdsthuoc.RowHeadersVisible = false;
        }
    }
}
