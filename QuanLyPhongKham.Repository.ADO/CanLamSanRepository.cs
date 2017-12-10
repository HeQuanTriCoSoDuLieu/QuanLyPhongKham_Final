using QuanLyPhongKham.Model.DTO;
using QuanLyPhongKham.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace QuanLyPhongKham.Repository.ADO
{
    public class CanLamSanRepository : ICanLamSanRepository
    {
        public List<CanLamSan> DanhSachLoaiCLS(int macls)
        {
            List<CanLamSan> list = new List<CanLamSan>();
            DataTable table = DataProvider.Instane.ExecuteReader("EXEC [dbo].[SP_Getbyid_CLS] @macls ", new object[] { macls });
            foreach (DataRow row in table.Rows)
            {
                CanLamSan cls = new CanLamSan(row);
                list.Add(cls);
            }
            return list;
        }

        public DataTable GetCLS(string filePath)
        {
            DataTable table = new DataTable();
            string connString = connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=Excel 12.0";

            // Tạo đối tượng kết nối
            OleDbConnection oledbConn = new OleDbConnection(connString);
            try
            {
                // Mở kết nối
                oledbConn.Open();

                // Tạo đối tượng OleDBCommand và query data từ sheet có tên "Sheet1"
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", oledbConn);

                // Tạo đối tượng OleDbDataAdapter để thực thi việc query lấy dữ liệu từ tập tin excel
                OleDbDataAdapter oleda = new OleDbDataAdapter();

                oleda.SelectCommand = cmd;

                // Tạo đối tượng DataSet để hứng dữ liệu từ tập tin excel


                // Đổ đữ liệu từ tập excel vào DataSet
                oleda.Fill(table);

                oledbConn.Close();
            }
            catch
            {
            }
            return table;
        }
    }
}
