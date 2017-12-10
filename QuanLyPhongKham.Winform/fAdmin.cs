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
    public partial class fAdmin : Form
    {
        private LibraryService libraryService;
        public fAdmin()
        {
            InitializeComponent();

            libraryService = ServiceFactory.GetLibraryService(LibraryParameter.persistancestrategy);


            //panelchitietkhovattuyte.Parent = panelchinh;
           // panelchitietphieunhapthuoc.Parent = panelchinh;
            panelkhothuoc.Parent = panelchinh;
            panelkhovattuyte.Parent = panelchinh;
        }

        private void treeViewQuanly_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch(treeViewQuanly.SelectedNode.Name)
            {
                case "NodePhieunhapthuoc": ShowPhieunhapthuoc(); break;
                case "NodePhieunhapvattu": ShowPhieunhapvattu(); break;
                case "NodeThuoc": ShowThuoc(); break;
                case "NodeVattuyte": ShowVattuyte(); break;
            }
        }
        private void ShowPhieunhapthuoc()
        {
            //panelchitietkhovattuyte.Visible = false;
           // panelchitietphieunhapthuoc.Visible = true;
            panelkhothuoc.Visible = false;
            panelkhovattuyte.Visible = false;
        }
        private void ShowPhieunhapvattu()
        {
            //panelchitietkhovattuyte.Visible = true;
            //panelchitietphieunhapthuoc.Visible = false;
            panelkhothuoc.Visible = false;
            panelkhovattuyte.Visible = false;
        }
        private void ShowThuoc()
        {
            //panelchitietkhovattuyte.Visible = false;
            //panelchitietphieunhapthuoc.Visible = false;
            panelkhothuoc.Visible = true;
            panelkhovattuyte.Visible = false;
        }
        private void ShowVattuyte()
        {
            //panelchitietkhovattuyte.Visible = false;
            //panelchitietphieunhapthuoc.Visible = false;
            panelkhothuoc.Visible = false;
            panelkhovattuyte.Visible = true;
        }
        //private void Load_fadminThuoc()
        //{
        //    Tableketquatimkiemthuoc.DataSource = libraryService.Danhsachthuoc();
        //    Tableketquatimkiemthuoc.Columns[0].HeaderText = "Mã thuốc"; Tableketquatimkiemthuoc.Columns[0].Width = 50;
        //    Tableketquatimkiemthuoc.Columns[1].HeaderText = "Tên thuốc"; Tableketquatimkiemthuoc.Columns[1].Width = 200;
        //    Tableketquatimkiemthuoc.Columns[2].HeaderText = "Đơn vị tính"; Tableketquatimkiemthuoc.Columns[2].Width = 60;
        //    Tableketquatimkiemthuoc.Columns[3].HeaderText = "Loại thuốc"; Tableketquatimkiemthuoc.Columns[3].Width = 250;
        //    Tableketquatimkiemthuoc.Columns[4].HeaderText = "Số lượng"; Tableketquatimkiemthuoc.Columns[4].Width = 50;
        //    Tableketquatimkiemthuoc.Columns[5].HeaderText = "Ghi chú"; Tableketquatimkiemthuoc.Columns[5].Width = 385;
        //    Tableketquatimkiemthuoc.RowHeadersVisible = false;
        //}

        private void fAdmin_Load(object sender, EventArgs e)
        {
            //Load_fadminThuoc();
            Load_fadminVTYT();
        }

        private void Tableketquatimkiemthuoc_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Tableketquatimkiemthuoc.SelectedRows)
            {
                
                txtMaT.Text = row.Cells[0].Value.ToString();
                txtTenthuoc.Text = row.Cells[1].Value.ToString();
                txtDVT.Text = row.Cells[2].Value.ToString();
                txtLoaithuoc.Text = row.Cells[3].Value.ToString();
                txtSLT.Text = row.Cells[4].Value.ToString();
                txtGhichu.Text = row.Cells[5].Value.ToString();
            }
        }

        //private void btTimkiemkhothuoc_Click(object sender, EventArgs e)
        //{
        //    string col = "";
        //    switch(comboBoxTimtheokhothuoc.SelectedIndex)
        //    {
        //        case 0:
        //            col = "MATHUOC";break;
        //        case 1:
        //            col = "TENTHUOC";break;
        //        case 2:
        //            col = "TENLOAI";break;
        //    }
        //    if (txttimkiemkhothuoc.Text == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập thông tin cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        if (libraryService.Danhsachthuoc(col, txttimkiemkhothuoc.Text.Trim()).Count == 0)
        //        {
        //            MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {

        //            Tableketquatimkiemthuoc.DataSource = libraryService.Danhsachthuoc(col, txttimkiemkhothuoc.Text.Trim());
        //            Tableketquatimkiemthuoc.Columns[0].HeaderText = "Mã thuốc"; Tableketquatimkiemthuoc.Columns[0].Width = 50;
        //            Tableketquatimkiemthuoc.Columns[1].HeaderText = "Tên thuốc"; Tableketquatimkiemthuoc.Columns[1].Width = 200;
        //            Tableketquatimkiemthuoc.Columns[2].HeaderText = "Đơn vị tính"; Tableketquatimkiemthuoc.Columns[2].Width = 60;
        //            Tableketquatimkiemthuoc.Columns[3].HeaderText = "Loại thuốc"; Tableketquatimkiemthuoc.Columns[3].Width = 250;
        //            Tableketquatimkiemthuoc.Columns[4].HeaderText = "Số lượng"; Tableketquatimkiemthuoc.Columns[4].Width = 50;
        //            Tableketquatimkiemthuoc.Columns[5].HeaderText = "Ghi chú"; Tableketquatimkiemthuoc.Columns[5].Width = 385;
        //            Tableketquatimkiemthuoc.RowHeadersVisible = false;

        //        }
        //    }
        //}
        private void Load_fadminVTYT()
        {
            TableKhovattuyte.DataSource = libraryService.DanhsachVTYT();
            TableKhovattuyte.Columns[0].HeaderText = "Mã vật tư y tế"; TableKhovattuyte.Columns[0].Width = 100;
            TableKhovattuyte.Columns[1].HeaderText = "Tên vật tư y tế"; TableKhovattuyte.Columns[1].Width = 200;
            TableKhovattuyte.Columns[2].HeaderText = "Đơn vị tính"; TableKhovattuyte.Columns[2].Width = 150;
            TableKhovattuyte.Columns[3].HeaderText = "Số lượng tồn"; TableKhovattuyte.Columns[3].Width = 100;
            
            TableKhovattuyte.RowHeadersVisible = false;
        }

        private void TableKhovattuyte_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in TableKhovattuyte.SelectedRows)
            {

                txtMaVTYT.Text = row.Cells[0].Value.ToString();
                txtTenVTYT.Text = row.Cells[1].Value.ToString();
                txtTenDVT.Text = row.Cells[2].Value.ToString();
                txtSoluongton.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btTimkiemkhovattu_Click(object sender, EventArgs e)
        {
            string col = "";
            switch (comboBoxTimtheokhovattu.SelectedIndex)
            {
                case 0:
                    col = "MAVTYT"; break;
                case 1:
                    col = "TENVTYT"; break;
                case 2:
                    col = "TENDVT"; break;
            }
            if (txtTimkiemkhovattu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (libraryService.TimkiemVTYT(col, txtTimkiemkhovattu.Text.Trim()).Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    TableKhovattuyte.DataSource = libraryService.TimkiemVTYT(col, txtTimkiemkhovattu.Text.Trim());

                    TableKhovattuyte.Columns[0].HeaderText = "Mã vật tư y tế"; TableKhovattuyte.Columns[0].Width = 100;
                    TableKhovattuyte.Columns[1].HeaderText = "Tên vật tư y tế"; TableKhovattuyte.Columns[1].Width = 200;
                    TableKhovattuyte.Columns[2].HeaderText = "Đơn vị tính"; TableKhovattuyte.Columns[2].Width = 150;
                    TableKhovattuyte.Columns[3].HeaderText = "Số lượng tồn"; TableKhovattuyte.Columns[3].Width = 100;
                    TableKhovattuyte.RowHeadersVisible= false;

                }
            }
        }
        
    }
}
