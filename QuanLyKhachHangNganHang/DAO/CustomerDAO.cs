using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
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
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set { CustomerDAO.instance = value; }
        }

        private CustomerDAO() { }

        // Lấy danh sách tất cả khách hàng từ cơ sở dữ liệu
        public List<Customer> GetListCustomer()
        {
            List<Customer> list = new List<Customer>();

            string query = "SELECT * FROM dbo.tblCustomer";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }
            return list;
        }

        // Lấy danh sách tất cả các trạng thái hôn nhân từ cơ sở dữ liệu
        public List<MaritalStatus> GetListMaritalStatus()
        {
            List<MaritalStatus> list = new List<MaritalStatus>();

            string query = "SELECT * FROM dbo.tblMaritalStatus";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MaritalStatus maritalStatus = new MaritalStatus(item);
                list.Add(maritalStatus);
            }
            return list;
        }

        // Lấy danh sách tất cả các nghề nghiệp từ cơ sở dữ liệu
        public List<Occupation> GetListOccupationStatus()
        {
            List<Occupation> list = new List<Occupation>();

            string query = "SELECT * FROM dbo.tblOccupation";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Occupation occupation = new Occupation(item);
                list.Add(occupation);
            }
            return list;
        }
        public bool InsertCustomer(string customerName,string CCCD, string address, string customerPhone,
         string email, string gender, int nextOfKin, DateTime? dateOfBirth, int occupationID, decimal averageIncome,
         int maritalStatusID, decimal debt, decimal loans, string creditTerm)
                {
            // Tạo mảng các tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
        
        new SqlParameter("@customerName", customerName),
         new SqlParameter("@CCCD", CCCD),
        new SqlParameter("@address", address),
        new SqlParameter("@customerPhone", customerPhone),
        new SqlParameter("@email", email),
        new SqlParameter("@gender", gender),
        new SqlParameter("@nextOfKin", nextOfKin),
        new SqlParameter("@dateOfBirth", dateOfBirth),
        new SqlParameter("@occupationID", occupationID),
        new SqlParameter("@averageIncome", averageIncome),
        new SqlParameter("@maritalStatusID", maritalStatusID),
        new SqlParameter("@debt", debt),
        new SqlParameter("@loans", loans),
        new SqlParameter("@creditTerm", creditTerm)
            };

            // Query SQL với các tham số đã tạo
            string query = "INSERT INTO dbo.tblCustomer (customerName, CCCD, address, customerPhone, email, gender, nextOfKin," +
                " dateOfBirth, occupationID, averageIncome, maritalStatusID, debt, loans, creditTerm)" +
                " VALUES (@customerName, @CCCD, @address, @customerPhone, @email, @gender, @nextOfKin," +
                " @dateOfBirth, @occupationID, @averageIncome, @maritalStatusID, @debt, @loans, @creditTerm)";

            // Thực thi phương thức ExcuteNonQuery với query và parameters
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

            // Trả về true nếu có hàng được ảnh hưởng, ngược lại trả về false
            return result > 0;
        }
        // Kiểm tra xem một khách hàng có tồn tại không
        public bool CustomerExists(int customerID)
        {
            string query = "SELECT COUNT(*) FROM tblCustomer WHERE CustomerID = @CustomerID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@CustomerID", customerID);

            int count = (int)DataProvider.Instance.ExcuteScalar(query, parameters);
            return count > 0;
        }

        // Lấy tên của một khách hàng dựa trên ID
        public string GetCustomerNameByID(int customerID)
        {
            string query = "SELECT CustomerName FROM tblCustomer WHERE CustomerID = @CustomerID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@CustomerID", customerID);

            object result = DataProvider.Instance.ExcuteScalar(query, parameters);
            return result != null ? result.ToString() : string.Empty;
        }

        // Phương thức thêm một khách hàng mới vào cơ sở dữ liệu
        public bool UpdateCustomer(int customerID, string customerName, string CCCD, string address, string customerPhone,
                                   string email, string gender, int nextOfKin, DateTime? dateOfBirth, int occupationID,
                                   decimal averageIncome, int maritalStatusID, decimal debt,
                                   decimal loans, string creditTerm)
        {
            // Tạo mảng các tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@customerID", customerID),
                new SqlParameter("@customerName", customerName),
                new SqlParameter("@CCCD", CCCD),
                new SqlParameter("@address", address),
                new SqlParameter("@customerPhone", customerPhone),
                new SqlParameter("@email", email),
                new SqlParameter("@gender", gender),
                new SqlParameter("@nextOfKin", nextOfKin),
                new SqlParameter("@dateOfBirth", dateOfBirth),
                new SqlParameter("@occupationID", occupationID),
                new SqlParameter("@averageIncome", averageIncome),
                new SqlParameter("@maritalStatusID", maritalStatusID),
                new SqlParameter("@debt", debt),
                new SqlParameter("@loans", loans),
                new SqlParameter("@creditTerm", creditTerm)
            };

            // Query SQL để cập nhật thông tin khách hàng
            string query = "UPDATE dbo.tblCustomer SET customerName = @customerName, CCCD = @CCCD, address = @address, " +
                           "customerPhone = @customerPhone, email = @email, gender = @gender, nextOfKin = @nextOfKin, " +
                           "dateOfBirth = @dateOfBirth, occupationID = @occupationID, averageIncome = @averageIncome, " +
                           "maritalStatusID = @maritalStatusID, debt = @debt, loans = @loans, " +
                           "creditTerm = @creditTerm WHERE customerID = @customerID";

            // Thực thi phương thức ExcuteNonQuery với query và parameters
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

            // Trả về true nếu có hàng được ảnh hưởng, ngược lại trả về false
            return result > 0;
        }
        // Lấy thông tin của một khách hàng dựa trên ID
        public Customer GetCustomerByID(int customerID)
        {
            string query = "SELECT * FROM dbo.tblCustomer WHERE CustomerID = @CustomerID";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@CustomerID", customerID }
            };

            DataTable data = DataProvider.Instance.ExcuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return new Customer(row);
            }
            return null;
        }
        // Xóa một khách hàng khỏi cơ sở dữ liệu
        public bool DeleteCustomer(int customerID)
        {
            try
            {
                // Lấy danh sách tài khoản của khách hàng
                List<Account> customerAccounts = AccountDAO.Instance.GetAccountsByCustomerID(customerID);

                foreach (Account account in customerAccounts)
                {

                    // Xóa tài khoản
                    AccountDAO.Instance.DeleteAccount(account.AccountID);
                }

                // Xóa thông tin người thân của khách hàng
                string deleteNextOfKinQuery = "DELETE FROM tblNextOfKin WHERE CustomerID = @CustomerID";
                SqlParameter[] deleteNextOfKinParameters = { new SqlParameter("@CustomerID", customerID) };
                DataProvider.Instance.ExcuteNonQuery(deleteNextOfKinQuery, deleteNextOfKinParameters);

                // Xóa khách hàng
                string deleteCustomerQuery = "DELETE FROM tblCustomer WHERE CustomerID = @CustomerID";
                SqlParameter[] deleteCustomerParameters = { new SqlParameter("@CustomerID", customerID) };
                int rowsAffected = DataProvider.Instance.ExcuteNonQuery(deleteCustomerQuery, deleteCustomerParameters);

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ tại đây
                return false;
            }
        }
        // Tìm kiếm khách hàng theo các tiêu chí
        internal List<Customer> SearchCustomer(string customerSearch)
        {
            List<Customer> list = new List<Customer>();

            string query = string.Format("SELECT * FROM tblCustomer WHERE CustomerID LIKE N'%{0}%' OR CustomerName LIKE N'%{0}%' OR CCCD LIKE N'%{0}%' OR Address LIKE N'%{0}%' OR CustomerPhone LIKE N'%{0}%' OR Email LIKE N'%{0}%' OR Gender LIKE N'%{0}%' OR NextOfKin LIKE N'%{0}%' OR DateOfBirth LIKE N'%{0}%' OR OccupationID LIKE N'%{0}%' OR AverageIncome LIKE N'%{0}%' OR MaritalStatusID LIKE N'%{0}%' OR Debt LIKE N'%{0}%' OR Loans LIKE N'%{0}%' OR CreditTerm LIKE N'%{0}%';\r\n", customerSearch);


            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }
            return list;
        }
        // Cập nhật số tiền vay và điều khoản vay của một khách hàng
        public void UpdateLoansAndCreditTerm(int customerID, decimal loanAmount, string creditTerm)
        {
            string query = "UPDATE dbo.tblCustomer SET Loans = Loans + @LoanAmount, CreditTerm = @CreditTerm WHERE CustomerID = @CustomerID";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@LoanAmount", loanAmount),
            new SqlParameter("@CreditTerm", creditTerm),
            new SqlParameter("@CustomerID", customerID)
            };

            DataProvider.Instance.ExcuteNonQuery(query, parameters);
        }


        /*public Dictionary<string, object> ConvertToDictionary(SqlParameter[] parameters)
        {
            if (parameters == null)
                return null;

            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            foreach (var parameter in parameters)
            {
                dictionary.Add(parameter.ParameterName, parameter.Value);
            }
            return dictionary;
        }*/

    }
}
