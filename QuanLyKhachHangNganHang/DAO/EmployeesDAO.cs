using QuanLyKhachHangNganHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachHangNganHang.DAO
{
    internal class EmployeesDAO // Lớp DAO để tương tác với dữ liệu nhân viên
    {
        private static EmployeesDAO instance; // Biến instance để triển khai mẫu Singleton

        public static EmployeesDAO Instance
        {
            get { if (instance == null) instance = new EmployeesDAO(); return instance; } // Tạo instance nếu chưa có và trả về instance
            private set { instance = value; } // Thiết lập giá trị instance
        }
        private EmployeesDAO() { } // Hàm khởi tạo private để ngăn việc tạo instance từ bên ngoài

        // Phương thức đăng nhập, trả về true nếu đăng nhập thành công, ngược lại trả về false
        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @UserName, @PassWord"; // Câu truy vấn đăng nhập
            Dictionary<string, object> parameters = new Dictionary<string, object>(); // Tạo dictionary để lưu trữ tham số
            parameters["@UserName"] = userName; // Thêm tham số UserName
            parameters["@PassWord"] = passWord; // Thêm tham số PassWord

            DataTable result = DataProvider.Instance.ExcuteQuery(query, parameters); // Thực thi truy vấn và lưu kết quả

            return result.Rows.Count > 0; // Trả về true nếu có kết quả, ngược lại trả về false
        }

        // Phương thức lấy danh sách nhân viên
        public List<Employee> GetListEmplyees()
        {
            List<Employee> list = new List<Employee>(); // Khởi tạo danh sách nhân viên rỗng

            string query = "SELECT * FROM dbo.Employees"; // Câu truy vấn lấy danh sách nhân viên

            DataTable data = DataProvider.Instance.ExcuteQuery(query); // Thực thi truy vấn và lưu kết quả vào DataTable
            foreach (DataRow item in data.Rows)
            {
                Employee employees = new Employee(item); // Tạo đối tượng Employee từ dữ liệu mỗi hàng
                list.Add(employees); // Thêm đối tượng Employee vào danh sách
            }
            return list; // Trả về danh sách nhân viên
        }

        // Phương thức thêm nhân viên mới vào cơ sở dữ liệu
        public bool InsertEmployee(string EmployeeName, string DisplayName, string Password, int Position)
        {
            // Tạo mảng các tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeName", EmployeeName),
                new SqlParameter("@DisplayName", DisplayName),
                new SqlParameter("@Password", Password),
                new SqlParameter("@Position", Position)
            };

            // Query SQL với các tham số đã tạo
            string query = "INSERT INTO dbo.Employees (EmployeeName, DisplayName, Password, Position) VALUES (@EmployeeName, @DisplayName, @Password, @Position)";

            // Thực thi phương thức ExcuteNonQuery với query và parameters
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

            // Trả về true nếu có hàng được ảnh hưởng, ngược lại trả về false
            return result > 0;
        }

        // Phương thức cập nhật thông tin nhân viên
        public bool UpdateEmployee(int EmployeeID, string EmployeeName, string DisplayName, string Password, int Position)
        {
            // Tạo mảng các tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", EmployeeID),
                new SqlParameter("@EmployeeName", EmployeeName),
                new SqlParameter("@DisplayName", DisplayName),
                new SqlParameter("@Password", Password),
                new SqlParameter("@Position", Position)
            };

            // Query SQL với các tham số đã tạo
            string query = "UPDATE dbo.Employees SET EmployeeName = @EmployeeName, DisplayName = @DisplayName, Password = @Password, Position = @Position WHERE EmployeeID = @EmployeeID";

            // Thực thi phương thức ExecuteNonQuery với query và parameters
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

            // Trả về true nếu có hàng được ảnh hưởng, ngược lại trả về false
            return result > 0;
        }

        // Phương thức xóa nhân viên khỏi cơ sở dữ liệu
        public bool DeleteEmployee(int EmployeeID)
        {
            // Tạo mảng các tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", EmployeeID)
            };

            // Query SQL với các tham số đã tạo
            string query = "DELETE FROM dbo.Employees WHERE EmployeeID = @EmployeeID";

            // Thực thi phương thức ExcuteNonQuery với query và parameters
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

            // Trả về true nếu có hàng được ảnh hưởng, ngược lại trả về false
            return result > 0;
        }

        // Phương thức tìm kiếm nhân viên theo tên
        public List<Employee> SearchEmployeeName(string EmployeeName)
        {
            List<Employee> list = new List<Employee>(); // Khởi tạo danh sách nhân viên rỗng

            string query = string.Format("SELECT * FROM Employees WHERE EmployeeName like N'%{0}%'", EmployeeName); // Câu truy vấn tìm kiếm theo tên nhân viên

            DataTable data = DataProvider.Instance.ExcuteQuery(query); // Thực thi truy vấn và lưu kết quả vào DataTable
            foreach (DataRow item in data.Rows)
            {
                Employee employee = new Employee(item); // Tạo đối tượng Employee từ dữ liệu mỗi hàng
                list.Add(employee); // Thêm đối tượng Employee vào danh sách
            }
            return list; // Trả về danh sách nhân viên
        }
    }
}