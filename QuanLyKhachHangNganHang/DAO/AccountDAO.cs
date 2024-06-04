using QuanLyKhachHangNganHang.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace QuanLyKhachHangNganHang.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        // Singleton pattern: chỉ tạo ra một instance duy nhất của AccountDAO
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        private AccountDAO() { }

        // Lấy danh sách tài khoản từ database
        public List<Account> GetListAccount()
        {
            List<Account> list = new List<Account>();

            string query = "SELECT * FROM dbo.tblAccount";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                list.Add(account);
            }
            return list;
        }

        // Tìm kiếm tài khoản theo thông tin nhập vào
        internal List<Account> SearchAccount(string AccountSearch)
        {
            List<Account> list = new List<Account>();

            string query = string.Format("SELECT * FROM tblAccount WHERE AccountID LIKE N'%{0}%' OR AccountOwnerID LIKE N'%{0}%' OR AccountTypeID LIKE N'%{0}%' OR AccountStatus LIKE N'%{0}%' OR AccountOpenDate LIKE N'%{0}%' OR Balance LIKE N'%{0}%' OR AccountNumber LIKE N'%{0}%';\r\n", AccountSearch);

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account Account = new Account(item);
                list.Add(Account);
            }
            return list;
        }

        // Lấy danh sách tài khoản của một khách hàng dựa trên ID của khách hàng
        public List<Account> GetAccountsByCustomerID(int customerID)
        {
            List<Account> accounts = new List<Account>();

            string query = "SELECT a.* FROM tblAccount a INNER JOIN tblCustomer c ON a.AccountOwnerID = c.CustomerID WHERE c.CustomerID = @customerID";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@customerID", customerID);

            DataTable data = DataProvider.Instance.ExcuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                Account account = new Account(row);
                accounts.Add(account);
            }

            return accounts;
        }

        // Thêm một tài khoản mới vào database
        public void InsertAccount(int customerID, int accountTypeID, string accountStatus, DateTime? accountOpenDate, int balance, string accountNumber)
        {
            try
            {
                string insertQuery = "INSERT INTO dbo.tblAccount " +
                       "([AccountOwnerID], [AccountTypeID], [AccountStatus], [AccountOpenDate], [Balance], [AccountNumber]) " +
                       "VALUES (@AccountOwnerID, @AccountTypeID, @AccountStatus, @AccountOpenDate, @Balance, @AccountNumber)";

                var parameters = new SqlParameter[]
                {
            new SqlParameter("@AccountOwnerID", customerID),
            new SqlParameter("@AccountTypeID", accountTypeID),
            new SqlParameter("@AccountStatus", accountStatus),
            new SqlParameter("@AccountOpenDate", accountOpenDate.HasValue ? (object)accountOpenDate.Value : DBNull.Value),
            new SqlParameter("@Balance", balance),
            new SqlParameter("@AccountNumber", accountNumber)
                };

                int affectedRows = DataProvider.Instance.ExcuteNonQuery(insertQuery, parameters);

                if (affectedRows > 0)
                {
                    MessageBox.Show("Thêm tài khoản thành công.");
                }
                else
                {
                    MessageBox.Show("Không thể thêm tài khoản.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tài khoản: " + ex.Message);
            }
        }

        // Lấy ID của khách hàng sau khi đã thêm mới vào database
        public int GetCustomerIDAfterInsert()
        {
            string query = "SELECT MAX(CustomerID) AS LatestCustomerID FROM dbo.tblCustomer;";

            object result = DataProvider.Instance.ExcuteScalar(query);

            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                return 0;
            }
        }

        // Cập nhật thông tin tài khoản
        public void EditAccount(int accountID, int accountTypeID, string accountStatus, DateTime? accountOpenDate, int balance, string accountNumber)
        {
            try
            {
                string updateQuery = "UPDATE dbo.tblAccount " +
                                     "SET [AccountTypeID] = @AccountTypeID, " +
                                         "[AccountStatus] = @AccountStatus, " +
                                         "[AccountOpenDate] = @AccountOpenDate, " +
                                         "[Balance] = @Balance, " +
                                         "[AccountNumber] = @AccountNumber " +
                                     "WHERE [AccountID] = @AccountID";

                var parameters = new SqlParameter[]
                {
            new SqlParameter("@AccountTypeID", accountTypeID),
            new SqlParameter("@AccountStatus", accountStatus),
            new SqlParameter("@AccountOpenDate", accountOpenDate.HasValue ? (object)accountOpenDate.Value : DBNull.Value),
            new SqlParameter("@Balance", balance),
            new SqlParameter("@AccountNumber", accountNumber),
            new SqlParameter("@AccountID", accountID)
                };

                int affectedRows = DataProvider.Instance.ExcuteNonQuery(updateQuery, parameters);

                if (affectedRows > 0)
                {
                    MessageBox.Show("Cập nhật thông tin tài khoản thành công.");
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật thông tin tài khoản.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin tài khoản: " + ex.Message);
            }
        }

        // Lấy thông tin tài khoản dựa trên ID của tài khoản
        public Account GetAccountByID(int accountID)
        {
            string query = "SELECT * FROM dbo.tblAccount WHERE AccountID = @AccountID";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@AccountID", accountID }
            };

            DataTable data = DataProvider.Instance.ExcuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return new Account(row);
            }
            return null;
        }

        // Xóa tài khoản dựa trên ID của tài khoản
        public void DeleteAccount(int accountID)
        {
            try
            {
                // Xóa các giao dịch liên quan đến tài khoản từ bảng tblTransactionHistory
                string deleteTransactionsQuery = "DELETE FROM dbo.tblTransactionHistory WHERE [AccountID] = @AccountID";

                // Tạo tham số mới cho việc xóa giao dịch
                SqlParameter transactionParameter = new SqlParameter("@AccountID", accountID);

                // Thực thi câu lệnh SQL và lấy số hàng bị ảnh hưởng
                int affectedTransactionsRows = DataProvider.Instance.ExcuteNonQuery(deleteTransactionsQuery, new SqlParameter[] { transactionParameter });

                // Tiếp tục xóa tài khoản nếu không có lỗi xảy ra khi xóa giao dịch
                if (affectedTransactionsRows >= 0)
                {
                    // Tạo tham số mới cho việc xóa tài khoản
                    SqlParameter accountParameter = new SqlParameter("@AccountID", accountID);

                    // Tạo câu lệnh SQL để xóa tài khoản từ bảng tblAccount
                    string deleteAccountQuery = "DELETE FROM dbo.tblAccount WHERE [AccountID] = @AccountID";

                    // Thực thi câu lệnh SQL và lấy số hàng bị ảnh hưởng
                    int affectedAccountRows = DataProvider.Instance.ExcuteNonQuery(deleteAccountQuery, new SqlParameter[] { accountParameter });

                    // Kiểm tra xem có hàng nào bị ảnh hưởng không
                    if (affectedAccountRows > 0)
                    {
                        MessageBox.Show("Xóa tài khoản thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa tài khoản.");
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa tài khoản do lỗi xảy ra khi xóa giao dịch.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa tài khoản: " + ex.Message);
            }
        }
        public Dictionary<string, object> ConvertToDictionary(SqlParameter[] parameters)
        {
            if (parameters == null)
                return null;

            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            foreach (var parameter in parameters)
            {
                dictionary.Add(parameter.ParameterName, parameter.Value);
            }
            return dictionary;
        }
        // Kiểm tra xem một tài khoản có tồn tại hay không dựa trên ID của tài khoản
        public bool AccountExists(int AccountID)
        {
            string query = "SELECT COUNT(*) FROM dbo.tblAccount WHERE AccountID = @AccountID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountID", AccountID);

            int count = (int)DataProvider.Instance.ExcuteScalar(query, parameters);
            return count > 0;
        }
        // Lấy tên của khách hàng dựa trên ID của tài khoản
        public string GetCustomerNameByAccountID(int accountID)
        {
            string query = @"SELECT c.CustomerName
                     FROM tblAccount a
                     JOIN tblCustomer c ON a.AccountOwnerID = c.CustomerID
                     WHERE a.AccountID = @AccountID";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@AccountID", accountID }
            };

            object result = DataProvider.Instance.ExcuteScalar(query, parameters);

            return result?.ToString() ?? string.Empty;
        }

        // Cập nhật số dư của tài khoản dựa trên ID của tài khoản và số tiền cần cập nhật
        public void UpdateBalance(int accountID, int amount)
        {
            string query = "UPDATE dbo.tblAccount SET Balance = Balance + @Amount WHERE AccountID = @AccountID";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Amount", amount),
            new SqlParameter("@AccountID", accountID)
            };

            DataProvider.Instance.ExcuteNonQuery(query, parameters);
        }

        // Lấy số dư của tài khoản dựa trên ID của tài khoản
        public int GetBalanceByAccountID(int accountID)
        {
            string query = "SELECT Balance FROM dbo.tblAccount WHERE AccountID = @AccountID";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@AccountID", accountID }
            };

            object result = DataProvider.Instance.ExcuteScalar(query, parameters);
            return Convert.ToInt32(result);
        }

        // Lấy ID của chủ sở hữu tài khoản dựa trên ID của tài khoản
        public int GetAccountOwnerIDByAccountID(int accountID)
        {
            string query = "SELECT AccountOwnerID FROM dbo.tblAccount WHERE AccountID = @AccountID";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@AccountID", accountID }
            };

            object result = DataProvider.Instance.ExcuteScalar(query, parameters);
            return Convert.ToInt32(result);
        }
    }
}

