using QuanLyPhongKham.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.Repository.ADO
{
    public class DataProvider
    {
        #region Singleton Pattern

        private static DataProvider instance;

    

        /// <summary>
        /// kiểm tra xem đã tạo đối tượng DataProvider nào trước đó hay chưa.
        /// Nếu chưa thì tạo mới, nếu có rồi thì trả về đối tượng đó lun.
        /// </summary>
        public static DataProvider Instane
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }


        }


        /// <summary>
        /// private constructor để ngăn việc tạo đối tượng từ bên ngoài
        /// </summary>
        private DataProvider() { }


        #endregion


        #region Global Parameters

        /// <summary>
        /// Biến dùng để kết nối đến db
        /// </summary>
        private SqlConnection connection;

        /// <summary>
        /// Connection String dùng để kết nối db
        /// </summary>
        private string connectionString = LibraryParameter.connectionstring;


        /// <summary>
        /// Biến thực hiện câu lệnh sql
        /// </summary>
        SqlCommand sqlCommand;

        #endregion



        #region Methods


        /// <summary>
        /// Hàm excutescalar trả về giá trị là kết quả của số dòng đúng của câu truy vấn query
        /// </summary>
        /// <param name="query">là câu truy vấn sql</param>
        /// <param name="values">là các dữ liệu được đưa vào trong store procedure</param>
        /// <returns></returns>
        public int ExecuteScalar(string query, object[] values = null)
        {
            // Biến lưu kết quả trả về
            object data = 0;


            //Khối lệnh using nhằm đảm bảo connection lun được đóng 
            //sau khi thực hiện xong truy vấn
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                sqlCommand = new SqlCommand(query, connection);


                /*
                 * Kiểm tra xem dữ liệu đưa vào có tồn tại hay không
                 * Nếu có thì cắt chuỗi query và tìm các @parameter chứa trong đo
                 * sau đó dùng hàm addwithvalue để add value từ mảng values vào từng para
                 */
                if (values != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, values[i++]);
                        }
                    }
                }

                //thực thi truy vấn
                data = sqlCommand.ExecuteScalar();

                connection.Close();
            }

            return (int) data;
        }


        /// <summary>
        /// Hàm ExcuteNonQuery trả về số hàng affect bởi câu lệnh update, delete
        /// </summary>
        /// <param name="query">Câu lệnh sql</param>
        /// <param name="values">Mảng giá trị cho tham số truyền vào  câu lệnh sql</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string query, object[] values = null)
        {
            int row = 0;
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                sqlCommand = new SqlCommand(query, connection);

                if (values != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, values[i++]);
                        }
                    }
                }

                row = sqlCommand.ExecuteNonQuery();
                connection.Close();
            }

            return row;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public DataTable ExecuteReader(string query, object[] values = null)
        {
            DataTable table = new DataTable();

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                sqlCommand = new SqlCommand(query, connection);
                if (values != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, values[i++]);
                        }
                    }
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(table);
                connection.Close();
            }

            return table;

        }


        #endregion



    }
}
