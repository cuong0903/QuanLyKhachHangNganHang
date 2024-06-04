using QuanLyKhachHangNganHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace QuanLyKhachHangNganHang.DAO
{
    public class TransactionHistoryDAO
    {
        private static TransactionHistoryDAO instance;

        public static TransactionHistoryDAO Instance
        {
            get { if (instance == null) instance = new TransactionHistoryDAO(); return TransactionHistoryDAO.instance; }
            private set { TransactionHistoryDAO.instance = value; }
        }
        private TransactionHistoryDAO() { }
        public List<TransactionHistory> GetListTransactionHistory()
        {
            List<TransactionHistory> list = new List<TransactionHistory>();

            string query = "SELECT * FROM dbo.tblTransactionHistory";


            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TransactionHistory transactionHistory = new TransactionHistory(item);
                list.Add(transactionHistory);
            }
            return list;
        }

        internal List<TransactionHistory> SearchTransaction(string transactionSearch)
        {

            List<TransactionHistory> list = new List<TransactionHistory>();

            string query = string.Format("SELECT * FROM tblTransactionHistory WHERE TransactionID LIKE N'%{0}%'     OR AccountID LIKE N'%{0}%'     OR ServiceID LIKE N'%{0}%'     OR TransactionDate LIKE N'%{0}%'     OR TransactionAmount LIKE N'%{0}%'     OR TransactionDescription LIKE N'%{0}%';\r\n", transactionSearch);


            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TransactionHistory transaction = new TransactionHistory(item);
                list.Add(transaction);
            }
            return list;
        }


        public bool InsertTransactionHistory(int AccountID, int ServiceID, DateTime? TransactionDate, int TransactionAmount, string TransactionDescription)
        {
            // Lấy thông tin dịch vụ từ ServiceID
            Service service = ServiceDAO.Instance.GetServiceByID(ServiceID);

            // Kiểm tra loại dịch vụ để xác định số dư tăng hay giảm
            bool isDebit = service.ServiceName.Contains("Rút tiền") || service.ServiceName.Contains("Chuyển khoản");

            // Nếu là giao dịch rút tiền hoặc chuyển khoản, kiểm tra số dư tài khoản
            if (isDebit)
            {
                int currentBalance = AccountDAO.Instance.GetBalanceByAccountID(AccountID);
                if (TransactionAmount > currentBalance)
                {
                    MessageBox.Show("Số dư không đủ để thực hiện giao dịch này.");
                    return false;
                }
            }

            // Tạo mảng các tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@AccountID", AccountID),
        new SqlParameter("@ServiceID", ServiceID),
        new SqlParameter("@TransactionDate", TransactionDate),
        new SqlParameter("@TransactionAmount", TransactionAmount),
        new SqlParameter("@TransactionDescription", TransactionDescription)
            };

            // Query SQL với các tham số đã tạo
            string query = "INSERT INTO dbo.tblTransactionHistory (AccountID, ServiceID, TransactionDate, TransactionAmount, TransactionDescription) VALUES (@AccountID, @ServiceID, @TransactionDate, @TransactionAmount, @TransactionDescription)";

            // Thực thi phương thức ExcuteNonQuery với query và parameters
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

            // Kiểm tra xem có hàng được ảnh hưởng không và hiển thị thông báo tương ứng
            if (result > 0)
            {
                // Tính toán số tiền cần tăng/giảm
                int amountToUpdate = isDebit ? -TransactionAmount : TransactionAmount;

                // Cập nhật số dư tài khoản
                AccountDAO.Instance.UpdateBalance(AccountID, amountToUpdate);

                // Nếu là dịch vụ vay tín dụng, cập nhật giá trị Loans và CreditTerm trong bảng tblCustomer
                if (service.ServiceName.Contains("Vay tín dụng"))
                {
                    CustomerDAO.Instance.UpdateLoansAndCreditTerm(AccountDAO.Instance.GetAccountOwnerIDByAccountID(AccountID), TransactionAmount, "12 tháng");
                }

                MessageBox.Show("Giao dịch đã được thêm thành công và số dư tài khoản đã được cập nhật.");
                return true;
            }
            else
            {
                MessageBox.Show("Thêm giao dịch thất bại.");
                return false;
            }
        }

        public bool UpdateTransactionHistory(int TransactionID, int ServiceID, DateTime? TransactionDate, int TransactionAmount, string TransactionDescription)
        {
            // Tạo mảng các tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@TransactionID", TransactionID),

            new SqlParameter("@ServiceID", ServiceID),
            new SqlParameter("@TransactionDate", TransactionDate),
            new SqlParameter("@TransactionAmount", TransactionAmount),
            new SqlParameter("@TransactionDescription", TransactionDescription)
            };

            // Query SQL với các tham số đã tạo
            string query = "UPDATE dbo.tblTransactionHistory SET  ServiceID = @ServiceID, TransactionDate = @TransactionDate, TransactionAmount = @TransactionAmount, TransactionDescription = @TransactionDescription WHERE TransactionID = @TransactionID";

            // Thực thi phương thức ExecuteNonQuery với query và parameters
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

            // Kiểm tra xem có hàng được ảnh hưởng không và hiển thị thông báo tương ứng
            if (result > 0)
            {
                MessageBox.Show("Transaction history updated successfully.");
                return true;
            }
            else
            {
                MessageBox.Show("Failed to update transaction history.");
                return false;
            }
        }

        public bool DeleteTransactionHistory(int TransactionID)
        {


            // Tạo mảng các tham số
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@TransactionID", TransactionID)
            };

            // Query SQL với các tham số đã tạo
            string query = "DELETE FROM dbo.tblTransactionHistory WHERE TransactionID = @TransactionID";

            // Thực thi phương thức ExcuteNonQuery với query và parameters
            int result = DataProvider.Instance.ExcuteNonQuery(query, parameters);

            // Kiểm tra xem có hàng được ảnh hưởng không và hiển thị thông báo tương ứng
            if (result > 0)
            {
                MessageBox.Show("Transaction history deleted successfully.");
                return true;
            }
            else
            {
                MessageBox.Show("Failed to delete transaction history.");
                return false;
            }
        }

        internal bool TransactionHistoryExists(int transactionID)
        {
            string query = "SELECT COUNT(*) FROM dbo.tblTransactionHistory WHERE TransactionID = @TransactionID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@TransactionID", transactionID);

            int count = (int)DataProvider.Instance.ExcuteScalar(query, parameters);
            return count > 0;
        }

        public int GetAccountIDAfterInsert()
        {
            string query = "SELECT MAX(AccountID) AS LatestAccountID FROM dbo.tblAccount";

            // Không cần truyền tham số, vì không có tham số trong câu lệnh SQL

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

        public Account GetTransactionHistoryByID(int accountID)
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
        public TransactionHistory GetTransactionByID(int transactionID)
        {
            string query = "SELECT * FROM dbo.tblTransactionHistory WHERE transactionID = @transactionID";
            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        { "@transactionID", transactionID }
    };

            DataTable data = DataProvider.Instance.ExcuteQuery(query, parameters);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return new TransactionHistory(row);
            }
            return null;
        }
        public string GetCustomerNameByTransactionID(int transactionID)
        {
            string query = @"SELECT c.CustomerName
                     FROM tblTransactionHistory t
                     JOIN tblAccount a ON t.AccountID = a.AccountID
                     JOIN tblCustomer c ON a.AccountOwnerID = c.CustomerID
                     WHERE t.TransactionID = @TransactionID";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@TransactionID", transactionID }
            };

            object result = DataProvider.Instance.ExcuteScalar(query, parameters);

            return result?.ToString() ?? string.Empty;
        }

        public List<TransactionHistory> GetTransactionsByAccountID(int accountID)
        {
            List<TransactionHistory> list = new List<TransactionHistory>();

            string query = "SELECT * FROM tblTransactionHistory WHERE AccountID = @AccountID";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@AccountID", accountID);

            DataTable data = DataProvider.Instance.ExcuteQuery(query, parameters);

            foreach (DataRow item in data.Rows)
            {
                TransactionHistory transactionHistory = new TransactionHistory(item);
                list.Add(transactionHistory);
            }
            return list;
        }
    }
}
