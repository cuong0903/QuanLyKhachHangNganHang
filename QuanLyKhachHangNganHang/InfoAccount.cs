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
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuanLyKhachHangNganHang
{
    public partial class InfoAccount : Form
    {
        private Customer newCustomer; // Biến lưu trữ khách hàng mới
        private InfoCusomer infoCustomerForm; // Biến lưu trữ form InfoCustomer
        private int accountID; // Biến lưu trữ ID tài khoản

        public InfoAccount(Customer customer = null, int accountID = 0)
        {
            InitializeComponent();
            LoadMaritalStatusIntoCombobox(cbCustomerMarital);
            LoadOccupationIntoCombobox(cbOccupationStatus);
            LoadNameTypeAccountIntoCombobox(cbAccountTypeName);
            LoadAccountStatusIntoCombobox(cbAccountStatus);
            LoadCustomerDebtIntoCombobox(cbCustomerDebt);

            if (customer != null)
            {
                // Cập nhật dữ liệu khách hàng nếu có
                UpdateCustomerData(customer);
            }

            if (accountID != 0)
            {
                // Tải dữ liệu tài khoản nếu có accountID
                LoadAccountData(accountID);
            }
        }

        // Phương thức tải dữ liệu tài khoản từ dòng được chọn trên DataGridView
        public void LoadAccountDataFromSelectedRow(DataGridViewRow selectedRow)
        {
            int accountID = Convert.ToInt32(selectedRow.Cells["AccountID"].Value);
            LoadAccountData(accountID);
        }

        // Sự kiện khi nhấn nút thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            ManagerAccount f = new ManagerAccount();
            this.Hide();
            f.ShowDialog();
        }

        // Phương thức tải dữ liệu tài khoản từ cơ sở dữ liệu
        public void LoadAccountData(int accountID)
        {
            Account account = AccountDAO.Instance.GetAccountByID(accountID);

            if (account != null)
            {
                // Cập nhật dữ liệu tài khoản vào các điều khiển trên form
                txbAccountID.Text = account.AccountID.ToString();
                txbAccountNumber.Text = account.AccountNumber.ToString();
                txbAccountBalance.Text = account.Balance.ToString();
                cbAccountTypeName.SelectedValue = account.AccountTypeID;
                cbAccountStatus.SelectedItem = account.AccountStatus;
                dtpAccountOpenDate.Value = account.AccountOpenDate ?? DateTime.Now;
            }
        }

        // Phương thức tải danh sách trạng thái hôn nhân vào ComboBox
        void LoadMaritalStatusIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CustomerDAO.Instance.GetListMaritalStatus();
            cb.DisplayMember = "MaritalStatusName";
            cb.ValueMember = "MaritalStatusID";
        }

        // Phương thức tải danh sách nghề nghiệp vào ComboBox
        void LoadOccupationIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CustomerDAO.Instance.GetListOccupationStatus();
            cb.DisplayMember = "OccupationName";
            cb.ValueMember = "OccupationID";
        }

        // Phương thức tải danh sách loại tài khoản vào ComboBox
        void LoadNameTypeAccountIntoCombobox(ComboBox cb)
        {
            cb.DataSource = AccountTypeDAO.Instance.GetListAccount();
            cb.DisplayMember = "AccountTypeName";
            cb.ValueMember = "AccountTypeID";
        }

        // Phương thức tải danh sách nợ vào ComboBox
        void LoadCustomerDebtIntoCombobox(ComboBox cb, List<string> data = null)
        {
            cb.DropDownStyle = ComboBoxStyle.DropDownList;

            if (data == null)
            {
                cb.Items.Clear();
                cb.Items.AddRange(new object[] { "Có", "Không" });
            }
            else
            {
                cb.DataSource = data;
            }

            if (cb.Items.Count > 0)
            {
                cb.SelectedIndex = 0;
            }
        }

        // Phương thức tải danh sách trạng thái tài khoản vào ComboBox
        void LoadAccountStatusIntoCombobox(ComboBox cb, List<string> data = null)
        {
            cb.DropDownStyle = ComboBoxStyle.DropDownList;

            if (data == null)
            {
                cb.Items.AddRange(new object[] { "Hoạt động", "Không hoạt động" });
            }
            else
            {
                cb.DataSource = data;
            }

            cb.SelectedIndex = 0;
        }

        // Phương thức lấy dữ liệu khách hàng mới từ form InfoCustomer
/*        private Customer GetNewCustomerData()
        {
            InfoCusomer infoCustomerForm = new InfoCusomer();
            if (infoCustomerForm.ShowDialog() == DialogResult.OK)
            {
                return infoCustomerForm.GetNewCustomer();
            }
            return null;
        }*/

        // Phương thức lấy dữ liệu khách hàng từ các điều khiển trên form InfoAccount
        public Customer GetNewCustomer()
        {
            Customer newCustomer = new Customer();
            newCustomer.CustomerID = int.Parse(txbCustomerID.Text);
            newCustomer.CustomerName = txbCustomerName.Text;
            newCustomer.CCCD = txbCustomerCMND.Text;
            newCustomer.Address = txbCustomerAdress.Text;
            newCustomer.CustomerPhone = txbCustomerSDT.Text;
            newCustomer.Email = txbCustormerEmail.Text;
            newCustomer.Gender = rdbGenderBoy.Checked ? "Nam" : (rdbGenderGirl.Checked ? "Nữ" : "");
            newCustomer.DateOfBirth = dtpCustomerDate.Value;
            return newCustomer;
        }

        // Phương thức cập nhật dữ liệu khách hàng trên form InfoAccount
        public void UpdateCustomerData(Customer customer)
        {
            txbCustomerID.Text = customer.CustomerID.ToString();
            txbCustomerName.Text = customer.CustomerName;
            txbCustomerCMND.Text = customer.CCCD;
            txbCustomerAdress.Text = customer.Address;
            txbCustomerSDT.Text = customer.CustomerPhone;
            txbCustormerEmail.Text = customer.Email;

            if (customer.Gender == "Nam")
            {
                rdbGenderBoy.Checked = true;
            }
            else if (customer.Gender == "Nữ")
            {
                rdbGenderGirl.Checked = true;
            }
            else
            {
                MessageBox.Show("Giới tính không hợp lệ.");
                return;
            }

            dtpCustomerDate.Value = customer.DateOfBirth ?? DateTime.Now;
            txbCustomerIncome.Text = customer.AverageIncome.ToString();
            txbCustormerLoan.Text = customer.Loans.ToString();
            txbCreditTern.Text = customer.CreditTerm;

            cbCustomerMarital.SelectedValue = customer.MaritalStatusID;
            cbOccupationStatus.SelectedValue = customer.OccupationID;
            cbCustomerDebt.SelectedItem = customer.Debt;
        }

        // Sự kiện khi nhấn nút thêm tài khoản
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer newCustomer = GetNewCustomer();

            if (newCustomer != null)
            {
                UpdateCustomerData(newCustomer);

                int AccountOwnerID = newCustomer.CustomerID;
                int AccountTypeID = (cbAccountTypeName.SelectedItem as AccountType).AccountTypeID;
                string AccountStatus = cbAccountStatus.SelectedItem?.ToString();
                DateTime? accountOpenDate = dtpAccountOpenDate.Value;
                int balance = Convert.ToInt32(txbAccountBalance.Text);
                string accountNumber = txbAccountNumber.Text;

                AccountDAO.Instance.InsertAccount(AccountOwnerID, AccountTypeID, AccountStatus, accountOpenDate, balance, accountNumber);
                HomePage homePage = Application.OpenForms.OfType<HomePage>().FirstOrDefault();
                if (homePage != null)
                {
                    homePage.RefreshListAccount();
                }
            }
        }

        // Sự kiện khi nhấn nút chỉnh sửa tài khoản
        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            int accountID = Convert.ToInt32(txbAccountID.Text);
            int accountTypeID = (cbAccountTypeName.SelectedItem as AccountType).AccountTypeID;
            string accountStatus = cbAccountStatus.SelectedItem?.ToString();
            DateTime? accountOpenDate = dtpAccountOpenDate.Value;
            int balance;

            if (!int.TryParse(txbAccountBalance.Text, out balance))
            {
                MessageBox.Show("Số dư không hợp lệ.");
                return;
            }

            string accountNumber = txbAccountNumber.Text;

            if (accountTypeID == 0 || string.IsNullOrWhiteSpace(accountStatus) || accountOpenDate == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            AccountDAO.Instance.EditAccount(accountID, accountTypeID, accountStatus, accountOpenDate, balance, accountNumber);
        }

        // Phương thức lấy thông tin tài khoản mới từ các điều khiển trên form InfoAccount
        public Account GetNewAccount()
        {
            int AccountID = Convert.ToInt32(txbAccountID.Text);
            int AccountTypeID = Convert.ToInt32(cbAccountTypeName.SelectedValue);
            string AccountStatus = cbAccountStatus.SelectedValue.ToString();
            DateTime? AccountOpenDate = dtpAccountOpenDate.Value;
            int Balance = Convert.ToInt32(txbAccountBalance.Text);
            string AccountNumber = txbAccountNumber.Text;

            Account newAccount = new Account
            {
                AccountID = AccountID,
                AccountTypeID = AccountTypeID,
                AccountStatus = AccountStatus,
                AccountOpenDate = AccountOpenDate,
                Balance = Balance,
                AccountNumber = AccountNumber,
            };

            newAccount.AccountID = TransactionHistoryDAO.Instance.GetAccountIDAfterInsert();

            return newAccount;
        }
    }
}
