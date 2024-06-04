using QuanLyKhachHangNganHang.DAO;
using QuanLyKhachHangNganHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachHangNganHang
{
    public partial class ManagerAccount : Form
    {
        private int accountID;

        public ManagerAccount()
        {
            InitializeComponent();
            load();

        }
        void load()
        {
            LoadListAccountType(); // Gắn nguồn dữ liệu ban đầu cho DataGridView
            LoadListAccount();
            LoadNameTypeAccountIntoCombobox(cbAccountTypeName);
            LoadAccountStatusIntoCombobox(cbAccountStatus);
            AddAccountBinding();


            /* AddAccountBinding(); // Gọi hàm để ánh xạ dữ liệu cho các controls*/
        }

        List<AccountType> SearchAccountTypeByName(string accountTypeName)
        {
            List<AccountType> AccountTypelist = AccountTypeDAO.Instance.SearchAccountTypeName(accountTypeName);
            return AccountTypelist;
        }
        void LoadListAccount()
        {
            dtgvAccount.DataSource = AccountDAO.Instance.GetListAccount();
        }
        private DataTable ConvertCustomersToDataTable(List<Customer> customers)
        {
            DataTable dataTable = new DataTable();

            // Thêm các cột vào DataTable
            dataTable.Columns.Add("CustomerID");
            dataTable.Columns.Add("CustomerName");
            dataTable.Columns.Add("CustomerPhone");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Loans");
            dataTable.Columns.Add("CCCD");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("CreditTerm");
            dataTable.Columns.Add("Debt");
            dataTable.Columns.Add("AverageIncome");
            dataTable.Columns.Add("MaritalStatusID");
            dataTable.Columns.Add("OccupationID");
            dataTable.Columns.Add("Gender"); // Thêm cột Gender

            // Thêm dữ liệu từ List<Customer> vào DataTable
            foreach (Customer customer in customers)
            {
                DataRow row = dataTable.NewRow();
                row["CustomerID"] = customer.CustomerID;
                row["CustomerName"] = customer.CustomerName;
                row["CustomerPhone"] = customer.CustomerPhone;
                row["Email"] = customer.Email;
                row["Loans"] = customer.Loans;
                row["CCCD"] = customer.CCCD;
                row["Address"] = customer.Address;
                row["CreditTerm"] = customer.CreditTerm;
                row["Debt"] = customer.Debt;
                row["AverageIncome"] = customer.AverageIncome;
                row["MaritalStatusID"] = customer.MaritalStatusID;
                row["OccupationID"] = customer.OccupationID;
                row["Gender"] = customer.Gender; // Gán giá trị Gender
                dataTable.Rows.Add(row);
            }

            return dataTable;
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
                cb.Items.AddRange(data.ToArray());
            }

            cb.SelectedIndex = 0; // Chọn giá trị đầu tiên làm giá trị mặc định
        }


        void AddAccountBinding()
        {
            // Gỡ bỏ tất cả các ánh xạ dữ liệu cũ trước khi thêm mới
            txbAccountTypeID.DataBindings.Clear();
            txbAccountTypeName.DataBindings.Clear();
            txbAccountTypeDescription.DataBindings.Clear();
            txbInterestRate.DataBindings.Clear();

            if (txbAccountID.DataBindings.Count == 0)
            {
                txbAccountID.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "AccountID", true, DataSourceUpdateMode.Never));
            }
            if (txbAccountNumber.DataBindings.Count == 0)
            {
                txbAccountNumber.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "AccountNumber", true, DataSourceUpdateMode.Never));
            }
            if (txbAccountBalance.DataBindings.Count == 0)
            {
                txbAccountBalance.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Balance", true, DataSourceUpdateMode.Never));
            }
            if (dtgvAccount.Rows.Count > 0)
            {
                dtgvAccount.Rows[0].Selected = true;

            }

        }

        public void RefreshListAccount()
        {
            LoadListAccount();
            
        }


        void LoadListAccountType()
        {
            dtgvAccountType.DataSource = AccountTypeDAO.Instance.GetListAccount();
            AddAccountTypeBinding();

        }
        void AddAccountTypeBinding()
        {
            // Gỡ bỏ tất cả các ánh xạ dữ liệu cũ trước khi thêm mới
            txbAccountTypeID.DataBindings.Clear();
            txbAccountTypeName.DataBindings.Clear();
            txbAccountTypeDescription.DataBindings.Clear();
            txbInterestRate.DataBindings.Clear();

            // Kiểm tra nếu các TextBox không bị null
            if (txbAccountTypeID != null && txbAccountTypeName != null && txbAccountTypeDescription != null && txbInterestRate != null)
            {
                // Kiểm tra nếu DataSource của dtgvAccountType không bị null và có dữ liệu
                if (dtgvAccountType.DataSource != null && dtgvAccountType.Rows.Count > 0)
                {
                    try
                    {
                        // Ánh xạ dữ liệu
                        txbAccountTypeID.DataBindings.Add(new Binding("Text", dtgvAccountType.DataSource, "AccountTypeID", true, DataSourceUpdateMode.Never));
                        txbAccountTypeName.DataBindings.Add(new Binding("Text", dtgvAccountType.DataSource, "AccountTypeName", true, DataSourceUpdateMode.Never));
                        txbAccountTypeDescription.DataBindings.Add(new Binding("Text", dtgvAccountType.DataSource, "AccountTypeDescription", true, DataSourceUpdateMode.Never));
                        txbInterestRate.DataBindings.Add(new Binding("Text", dtgvAccountType.DataSource, "InterestRate", true, DataSourceUpdateMode.Never));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error binding data: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("DataSource is null or empty. Ensure data is loaded correctly.");
                }
            }
            else
            {
                MessageBox.Show("One or more TextBox controls are null.");
            }
        }




        private void btnCheckTransactionHistory_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dtgvAccount.SelectedRows.Count > 0)
            {
                // Lấy giá trị AccountID từ dòng được chọn
                DataGridViewRow selectedRow = dtgvAccount.SelectedRows[0];
                if (selectedRow.Cells["AccountID"].Value != null)
                {
                    int accountID = Convert.ToInt32(selectedRow.Cells["AccountID"].Value);

                    // Kiểm tra xem tài khoản có tồn tại không
                    if (AccountDAO.Instance.AccountExists(accountID))
                    {
                        // Mở form thêm giao dịch với tài khoản đã chọn
                        OpenInfoTransactionWithExistingAccount(accountID);

                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không tồn tại.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để thêm giao dịch.");
            }

        }
        private void OpenInfoTransactionWithExistingAccount(int accountID)
        {
            // Lấy thông tin khách hàng từ CustomerDAO
            Account selectedAccount = AccountDAO.Instance.GetAccountByID(accountID);

            // Mở form InfoAccount và truyền thông tin khách hàng
            InfoTransaction infoTransactionForm = new InfoTransaction(selectedAccount);
            infoTransactionForm.ShowDialog();

        }


        private void btnCheckCustomer_Click(object sender, EventArgs e)
        {
            InfoAccount f = new InfoAccount();
            this.Hide();
            f.ShowDialog();
        }




        void LoadNameTypeAccountIntoCombobox(ComboBox cb)
        {
            cb.DataSource = AccountTypeDAO.Instance.GetListAccount();
            cb.DisplayMember = "AccountTypeName";
            /* cb.ValueMember = "AccountTypeID"; // Giả sử cột chứa ID của nghề nghiệp là "OccupationID"*/

        }




        private void btnAddAccountType_Click(object sender, EventArgs e)
        {
            string accountTypeName = txbAccountTypeName.Text;
            string accountTypeDescription = txbAccountTypeDescription.Text;
            string interestRate = txbInterestRate.Text;

            if (AccountTypeDAO.Instance.InsertAccountType(accountTypeName, accountTypeDescription, interestRate))
            {
                MessageBox.Show("Thêm tài khoản thành công");

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm tải khoản");
            }
            LoadListAccountType();
            AddAccountTypeBinding(); // Cập nhật lại ánh xạ dữ liệu
        }

        private void btnDeleteAccountType_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dtgvAccountType.SelectedCells.Count > 0)
            {
                // Lấy chỉ số dòng của ô được chọn
                int selectedRowIndex = dtgvAccountType.SelectedCells[0].RowIndex;

                // Lấy giá trị của cột ID từ dòng được chọn
                object cellValue = dtgvAccountType.Rows[selectedRowIndex].Cells["accountTypeID"].Value;

                // Kiểm tra xem giá trị cột ID có hợp lệ không
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int accountTypeID))
                {
                    // Thực hiện xóa loại tài khoản với ID đã lấy được
                    if (AccountTypeDAO.Instance.DeleteAccountType(accountTypeID))
                    {
                        MessageBox.Show("Xóa loại tài khoản thành công");
                        LoadListAccountType(); // Nạp lại danh sách loại tài khoản sau khi xóa thành công
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xóa loại tài khoản");
                    }
                }
                else
                {
                    MessageBox.Show("ID không hợp lệ");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một ô để xóa");
            }
        }

        private void btnEditAccountType_Click(object sender, EventArgs e)
        {

            int AccountTypeID = Convert.ToInt32(txbAccountTypeID.Text);
            string AccountTypeName = txbAccountTypeName.Text;
            string AccountTypeDescription = txbAccountTypeDescription.Text;
            string InterestRate = txbInterestRate.Text;

            if (AccountTypeDAO.Instance.UpdateAccount(AccountTypeID, AccountTypeName, AccountTypeDescription, InterestRate))
            {
                MessageBox.Show("Sửa loại tài khoản thành công");
                LoadListAccountType(); // Nạp lại danh sách loại tài khoản sau khi sửa thành công
                AddAccountTypeBinding(); // Cập nhật lại ánh xạ dữ liệu
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa loại tài khoản");
            }
        }

        private void btnSreachAccountType_Click(object sender, EventArgs e)
        {
            dtgvAccountType.DataSource = SearchAccountTypeByName(txbSreachAccountType.Text);
            AddAccountTypeBinding(); // Cập nhật lại ánh xạ dữ liệu
        }



        private void btnSreachAccount_Click(object sender, EventArgs e)
        {
            dtgvAccount.DataSource = SearchAccount(txbSreachAccount.Text);
        }
        List<Account> SearchAccount(string AccountSearch)
        {
            List<Account> account = AccountDAO.Instance.SearchAccount(AccountSearch);
            return account;
        }


        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            int selectedAccountOwnerID = 0; // Sử dụng một tên biến mới

            if (dtgvAccount.SelectedRows.Count > 0)
            {
                selectedAccountOwnerID = Convert.ToInt32(dtgvAccount.SelectedRows[0].Cells["AccountOwnerID"].Value);

                if (CustomerDAO.Instance.CustomerExists(selectedAccountOwnerID))
                {
                    DialogResult result = MessageBox.Show("Bạn có thông tin khách hàng sẵn. Bạn muốn sử dụng thông tin này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        OpenInfoAccountWithExistingCustomer(selectedAccountOwnerID);
                        LoadListAccount();
                    }
                    else
                    {
                        OpenInfoCustomerFormAndProceed(selectedAccountOwnerID);
                    }
                }
                else
                {
                    OpenInfoCustomerFormAndProceed(selectedAccountOwnerID);
                }
            }
            else
            {
                OpenInfoCustomerFormAndProceed(selectedAccountOwnerID);
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            if (dtgvAccount.SelectedRows.Count > 0)
            {
                int accountOwnerID = Convert.ToInt32(dtgvAccount.SelectedRows[0].Cells["AccountOwnerID"].Value);
                int accountID = Convert.ToInt32(dtgvAccount.SelectedRows[0].Cells["accountID"].Value);

                // Check if the customer exists
                if (CustomerDAO.Instance.CustomerExists(accountOwnerID))
                {
                    // Retrieve customer information
                    Customer customer = CustomerDAO.Instance.GetCustomerByID(accountOwnerID);

                    DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Open InfoAccount form with existing customer information
                        InfoAccount infoAccountForm = new InfoAccount(customer, accountID);
                        infoAccountForm.ShowDialog();
                        LoadListAccount();
                    }
                }
                else
                {
                    MessageBox.Show("Khách hàng không tồn tại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa tài khoản.");
            }
        }


        private void OpenInfoCustomerFormAndProceed(int accountOwnerID)
        {
            InfoCusomer infoCustomerForm = new InfoCusomer();
            if (infoCustomerForm.ShowDialog() == DialogResult.OK)
            {
                Customer newCustomer = infoCustomerForm.GetNewCustomer();
                OpenInfoAccountWithNewCustomer(newCustomer);
            }
        }

        private void OpenInfoAccountWithNewCustomer(Customer newCustomer)
        {
            InfoAccount infoAccountForm = new InfoAccount(newCustomer);
            infoAccountForm.ShowDialog();
            LoadListAccount(); // Nạp lại danh sách tài khoản sau khi đã thêm tài khoản mới       

        }
        private void OpenInfoAccountWithExistingCustomer(int customerID)
        {
            // Lấy thông tin khách hàng từ CustomerDAO
            Customer selectedCustomer = CustomerDAO.Instance.GetCustomerByID(customerID);



            // Mở form InfoAccount và truyền thông tin khách hàng
            InfoAccount infoAccountForm = new InfoAccount(selectedCustomer);
            infoAccountForm.ShowDialog();
        }

        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvAccount.Rows[e.RowIndex];
                accountID = Convert.ToInt32(row.Cells["AccountID"].Value);
                // Thực hiện truy vấn SQL để lấy CustomerName từ tblCustomer dựa trên AccountID
                string customerName = AccountDAO.Instance.GetCustomerNameByAccountID(accountID);

                // Gán giá trị của CustomerName cho điều khiển tương ứng trên form
                txbCustomerName.Text = customerName;


            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (accountID != 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        AccountDAO.Instance.DeleteAccount(accountID);

                        LoadListAccount();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer first.");
            }
        }

        private void dtgvAccountType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem chỉ số dòng có hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được click
                DataGridViewRow row = dtgvAccountType.Rows[e.RowIndex];

                // Gán giá trị từ các cột của dòng vào các TextBox tương ứng
                txbAccountTypeID.Text = row.Cells["AccountTypeID"].Value.ToString();
                txbAccountTypeName.Text = row.Cells["AccountTypeName"].Value.ToString();
                txbAccountTypeDescription.Text = row.Cells["AccountTypeDescription"].Value.ToString();
                txbInterestRate.Text = row.Cells["InterestRate"].Value.ToString();
            }
        }

        private void ShowInfoTransactionForm(Account account = null, int transactionID = 0)
        {
            InfoTransaction infoTransactionForm = new InfoTransaction(account, transactionID);
            infoTransactionForm.ShowDialog();
        }

      
    }
}
