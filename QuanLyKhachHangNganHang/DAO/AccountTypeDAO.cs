using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachHangNganHang.DTO;

namespace QuanLyKhachHangNganHang.DAO
{
    public class AccountTypeDAO
    {
        private static AccountTypeDAO instance;

        public static AccountTypeDAO Instance
        {
            get { if (instance == null) instance = new AccountTypeDAO(); return AccountTypeDAO.instance; }
            private set { AccountTypeDAO.instance = value; }
        }

        private AccountTypeDAO() { }

        // Phương thức lấy danh sách loại tài khoản
        public List<AccountType> GetListAccount()
        {
            List<AccountType> list = new List<AccountType>();

            // Câu truy vấn SQL để lấy danh sách loại tài khoản
            string query = "SELECT * FROM dbo.tblAccountType";

            // Thực hiện câu truy vấn và lưu kết quả vào DataTable
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                // Tạo đối tượng AccountType từ dữ liệu của mỗi dòng và thêm vào danh sách
                AccountType accountType = new AccountType(item);
                list.Add(accountType);
            }
            return list;
        }

        // Phương thức thêm một loại tài khoản mới
        public bool InsertAccountType(string AccountTypeName, string AccountTypeDescription, string InterestRate)
        {
            // Tạo mảng các tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@AccountTypeName", AccountTypeName),
                new SqlParameter("@AccountTypeDescription", AccountTypeDescription),
                new SqlParameter("@InterestRate", InterestRate)
            };

            // Câu truy vấn SQL để thêm loại tài khoản mới
            string query = "INSERT INTO dbo.tblAccountType (AccountTypeName, AccountTypeDescription, InterestRate) VALUES (@AccountTypeName, @AccountTypeDescription, @InterestRate)";

            // Thực thi câu truy vấn và kiểm tra xem có hàng nào bị ảnh hưởng không
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);
            return result > 0;
        }

        // Phương thức cập nhật thông tin một loại tài khoản
        public bool UpdateAccount(int AccountTypeID, string AccountTypeName, string AccountTypeDescription, string InterestRate)
        {
            // Tạo mảng các tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@AccountTypeID", AccountTypeID),
                new SqlParameter("@AccountTypeName", AccountTypeName),
                new SqlParameter("@AccountTypeDescription", AccountTypeDescription),
                new SqlParameter("@InterestRate", InterestRate)
            };

            // Câu truy vấn SQL để cập nhật thông tin loại tài khoản
            string query = "UPDATE dbo.tblAccountType SET AccountTypeName = @AccountTypeName, AccountTypeDescription = @AccountTypeDescription, InterestRate = @InterestRate WHERE AccountTypeID = @AccountTypeID";

            // Thực thi câu truy vấn và kiểm tra xem có hàng nào bị ảnh hưởng không
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);
            return result > 0;
        }

        // Phương thức xóa một loại tài khoản
        public bool DeleteAccountType(int accountTypeID)
        {
            // Tạo mảng các tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@accountTypeID", accountTypeID)
            };

            // Câu truy vấn SQL để xóa một loại tài khoản
            string query = "DELETE FROM tblAccountType WHERE accountTypeID = @accountTypeID";

            // Thực thi câu truy vấn và kiểm tra xem có hàng nào bị ảnh hưởng không
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);
            return result > 0;
        }

        // Phương thức tìm kiếm loại tài khoản theo tên
        public List<AccountType> SearchAccountTypeName(string accountTypeName)
        {
            List<AccountType> list = new List<AccountType>();

            // Câu truy vấn SQL để tìm kiếm loại tài khoản
            string query = string.Format("SELECT * FROM tblAccountType WHERE AccountTypeID LIKE N'%{0}%' OR AccountTypeName LIKE N'%{0}%' OR AccountTypeDescription LIKE N'%{0}%' OR InterestRate LIKE N'%{0}%' ", accountTypeName);

            // Thực hiện câu truy vấn và lưu kết quả vào DataTable
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                // Tạo đối tượng AccountType từ dữ liệu của mỗi dòng và thêm vào danh sách
                AccountType AccountType = new AccountType(item);
                list.Add(AccountType);
            }
            return list;
        }
    }
}
