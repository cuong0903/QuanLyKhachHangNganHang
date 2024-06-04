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
    public partial class ManagerCustomer : Form
    {
        private int selectedCustomerID;
        private int customerID;
        public ManagerCustomer()
        {
            InitializeComponent();
            LoadListCustomer();
            AddCustomerBinding();
            LoadListAccount();
        }
        public void RefreshListCustomer()
        {
            LoadListCustomer();
        }
        void LoadListCustomer()
        {
            dtgvCustomer.DataSource = CustomerDAO.Instance.GetListCustomer();
        }
        void LoadListAccount()
        {
            dtgvAccount.DataSource = AccountDAO.Instance.GetListAccount();
        }

        /*private DataTable ConvertCustomersToDataTable(List<Customer> customers)
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
        }*/
        /*private void PassDataToInfoCustomer()
        {
            // Lấy dữ liệu từ dtgvCustomer dưới dạng List<Customer>
            List<Customer> customers = (List<Customer>)dtgvCustomer.DataSource;

            // Chuyển đổi List<Customer> thành DataTable
            DataTable dataTable = ConvertCustomersToDataTable(customers);

            // Tạo một instance của InfoCustomer
            InfoCusomer infoCustomerForm = new InfoCusomer();

            // Gọi phương thức AddCustomerBinding() trong InfoCustomer và truyền DataTable
            infoCustomerForm.AddCustomerBinding(dataTable);

            // Hiển thị InfoCustomer
            infoCustomerForm.ShowDialog();
        }
*/

        void AddCustomerBinding()
        {
            // Gỡ bỏ tất cả các ánh xạ dữ liệu cũ trước khi thêm mới
            txbCustomerID.DataBindings.Clear();
            txbAccountOwnerName.DataBindings.Clear();

            // Thêm ánh xạ dữ liệu mới
            txbCustomerID.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "CustomerID", true, DataSourceUpdateMode.Never));
            txbAccountOwnerName.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "CustomerName", true, DataSourceUpdateMode.Never));


        }


        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            InfoCusomer f = new InfoCusomer();
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadListAccount();
            LoadListCustomer();
        }


        private void txbSreachAccount_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnNear_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID != 0)
            {
                NextOfKindCustomer f = new NextOfKindCustomer(selectedCustomerID);
                f.ShowDialog();
                LoadListCustomer();
                LoadListAccount();

            }
            else
            {
                MessageBox.Show("Please select a customer first.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID != 0)
            {
                OpenInfoCustomerForm(selectedCustomerID);
                LoadListAccount();
                LoadListCustomer();
            }
            else
            {
                MessageBox.Show("Please select a customer first.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID != 0)
            {
                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Gọi phương thức DeleteCustomer từ CustomerDAO để xóa khách hàng
                    if (CustomerDAO.Instance.DeleteCustomer(selectedCustomerID))
                    {
                        MessageBox.Show("Xóa khách hàng thành công!");
                        // Sau khi xóa thành công, cập nhật lại danh sách khách hàng
                        LoadListCustomer();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại!");
                        LoadListAccount();
                    
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng trước.");
            }
        }



        private void dtgvCustomer_CellClickID(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvCustomer.Rows[e.RowIndex];
                int customerID = Convert.ToInt32(row.Cells["CustomerID"].Value);

                // Truy vấn danh sách tài khoản liên kết với customerID
                List<Account> accounts = AccountDAO.Instance.GetAccountsByCustomerID(customerID);

                // Hiển thị danh sách tài khoản trong dtgvAccount
                ShowAccountsInDataGridView(accounts);
            }
        }


        private void ShowAccountsInDataGridView(List<Account> accounts)
        {
            // Xóa dữ liệu cũ bằng cách gán DataSource = null
            dtgvAccount.DataSource = null;

            // Hiển thị danh sách tài khoản trong dtgvAccount
            dtgvAccount.DataSource = accounts;

            // Đếm số lượng tài khoản
            int numberOfAccounts = accounts.Count;

            // Gán giá trị của số lượng tài khoản vào thuộc tính Text của txbAccounts
            txbAccounts.Text = numberOfAccounts.ToString();
        }



        private void OpenInfoCustomerForm(int customerID)
        {
            InfoCusomer infoCustomerForm = new InfoCusomer();

            // Gọi phương thức LoadCustomerData với CustomerID để load thông tin khách hàng
            infoCustomerForm.LoadCustomerData(customerID);

            // Hiển thị form InfoCusomer để chỉnh sửa thông tin
            infoCustomerForm.ShowDialog();
        }



        private void btnSreachCustomer_Click(object sender, EventArgs e)
        {
            dtgvCustomer.DataSource = SearchCustomer(txbSreachCustomer.Text);
        }
        List<Customer> SearchCustomer(string CustomerSearch)
        {
            List<Customer> customer = CustomerDAO.Instance.SearchCustomer(CustomerSearch);
            return customer;
        }

        private void dtgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvCustomer.Rows[e.RowIndex];
                selectedCustomerID = Convert.ToInt32(row.Cells["CustomerID"].Value);

                // Truy vấn danh sách tài khoản liên kết với selectedCustomerID
                List<Account> accounts = AccountDAO.Instance.GetAccountsByCustomerID(selectedCustomerID);

                // Hiển thị danh sách tài khoản trong dtgvAccount
                ShowAccountsInDataGridView(accounts);
            }
        }

        private void btnAddAccount_Click_1(object sender, EventArgs e)
        {
            int selectedCustomerID = 0;

            if (dtgvCustomer.SelectedRows.Count > 0)
            {
                selectedCustomerID = Convert.ToInt32(dtgvCustomer.SelectedRows[0].Cells["CustomerID"].Value);

                if (CustomerDAO.Instance.CustomerExists(selectedCustomerID))
                {
                    // Lấy thông tin khách hàng từ CustomerDAO
                    Customer selectedCustomer = CustomerDAO.Instance.GetCustomerByID(selectedCustomerID);

                    // Mở form InfoAccount và truyền thông tin khách hàng
                    InfoAccount infoAccountForm = new InfoAccount(selectedCustomer);
                    infoAccountForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Khách hàng không tồn tại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng trước.");
            }
        }


        private void OpenInfoAccountWithExistingCustomer(int customerID)
        {
            // Lấy thông tin khách hàng từ CustomerDAO
            Customer selectedCustomer = CustomerDAO.Instance.GetCustomerByID(customerID);



            // Mở form InfoAccount và truyền thông tin khách hàng
            InfoAccount infoAccountForm = new InfoAccount(selectedCustomer);
            infoAccountForm.ShowDialog();
        }


    }
}
