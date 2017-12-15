using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.Infrastructure
{
    public static class ExtensionMethod
    {
        /// <summary>
        /// xuất ra file excel
        /// </summary>
        /// <param name="dataGridView">datagridview chứa dữ liệu</param>
        /// <param name="title">header của file excel</param>
        /// <param name="tenNhanVien">họ tên nhân viên tạo file lich su</param>
        /// <param name="NgayTao">ngày tạo file</param>
        /// <param name="fileName">tên của file</param>
        public static void ExportToExcel(DataGridView dataGridView, string title,String tenNhanVien, string NgayTao,string fileName)
        {
            // Creating a Excel object.
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                //lấy ra worksheet dùng để xuất dữ liệu
                worksheet = workbook.ActiveSheet;
                string sheetName = "Lịch sử tiếp nhận";
                worksheet.Name = sheetName;

                #region Phần đầu file

                
                Microsoft.Office.Interop.Excel.Range head = worksheet.get_Range("D1", "F1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Size = "18";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                #endregion Phần đầu file

                #region ColumnHeader

                Microsoft.Office.Interop.Excel.Range ten = worksheet.get_Range("B2", "B2");
                ten.Value = "Tên nhân viên";
                Microsoft.Office.Interop.Excel.Range tenNhanVienValue = worksheet.get_Range("C2", "C2");
                tenNhanVienValue.Value = tenNhanVien;
                Microsoft.Office.Interop.Excel.Range date = worksheet.get_Range("B3", "B3");
                date.Value = "Ngày tạo";
                Microsoft.Office.Interop.Excel.Range dateValue = worksheet.get_Range("C3", "C3");
                dateValue.Value = NgayTao;
                #endregion ColumnHeader

                #region fill header columns
                int column = dataGridView.ColumnCount;
                int row = dataGridView.RowCount;


                Object[,] headerColumn = new object[1, column];
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    headerColumn[0, i] = dataGridView.Columns[i].HeaderText;
                }

                Microsoft.Office.Interop.Excel.Range headerStart = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[5, 1];
                Microsoft.Office.Interop.Excel.Range headerEnd = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[5, column];
                Microsoft.Office.Interop.Excel.Range headerRange = worksheet.get_Range(headerStart, headerEnd);
                headerRange.Value = headerColumn; // đổ dữ liệu
                headerRange.Font.Bold = true;
                headerRange.Interior.ColorIndex = 15;

                headerRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                headerRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                #endregion


                #region Fill data

                int rowStart = 6; // hàng bắt đầu đổ dữ liệu

                int columnStart = 1; //cột bắt đầu

                int rowEnd = rowStart + row - 1; // hàng kết thúc

                int columnEnd = column; // cột kết thúc


                // Ô bắt đầu điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[rowStart, columnStart];

                // Ô kết thúc điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[rowEnd, columnEnd];

                // Lấy về vùng điền dữ liệu

                Microsoft.Office.Interop.Excel.Range rangeData = worksheet.get_Range(c1, c2);



                object[,] data = new object[row, column];
                for (int i = 0; i < row; i++)
                {

                    for (int j = 0; j < column; j++)
                    {
                        data[i, j] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                rangeData.Value = data;
                rangeData.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                #endregion





                #region auto fit all cells in worksheet after fill data

                worksheet.Columns.AutoFit();
                worksheet.Rows.AutoFit();

                #endregion auto fit all cells in worksheet after fill data

                #region SaveFileDialog

                SaveFileDialog saveDialog = new SaveFileDialog();
               
                saveDialog.FileName = fileName;
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show(string.Format("Tạo file {0} thành công", saveDialog.FileName), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                #endregion
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
    }
}
