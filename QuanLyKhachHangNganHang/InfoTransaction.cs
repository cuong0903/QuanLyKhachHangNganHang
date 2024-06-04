using QuanLyKhachHangNganHang.DAO;
using QuanLyKhachHangNganHang.DTO;
using System.Data;

namespace QuanLyKhachHangNganHang
{
    public partial class InfoTransaction : Form
    {
        private int accountID;
        private int transactionID;
        private int selectedTransactionID; // Biến cấp lớp để lưu TransactionID được chọn
        public InfoTransaction(Account account = null, int transactionID = 0)
        {
            InitializeComponent();
            this.accountID = account != null ? account.AccountID : 0; // Lấy AccountID từ đối tượng Account nếu không null
            LoadNameTypeAccountIntoCombobox(cbAccountTypeName); // Tải loại tài khoản vào combobox
            LoadAccountStatusIntoCombobox(cbAccountStatus); // Tải trạng thái tài khoản vào combobox
            LoadServiceNameByComboBox(cbServiceName); // Tải tên dịch vụ vào combobox
          

            if (account != null)
            {
                // Cập nhật dữ liệu tài khoản từ đối tượng Account
                UpdateAccountData(account);
            }

            if (transactionID != 0)
            {
                // Tải dữ liệu giao dịch từ TransactionID
                LoadTransactionData(transactionID);
            }
        }
        private Binding txbTransactionIDBinding;
        private Binding cbServiceNameBinding;
        private Binding dtpTransactionDateBinding;
        private Binding txbTransactionAmountBinding;
        private Binding txbTransactionDescriptionBinding;

        void AddTransactionHistoryByAccountBinding()
        {
            // Kiểm tra xem DataSource của dtgvTransaction có dữ liệu hay không
            if (dtgvTransaction.DataSource != null)
            {
                // Tạo các đối tượng DataBinding mới nếu chưa có
                if (txbTransactionIDBinding == null)
                {
                    txbTransactionIDBinding = new Binding("Text", dtgvTransaction.DataSource, "TransactionID", true, DataSourceUpdateMode.Never);
                    txbTransactionID.DataBindings.Add(txbTransactionIDBinding);
                }
                if (cbServiceNameBinding == null)
                {
                    cbServiceNameBinding = new Binding("Text", dtgvTransaction.DataSource, "ServiceName", true, DataSourceUpdateMode.Never);
                    cbServiceName.DataBindings.Add(cbServiceNameBinding);
                }
                if (dtpTransactionDateBinding == null)
                {
                    dtpTransactionDateBinding = new Binding("Text", dtgvTransaction.DataSource, "TransactionDate", true, DataSourceUpdateMode.Never);
                    dtpTransactionDate.DataBindings.Add(dtpTransactionDateBinding);
                }
                if (txbTransactionAmountBinding == null)
                {
                    txbTransactionAmountBinding = new Binding("Text", dtgvTransaction.DataSource, "TransactionAmount", true, DataSourceUpdateMode.Never);
                    txbTransactionAmount.DataBindings.Add(txbTransactionAmountBinding);
                }
                if (txbTransactionDescriptionBinding == null)
                {
                    txbTransactionDescriptionBinding = new Binding("Text", dtgvTransaction.DataSource, "TransactionDescription", true, DataSourceUpdateMode.Never);
                    txbTransactionDescription.DataBindings.Add(txbTransactionDescriptionBinding);
                }
            }
        }

        private void RefreshTransactionData(int accountID)
        {
            // Tải lại danh sách giao dịch
            LoadTransactionHistory(accountID);

            // Cập nhật số dư
            UpdateAccountBalance(accountID);
        }

        private void UpdateAccountBalance(int accountID)
        {
            // Lấy số dư mới nhất từ cơ sở dữ liệu
            decimal newBalance = AccountDAO.Instance.GetBalanceByAccountID(accountID);

            // Cập nhật số dư trên giao diện
            txbAccountBalance.Text = newBalance.ToString();
        }

        public void LoadTrantionDataFromSelectedRow(DataGridViewRow selectedRow)
        {
            // Trích xuất TransactionID từ dòng được chọn
            int transactionID = Convert.ToInt32(selectedRow.Cells["TransactionID"].Value);

            // Sử dụng AccountID để tải dữ liệu tài khoản
            LoadTransactionData(transactionID);
        }

        void LoadServiceNameByComboBox(ComboBox cb)
        {
            // Tải danh sách dịch vụ vào combobox
            cb.DataSource = ServiceDAO.Instance.GetListService();
            cb.DisplayMember = "ServiceName";
            cb.ValueMember = "ServiceID"; // Giả sử cột chứa ID của dịch vụ là "ServiceID"
        }

        void LoadNameTypeAccountIntoCombobox(ComboBox cb)
        {
            // Tải danh sách loại tài khoản vào combobox
            cb.DataSource = AccountTypeDAO.Instance.GetListAccount();
            cb.DisplayMember = "AccountTypeName";
            cb.ValueMember = "AccountTypeID"; // Giả sử cột chứa ID của loại tài khoản là "AccountTypeID"
        }

        private string GetServiceNameByID(int serviceID)
        {
            // Lấy tên dịch vụ từ ServiceID
            Service service = ServiceDAO.Instance.GetServiceByID(serviceID);
            return service != null ? service.ServiceName : string.Empty;
        }

        void LoadAccountStatusIntoCombobox(ComboBox cb, List<string> data = null)
        {
            // Thiết lập giá trị mặc định cho ComboBox cb
            cb.DropDownStyle = ComboBoxStyle.DropDownList;

            // Nếu danh sách dữ liệu không được cung cấp, sử dụng giá trị mặc định
            if (data == null)
            {
                cb.Items.AddRange(new object[] { "Hoạt động", "Không hoạt động" });
            }
            else
            {
                // Sử dụng danh sách dữ liệu được cung cấp
                cb.DataSource = data;
            }

            cb.SelectedIndex = 0; // Chọn giá trị đầu tiên làm giá trị mặc định
        }

        private Account GetNewAccountData()
        {
            InfoAccount infoAccount = new InfoAccount();
            if (infoAccount.ShowDialog() == DialogResult.OK)
            {
                // Lấy thông tin khách hàng mới từ InfoAccount form
                Account newAccount = infoAccount.GetNewAccount();

                // Lấy tên khách hàng từ AccountID
                string customerName = AccountDAO.Instance.GetCustomerNameByAccountID(newAccount.AccountID);
                txbCustomerrName.Text = customerName;
            }
            return null;
        }

        public Account GetNewAccount()
        {
            Account newAccount = new Account();

            // Lấy thông tin tài khoản từ các điều khiển trên form và gán vào newAccount
            newAccount.AccountID = int.Parse(txbAccountID.Text);

            // Lấy AccountTypeID từ ComboBox và gán vào newAccount
            if (cbAccountTypeName.SelectedItem != null)
            {
                var selectedTypeID = (AccountType)cbAccountTypeName.SelectedItem; // Sửa thành kiểu dữ liệu tương ứng
                newAccount.AccountTypeID = selectedTypeID.AccountTypeID;
            }

            // Lấy AccountStatus từ ComboBox và gán vào newAccount
            if (cbAccountStatus.SelectedItem != null)
            {
                var selectedStatus = cbAccountStatus.SelectedItem.ToString(); // Sửa thành kiểu dữ liệu tương ứng
                newAccount.AccountStatus = selectedStatus;
            }

            newAccount.AccountOpenDate = dtpAccountOpenDate.Value;
            newAccount.Balance = int.Parse(txbAccountBalance.Text); // Phải chuyển về decimal thay vì int
            newAccount.AccountNumber = txbAccountNumber.Text;

            return newAccount;
        }

        public void UpdateAccountData(Account account)
        {
            // Cập nhật dữ liệu tài khoản vào các điều khiển trên form
            txbAccountID.Text = account.AccountID.ToString();
            txbCustomerrName.Text = AccountDAO.Instance.GetCustomerNameByAccountID(account.AccountID); // Lấy tên khách hàng từ AccountID
            cbAccountTypeName.SelectedValue = account.AccountTypeID;
            cbAccountStatus.SelectedValue = account.AccountStatus;
            dtpAccountOpenDate.Value = account.AccountOpenDate ?? DateTime.Now; // Sử dụng giá trị mặc định nếu AccountOpenDate là null
            txbAccountBalance.Text = account.Balance.ToString();
            txbAccountNumber.Text = account.AccountNumber;

            // Nạp danh sách giao dịch của tài khoản
            LoadTransactionHistory(account.AccountID);
        }

        private void LoadTransactionHistory(int accountID)
        {
            // Lấy dữ liệu lịch sử giao dịch từ cơ sở dữ liệu
            List<TransactionHistory> transactions = TransactionHistoryDAO.Instance.GetTransactionsByAccountID(accountID);

            // Chuyển đổi danh sách giao dịch thành một DataTable
            DataTable transactionTable = ConvertTransactionsToDataTable(transactions);

            // Gán DataSource của DataGridView
            dtgvTransaction.DataSource = transactionTable;
            dtgvTransaction.Refresh(); // Hoặc dtgvTransaction.Invalidate();

            // Gọi phương thức AddTransactionHistoryByAccountBinding() sau khi đã có DataSource
            AddTransactionHistoryByAccountBinding();
        }

        private DataTable ConvertTransactionsToDataTable(List<TransactionHistory> transactions)
        {
            DataTable dataTable = new DataTable();

            // Thêm các cột vào DataTable
            dataTable.Columns.Add("TransactionID");
            dataTable.Columns.Add("AccountID");
            dataTable.Columns.Add("ServiceID");
            dataTable.Columns.Add("TransactionDate");
            dataTable.Columns.Add("TransactionAmount");
            dataTable.Columns.Add("TransactionDescription");
            dataTable.Columns.Add("ServiceName", typeof(string)); // Thêm cột ảo "ServiceName"

            // Thêm dữ liệu từ list vào DataTable
            foreach (TransactionHistory transaction in transactions)
            {
                DataRow row = dataTable.NewRow();
                row["TransactionID"] = transaction.TransactionID;
                row["AccountID"] = transaction.AccountID;
                row["ServiceID"] = transaction.ServiceID;
                row["TransactionDate"] = transaction.TransactionDate;
                row["TransactionAmount"] = transaction.TransactionAmount;
                row["TransactionDescription"] = transaction.TransactionDescription;
                row["ServiceName"] = GetServiceNameByID(transaction.ServiceID); // Gán tên dịch vụ vào cột ảo

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        public void LoadTransactionData(int transactionID)
        {
            // Lấy dữ liệu giao dịch từ TransactionID
            TransactionHistory transaction = TransactionHistoryDAO.Instance.GetTransactionByID(transactionID);

            if (transaction != null)
            {
                // Cập nhật dữ liệu giao dịch vào các điều khiển trên form
                txbTransactionID.Text = transaction.TransactionID.ToString();
                txbAccountID.Text = transaction.AccountID.ToString();
                cbServiceName.SelectedValue = transaction.ServiceID;
                dtpTransactionDate.Value = transaction.TransactionDate ?? DateTime.Now;
                txbTransactionAmount.Text = transaction.TransactionAmount.ToString();
                txbTransactionDescription.Text = transaction.TransactionDescription;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại và mở form ManagerAccount
            ManagerAccount f = new ManagerAccount();
            this.Hide();
            f.ShowDialog();
        }

        private void UpdateListTransactionAndAccountInOtherForms()
        {
            // Tìm và cập nhật danh sách tài khoản trong form ManagerAccount
            ManagerAccount managerAccountForm = Application.OpenForms.OfType<ManagerAccount>().FirstOrDefault();
            if (managerAccountForm != null)
            {
                managerAccountForm.RefreshListAccount();
            }

            // Tìm và cập nhật danh sách tài khoản trong form ManagerCustomer
            ManagerCustomer managerCustomerForm = Application.OpenForms.OfType<ManagerCustomer>().FirstOrDefault();
            if (managerCustomerForm != null)
            {
                managerCustomerForm.RefreshListCustomer();
            }

           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy thông tin khách hàng mới
            Account newAccount = GetNewAccount();

            if (newAccount != null)
            {
                // Cập nhật dữ liệu khách hàng mới vào các điều khiển trên form
                UpdateAccountData(newAccount);

                // Lấy thông tin giao dịch từ các điều khiển trên form
                int AccountID = newAccount.AccountID;
                int ServiceID = (int)cbServiceName.SelectedValue;
                DateTime? TransactionDate = dtpTransactionDate.Value;
                int TransactionAmount = Convert.ToInt32(txbTransactionAmount.Text);
                string TransactionDescription = txbTransactionDescription.Text;

                // Thêm giao dịch mới với thông tin từ các điều khiển
                TransactionHistoryDAO.Instance.InsertTransactionHistory(AccountID, ServiceID, TransactionDate, TransactionAmount, TransactionDescription);

                // Cập nhật lại danh sách giao dịch và tài khoản trong các form khác
                UpdateListTransactionAndAccountInOtherForms();
                // Load lại dữ liệu giao dịch và cập nhật số dư
                RefreshTransactionData(AccountID);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Lấy thông tin giao dịch từ các điều khiển trên giao diện
            int TransactionID = Convert.ToInt32(txbTransactionID.Text);
            int ServiceID = (int)cbServiceName.SelectedValue;
            DateTime? TransactionDate = dtpTransactionDate.Value;
            int TransactionAmount = Convert.ToInt32(txbTransactionAmount.Text);
            string TransactionDescription = txbTransactionDescription.Text;

            // Gọi phương thức cập nhật giao dịch từ TransactionHistoryDAO
            TransactionHistoryDAO.Instance.UpdateTransactionHistory(TransactionID, ServiceID, TransactionDate, TransactionAmount, TransactionDescription);

            // Sau khi cập nhật, tải lại danh sách giao dịch cho tài khoản
            LoadTransactionHistory(accountID);

            // Gọi phương thức AddTransactionHistoryByAccountBinding() sau khi đã có DataSource
            AddTransactionHistoryByAccountBinding();

            // Cập nhật lại danh sách giao dịch và tài khoản trong các form khác
            UpdateListTransactionAndAccountInOtherForms();

        }

        private void InfoTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo ô được nhấp không phải là header và nằm trong phạm vi số lượng dòng
            if (e.RowIndex >= 0 && e.RowIndex < dtgvTransaction.Rows.Count)
            {
                // Lấy TransactionID từ dòng được nhấp
                selectedTransactionID = Convert.ToInt32(dtgvTransaction.Rows[e.RowIndex].Cells["TransactionID"].Value);

                // Sử dụng TransactionID để tải dữ liệu giao dịch
                LoadTransactionData(selectedTransactionID);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedTransactionID != 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa giao dịch này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Xóa giao dịch với TransactionID đã chọn
                        TransactionHistoryDAO.Instance.DeleteTransactionHistory(selectedTransactionID);

                        // Tải lại lịch sử giao dịch sau khi xóa
                        LoadTransactionHistory(accountID);
                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ nếu có
                    }
                }
            }
        }

       

    }
}
