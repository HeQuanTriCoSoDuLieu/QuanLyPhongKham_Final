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
    public partial class fLichSuKhamBacSi : Form
    {
        private int manv;
        private LibraryService libraryService;
        public int maphieu;
        public string tenbn;

        public fLichSuKhamBacSi(int manv)
        {
            InitializeComponent();
            this.manv = manv;
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string cot = "";
            string value = txttimkiem.Text.Trim();
            switch (cbxtimkiem.SelectedIndex)
            {             
                case 0:
                    cot = "MABN";
                    break;
                case 1:
                    cot = "HOTEN";
                    break;
                case 2:
                    cot = "MAPHIEUKHAM";
                    break;
                case 3:
                    cot = "NGAYKHAM";
                    try
                    {
                        DateTime date = DateTime.Parse(value);
                        value = date.ToString("yyyy-MM-dd");
                    }
                    catch
                    {
                        break;
                    }
                    break;

            }
            if (StringToInt(value,cot)==false)
            {
                MessageBox.Show("Từ khoá không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                            
                if (libraryService.LichSuKhamNhanVien(cot,value,manv).Count==0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {                  
                    List<LichSuKham_NhanVien> listlskham = new List<LichSuKham_NhanVien>();                
                    listlskham = libraryService.LichSuKhamNhanVien(cot,value, manv);
                    for (int i = 0; i < listlskham.Count; i++)
                    {
                        listlskham[i].STT = i + 1;
                    }
                    dgvdsphieukham.DataSource = listlskham;
                    dgvdsphieukham.Columns[0].HeaderText = "STT"; dgvdsphieukham.Columns[0].Width = 40;
                    dgvdsphieukham.Columns[1].HeaderText = "Mã bệnh nhân"; dgvdsphieukham.Columns[1].Width = 110;
                    dgvdsphieukham.Columns[2].HeaderText = "Mã phiếu"; dgvdsphieukham.Columns[2].Width = 80;
                    dgvdsphieukham.Columns[3].HeaderText = "Họ tên bệnh nhân"; dgvdsphieukham.Columns[3].Width = 120;
                    dgvdsphieukham.Columns[4].HeaderText = "Ngày khám"; dgvdsphieukham.Columns[4].Width = 90;
                    dgvdsphieukham.Columns[5].HeaderText = "Đã thanh toán"; dgvdsphieukham.Columns[5].Width = 85;
                    dgvdsphieukham.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgvdsphieukham.RowHeadersVisible = false;
                }
            } 
        }

        public void Load_fLichSuKhamBacSi()
        {
            dgvdsphieukham.DataSource = libraryService.LichSuKhamNhanVien(manv);
            List<LichSuKham_NhanVien> listlskham = new List<LichSuKham_NhanVien>();

            listlskham = libraryService.LichSuKhamNhanVien(manv);
            for (int i = 0; i < listlskham.Count; i++)
            {
                listlskham[i].STT = i + 1;
            }
            dgvdsphieukham.DataSource = listlskham;
            dgvdsphieukham.Columns[0].HeaderText = "STT"; dgvdsphieukham.Columns[0].Width = 40;
            dgvdsphieukham.Columns[1].HeaderText = "Mã bệnh nhân"; dgvdsphieukham.Columns[1].Width = 110;
            dgvdsphieukham.Columns[2].HeaderText = "Mã phiếu"; dgvdsphieukham.Columns[2].Width = 80;
            dgvdsphieukham.Columns[3].HeaderText = "Họ tên bệnh nhân"; dgvdsphieukham.Columns[3].Width = 120;
            dgvdsphieukham.Columns[4].HeaderText = "Ngày khám"; dgvdsphieukham.Columns[4].Width = 90;
            dgvdsphieukham.Columns[5].HeaderText = "Đã thanh toán"; dgvdsphieukham.Columns[5].Width = 85;
            dgvdsphieukham.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvdsphieukham.RowHeadersVisible = false;
        }

        private void dgvdsphieukham_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            maphieu = GetMaPhieuKham();
            tenbn = GetTenBenhNhan();
            this.Close();
        }

        /// <summary>
        /// Hàm lấy mã phiếu khám của bệnh nhân từ bảng kết quả
        /// </summary>
        /// <returns></returns>
        public int GetMaPhieuKham()
        {     
            foreach (DataGridViewRow row in dgvdsphieukham.SelectedRows)
            {
                maphieu = (int)row.Cells[2].Value;
            }
            return maphieu;
        }

        /// <summary>
        /// Hàm lấy tên của bệnh nhân từ bảng kết quả
        /// </summary>
        /// <returns></returns>
        public string GetTenBenhNhan()
        {
            foreach (DataGridViewRow row in dgvdsphieukham.SelectedRows)
            {
                tenbn = (string)row.Cells[3].Value;
            }
            return tenbn;
        }

        /// <summary>
        /// Hàm kiểm tra từ khoá nhập vào có phải là số
        /// </summary>
        /// <param name="s"></param>
        /// <param name="cot"></param>
        /// <returns></returns>
        public bool StringToInt(string s,string cot)
        {
            if (cot == "MABN" || cot == "MAPHIEUKHAM")
            {
                try
                {
                    int.Parse(s);
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
            return true;
        }
    }
}
