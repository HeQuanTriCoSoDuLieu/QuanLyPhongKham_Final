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
    public partial class fAddEditBenhNhan : Form
    {
        private bool isNew = true;
        private LibraryService libraryService;
        private BenhNhan benhNhan;
        public fAddEditBenhNhan()
        {
            InitializeComponent();
            benhNhan = new BenhNhan();
        }

        /// <summary>
        /// constructor cho việc update bệnh nhân
        /// </summary>
        /// <param name="title"></param>
        /// <param name="btnText"></param>
        /// <param name="benhNhan"></param>
        public fAddEditBenhNhan(string title, string btnText, BenhNhan benhNhan)
        {
            InitializeComponent();
            this.Text = title;
            btnAddEdit.Text = btnText;
            this.benhNhan = benhNhan;
            isNew = false;

            #region Code đổ dữ liệu vào các textbox
            txtHoTen.Text = benhNhan.HoTen;
            txtDiaChi.Text = benhNhan.DiaChi;
            txtDanToc.Text = benhNhan.DanToc;
            txtSDT.Text = benhNhan.SoDT;
            txtCMND.Text = benhNhan.SoCMND;
            txtTienSuBenh.Text = benhNhan.TienSu;
            dtpNgaySinh.Value = benhNhan.NgaySinh;
            if (benhNhan.GioiTinh.Equals("Nam"))
            {
                rdoNam.Checked = true;
            }else
            {
                rdoNu.Checked = true;
            }
            #endregion
        }

        public fAddEditBenhNhan(string title, string btnText)
        {
            InitializeComponent();
            this.Text = title;
            btnAddEdit.Text = btnText;
            benhNhan = new BenhNhan();
        }

        private void fAddEditBenhNhan_Load(object sender, EventArgs e)
        {
            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);
            txtHoTen.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// events cập nhật / thêm bệnh nhân mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEdit_Click(object sender, EventArgs e)
        {

            benhNhan.HoTen = txtHoTen.Text;
            benhNhan.DiaChi = txtDiaChi.Text;
            benhNhan.GioiTinh = rdoNam.Checked == true ? "Nam" : "Nữ";
            benhNhan.NgaySinh = dtpNgaySinh.Value;
            benhNhan.SoCMND = txtCMND.Text;
            benhNhan.SoDT = txtSDT.Text;
            benhNhan.TienSu = txtTienSuBenh.Text;
            benhNhan.DanToc = txtDanToc.Text;


            //code cho phần thêm mới bệnh nhân
            if (isNew)
            {
                //BenhNhan benhNhan = new BenhNhan();
               

                bool result = libraryService.ThemBenhNhan(benhNhan);

                if (result)
                {
                    if (DialogResult.OK == MessageBox.Show("Thêm bệnh nhân thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information))
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi không thêm được bệnh nhân");
                }
            }
            else
            {
                if (libraryService.UpdateBenhNhan(benhNhan))
                {
                    if (DialogResult.OK == MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information))
                    {
                        DialogResult = DialogResult.OK;
                    }
                    
                }
                
               
            }
        }
    }
}
