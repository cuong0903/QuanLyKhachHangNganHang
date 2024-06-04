using QuanLyKhachHangNganHang.DAO;
using QuanLyKhachHangNganHang.DTO;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Transactions;
using System.Windows.Forms; // Thêm thư viện này để chỉ định rõ ràng không gian tên
using System.Globalization;
using System.Text.RegularExpressions;

namespace QuanLyKhachHangNganHang
{
    public partial class ManagerTransaction : Form
    {

        private int selectedAccountID; // Biến để lưu trữ AccountID khi người dùng click vào bảng dtgvTransaction
        public ManagerTransaction()
        {
            
            InitializeComponent();
            LoadListService();
            AddServiceBinding();
            LoadListTransactionHistory();
            AddTransactionHistoryBinding();
            LoadServiceNameByComboBox(cbServiceName);
          
        }

        // Serice
        void LoadListService()
        {
            dtgvService.DataSource = ServiceDAO.Instance.GetListService();
            AddServiceBinding(); // Cập nhật lại ánh xạ dữ liệu
        }
        void AddServiceBinding()
        {
            // Gỡ bỏ tất cả các ánh xạ dữ liệu cũ trước khi thêm mới
            txbServiceID.DataBindings.Clear();
            txbServiceName.DataBindings.Clear();
            txbServicePrice.DataBindings.Clear();
            txbServiceDescription.DataBindings.Clear();
            txbServiceStatus.DataBindings.Clear();

            // Thêm ánh xạ dữ liệu mới
            txbServiceID.DataBindings.Add(new Binding("Text", dtgvService.DataSource, "ServiceID", true, DataSourceUpdateMode.Never));
            txbServiceName.DataBindings.Add(new Binding("Text", dtgvService.DataSource, "ServiceName", true, DataSourceUpdateMode.Never));
            txbServicePrice.DataBindings.Add(new Binding("Text", dtgvService.DataSource, "ServicePrice", true, DataSourceUpdateMode.Never));
            txbServiceDescription.DataBindings.Add(new Binding("Text", dtgvService.DataSource, "ServiceDescription", true, DataSourceUpdateMode.Never));
            txbServiceStatus.DataBindings.Add(new Binding("Text", dtgvService.DataSource, "ServiceStatus", true, DataSourceUpdateMode.Never));
        }
        private void btnAddService_Click(object sender, EventArgs e)
        {
            string ServiceName = txbServiceName.Text;
            int ServicePrice = Convert.ToInt32(txbServicePrice.Text);
            string ServiceDescription = txbServiceDescription.Text;
            string ServiceStatus = txbServiceStatus.Text;

            if (ServiceDAO.Instance.InsertService(ServiceName, ServicePrice, ServiceDescription, ServiceStatus))
            {
                MessageBox.Show("Thêm dịch thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm dịch vụ");
            }
            LoadListService();
            
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            int ServiceID = Convert.ToInt32(txbServiceID.Text);
            string ServiceName = txbServiceName.Text;
            int ServicePrice = Convert.ToInt32(txbServicePrice.Text); // Chuyển đổi thành decimal thay vì int
            string ServiceDescription = txbServiceDescription.Text;
            string ServiceStatus = txbServiceStatus.Text;

            if (ServiceDAO.Instance.UpdateService(ServiceID, ServiceName, ServicePrice, ServiceDescription, ServiceStatus))
            {
                MessageBox.Show("Sửa loại dịch vụ thành công");
                LoadListService(); // Nạp lại danh sách loại tài khoản sau khi sửa thành công
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa loại dịch vụ");
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dtgvService.SelectedCells.Count > 0)
            {
                // Lấy chỉ số dòng của ô được chọn
                int selectedRowIndex = dtgvService.SelectedCells[0].RowIndex;

                // Lấy giá trị của cột ID từ dòng được chọn
                object cellValue = dtgvService.Rows[selectedRowIndex].Cells["ServiceID"].Value;

                // Kiểm tra xem giá trị cột ID có hợp lệ không
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int ServiceID))
                {
                    // Thực hiện xóa loại tài khoản với ID đã lấy được
                    if (ServiceDAO.Instance.DeleteService(ServiceID))
                    {
                        MessageBox.Show("Xóa loại dịch vụ thành công");
                        LoadListService(); // Nạp lại danh sách loại tài khoản sau khi xóa thành công
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xóa loại dịch vụ");
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

        private void btnSreachService_Click(object sender, EventArgs e)
        {
            dtgvService.DataSource = SearchService(txbSreachService.Text);

        }
        List<Service> SearchService(String ServiceSearch)
        {
            List<Service> service = ServiceDAO.Instance.SearchService(ServiceSearch);
            return service;
        }

        // Transantion

        void LoadListTransactionHistory()
        {
            dtgvTransactionHistory.DataSource = TransactionHistoryDAO.Instance.GetListTransactionHistory();
            AddTransactionHistoryBinding();
        }
        void AddTransactionHistoryBinding()
        {
            // Gỡ bỏ tất cả các ánh xạ dữ liệu cũ trước khi thêm mới
            txbTransactionID.DataBindings.Clear();
            dtpTransactionDate.DataBindings.Clear();
            txbTransactionDescription.DataBindings.Clear();
            txbTransactionAmount.DataBindings.Clear();

            // Thêm ánh xạ dữ liệu mới
            txbTransactionID.DataBindings.Add(new Binding("Text", dtgvTransactionHistory.DataSource, "TransactionID", true, DataSourceUpdateMode.Never));
            dtpTransactionDate.DataBindings.Add(new Binding("Text", dtgvTransactionHistory.DataSource, "TransactionDate", true, DataSourceUpdateMode.Never));

            txbTransactionDescription.DataBindings.Add(new Binding("Text", dtgvTransactionHistory.DataSource, "TransactionDescription", true, DataSourceUpdateMode.Never));
            txbTransactionAmount.DataBindings.Add(new Binding("Text", dtgvTransactionHistory.DataSource, "TransactionAmount", true, DataSourceUpdateMode.Never));
        }

/*        private void btnCheckCustomer_Click(object sender, EventArgs e)
        {
            InfoAccount f = new InfoAccount();
            f.ShowDialog();
        }*/
        private void btnCheckAccount_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dtgvTransactionHistory.SelectedRows.Count > 0)
            {
                // Lấy giá trị AccountID từ dòng được chọn
                DataGridViewRow selectedRow = dtgvTransactionHistory.SelectedRows[0];
                if (selectedRow.Cells["AccountID"].Value != null)
                {
                    int accountID = Convert.ToInt32(selectedRow.Cells["AccountID"].Value);

                    // Kiểm tra xem tài khoản có tồn tại không
                    if (AccountDAO.Instance.AccountExists(accountID))
                    {
                        // Mở form thêm giao dịch với tài khoản đã chọn
                        OpenInfoTransactionWithExistingAccount(accountID);
                        // Nạp lại danh sách lịch sử giao dịch
                        LoadListTransactionHistory();
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
        void LoadServiceNameByComboBox(ComboBox cb)
        {
            cb.DataSource = ServiceDAO.Instance.GetListService();
            cb.DisplayMember = "ServiceName";
            cb.ValueMember = "ServiceID"; // Giả sử cột chứa ID của nghề nghiệp là "OccupationID"
        }
        /*private DataTable ConvertAccountToDataTable(List<Account> accounts)
        {
            DataTable dataTable = new DataTable();

            // Thêm các cột vào DataTable
            dataTable.Columns.Add("AccountID");
            dataTable.Columns.Add("AccountTypeID");
            dataTable.Columns.Add("AccountStatus");
            dataTable.Columns.Add("AccountOpenDate");
            dataTable.Columns.Add("Balance");
            dataTable.Columns.Add("AccountNumber");


            // Thêm dữ liệu từ List<Customer> vào DataTable
            foreach (Account account in accounts)
            {
                DataRow row = dataTable.NewRow();
                row["AccountID"] = account.AccountID;
                row["AccountTypeID"] = account.AccountTypeID;
                row["AccountStatus"] = account.AccountStatus;
                row["AccountOpenDate"] = account.AccountOpenDate;
                row["Balance"] = account.Balance;
                row["AccountNumber"] = account.AccountNumber;

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
*/
        private void btnEditTransaction_Click(object sender, EventArgs e)
        {
            if (dtgvTransactionHistory.SelectedRows.Count > 0)
            {

                int accountID = Convert.ToInt32(dtgvTransactionHistory.SelectedRows[0].Cells["accountID"].Value);
                int transactionID = Convert.ToInt32(dtgvTransactionHistory.SelectedRows[0].Cells["TransactionID"].Value);

                // Check if the customer exists
                if (AccountDAO.Instance.AccountExists(accountID))
                {
                    // Retrieve customer information
                    Account account = AccountDAO.Instance.GetAccountByID(accountID);

                    DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin giao dịch này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Open InfoAccount form with existing customer information
                        InfoTransaction infoTransactionForm = new InfoTransaction(account, transactionID);
                        infoTransactionForm.ShowDialog();
                        LoadListTransactionHistory();
                    }
                }
                else
                {
                    MessageBox.Show("Giao dịch không tồn tại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa tài khoản.");
            }
        }
        private void OpenInfoTransactionWithExistingAccount(int accountID)
        {
            // Lấy thông tin khách hàng từ CustomerDAO
            Account selectedAccount = AccountDAO.Instance.GetAccountByID(accountID);

            // Mở form InfoAccount và truyền thông tin khách hàng
            InfoTransaction infoTransactionForm = new InfoTransaction(selectedAccount);
            infoTransactionForm.ShowDialog();
            LoadListTransactionHistory();
        }

        private void DtgvTransactionHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng click vào dòng chứa dữ liệu (không phải dòng header)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị AccountID từ cột AccountID tại dòng được click
                if (dtgvTransactionHistory.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    selectedAccountID = Convert.ToInt32(dtgvTransactionHistory.Rows[e.RowIndex].Cells["AccountID"].Value);
                }
                // Lấy giá trị ServiceID từ cột ServiceID tại dòng được click
                if (dtgvTransactionHistory.Rows[e.RowIndex].Cells["ServiceID"].Value != null)
                {
                    int serviceID = Convert.ToInt32(dtgvTransactionHistory.Rows[e.RowIndex].Cells["ServiceID"].Value);
                    // Cập nhật giá trị của ComboBox cbServiceName dựa trên ServiceID
                    cbServiceName.SelectedValue = serviceID;
                }
            }
        }
        private void btnSreachTransaction_Click(object sender, EventArgs e)
        {

            dtgvTransactionHistory.DataSource = SearchTransaction(txbSreachTransaction.Text);
        }
        List<TransactionHistory> SearchTransaction(string TransactionSearch)
        {
            List<TransactionHistory> transaction = TransactionHistoryDAO.Instance.SearchTransaction(TransactionSearch);
            return transaction;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy danh sách giao dịch từ cơ sở dữ liệu
                var transactionHistoryDAO = TransactionHistoryDAO.Instance;
                var transactions = transactionHistoryDAO.GetListTransactionHistory();

                // Tạo một đối tượng ExcelExporter
                var excelExporter = new ExcelExporter();

                // Đường dẫn tới thư mục lưu file Excel
                string directoryPath = @"D:\Tai_lieu_HUMG\ATGT\";

                // Tạo tên file Excel dựa trên ngày giờ hiện tại
                string fileName = $"TransactionHistory_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx";

                // Tạo đường dẫn đầy đủ đến file Excel
                string filePath = Path.Combine(directoryPath, fileName);

                // Xuất dữ liệu ra file Excel
                excelExporter.ExportTransactionHistoryToExcel(transactions, filePath);

                // Hiển thị thông báo khi xuất thành công
                MessageBox.Show($"Dữ liệu giao dịch đã được xuất ra file Excel thành công!\nĐường dẫn: {filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo khi xuất thất bại
                MessageBox.Show($"Đã xảy ra lỗi khi xuất dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
