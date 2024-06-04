using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QuanLyKhachHangNganHang.DAO
{
    internal class DataProvider
    {
        private static DataProvider instance; // Ctrl + R + E

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }
        
        private string connectionSTR = "Data Source =.\\SQLEXPRESS;Initial Catalog = QuanLyKhachHangNganHang; Integrated Security = True; Encrypt=False";
        /*        Trả ra dòng kết quả*/
        public DataTable ExcuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            // Tạo một đối tượng DataTable để lưu trữ kết quả truy vấn
            DataTable data = new DataTable();

            // Sử dụng khối using để đảm bảo rằng kết nối SQL sẽ được đóng đúng cách sau khi sử dụng
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // Mở kết nối đến cơ sở dữ liệu
                connection.Open();

                // Tạo một đối tượng SqlCommand để thực thi truy vấn
                SqlCommand command = new SqlCommand(query, connection);

                // Nếu có các tham số, thêm chúng vào đối tượng SqlCommand
                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }

                // Tạo một đối tượng SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu và đổ vào DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Thực hiện truy vấn và điền kết quả vào DataTable
                adapter.Fill(data);

                // Đóng kết nối
                connection.Close();
            }

            // Trả về DataTable chứa kết quả truy vấn
            return data;
        }

        public int ExcuteNonQuery(string query, SqlParameter[] parameters)
        {
            // Biến để lưu trữ số lượng hàng bị ảnh hưởng bởi truy vấn
            int affectedRows = 0;

            // Sử dụng khối using để đảm bảo rằng kết nối SQL sẽ được đóng đúng cách sau khi sử dụng
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // Mở kết nối đến cơ sở dữ liệu
                connection.Open();

                // Tạo một đối tượng SqlCommand để thực thi truy vấn
                SqlCommand command = new SqlCommand(query, connection);

                // Bắt buộc phải có tham số, nếu không sẽ ném ra ngoại lệ
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                // Thêm các tham số vào đối tượng SqlCommand
                command.Parameters.AddRange(parameters);

                try
                {
                    // Thực thi câu lệnh SQL và trả về số hàng ảnh hưởng
                    affectedRows = command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    // Xử lý lỗi SQL và trả về giá trị -1 để thông báo lỗi
                    Console.WriteLine($"SQL Exception: {ex.Message}");
                    affectedRows = -1;
                }
            }

            // Trả về số hàng bị ảnh hưởng bởi truy vấn
            return affectedRows;
        }

        public object ExcuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            // Biến để lưu trữ giá trị trả về của truy vấn
            object data = 0;

            // Sử dụng khối using để đảm bảo rằng kết nối SQL sẽ được đóng đúng cách sau khi sử dụng
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // Mở kết nối đến cơ sở dữ liệu
                connection.Open();

                // Tạo một đối tượng SqlCommand để thực thi truy vấn
                SqlCommand command = new SqlCommand(query, connection);

                // Nếu có các tham số, thêm chúng vào đối tượng SqlCommand
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }

                // Thực thi truy vấn và lấy giá trị đầu tiên trong kết quả trả về
                data = command.ExecuteScalar();

                // Đóng kết nối
                connection.Close();
            }

            // Trả về giá trị của truy vấn
            return data;
        }


    }
}
