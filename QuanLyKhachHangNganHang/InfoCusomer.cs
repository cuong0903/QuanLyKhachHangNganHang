using QuanLyKhachHangNganHang.DAO;
using QuanLyKhachHangNganHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyKhachHangNganHang
{
    public partial class InfoCusomer : Form
    {
        private int customerID; // Biến lưu trữ ID của khách hàng

        public InfoCusomer()
        {
            InitializeComponent();
            this.customerID = customerID;
            LoadCustomerData(customerID); // Tải dữ liệu khách hàng
            LoadMaritalStatusIntoCombobox(cbCustomerMarital); // Tải dữ liệu trạng thái hôn nhân vào ComboBox
            LoadOccupationIntoCombobox(cbOccupationName); // Tải dữ liệu nghề nghiệp vào ComboBox
            LoadCustomerDebtIntoCombobox(cbCustomerDebt); // Tải dữ liệu nợ vào ComboBox
        }

        public void AddCustomerBinding(DataTable dataSource)
        {
            // Gỡ bỏ tất cả các ánh xạ dữ liệu cũ trước khi thêm mới
            txbCustomerID.DataBindings.Clear();
            txbCustomerName.DataBindings.Clear();
            txbCustomerSDT.DataBindings.Clear();
            txbCustormerEmail.DataBindings.Clear();
            txbCustormerLoan.DataBindings.Clear();
            txbCustomerCMND.DataBindings.Clear();
            txbCustomerAdress.DataBindings.Clear();
            txbCreditTern.DataBindings.Clear();
            txbCustomerIncome.DataBindings.Clear();
            cbCustomerMarital.DataSource = null;
            cbOccupationName.DataSource = null;
            rdbGenderBoy.DataBindings.Clear();
            rdbGenderGirl.DataBindings.Clear();

            // Thêm ánh xạ dữ liệu mới
            txbCustomerID.DataBindings.Add(new Binding("Text", dataSource, "CustomerID", true, DataSourceUpdateMode.Never));
            txbCustomerName.DataBindings.Add(new Binding("Text", dataSource, "CustomerName", true, DataSourceUpdateMode.Never));
            txbCustomerSDT.DataBindings.Add(new Binding("Text", dataSource, "CustomerPhone", true, DataSourceUpdateMode.Never));
            txbCustormerEmail.DataBindings.Add(new Binding("Text", dataSource, "Email", true, DataSourceUpdateMode.Never));
            txbCustormerLoan.DataBindings.Add(new Binding("Text", dataSource, "Loans", true, DataSourceUpdateMode.Never));
            txbCustomerCMND.DataBindings.Add(new Binding("Text", dataSource, "CCCD", true, DataSourceUpdateMode.Never));
            txbCustomerAdress.DataBindings.Add(new Binding("Text", dataSource, "Address", true, DataSourceUpdateMode.Never));
            cbCustomerDebt.DataBindings.Add(new Binding("Text", dataSource, "Debt", true, DataSourceUpdateMode.Never));
            txbCustomerIncome.DataBindings.Add(new Binding("Text", dataSource, "AverageIncome", true, DataSourceUpdateMode.Never));

            // Gán dữ liệu cho cbCustomerMarital và cbOccupationName
            cbCustomerMarital.DataSource = CustomerDAO.Instance.GetListMaritalStatus();
            cbCustomerMarital.DisplayMember = "MaritalStatusName";
            cbCustomerMarital.ValueMember = "MaritalStatusID";

            cbOccupationName.DataSource = CustomerDAO.Instance.GetListOccupationStatus();
            cbOccupationName.DisplayMember = "OccupationName";
            cbOccupationName.ValueMember = "OccupationID";

            // Liên kết RadioButton với cột Gender
            rdbGenderBoy.DataBindings.Add(new Binding("Checked", dataSource, "Gender", true, DataSourceUpdateMode.Never, "Nam"));
            rdbGenderGirl.DataBindings.Add(new Binding("Checked", dataSource, "Gender", true, DataSourceUpdateMode.Never, "Nữ"));

            // Liên kết ComboBox Debt
            LoadCustomerDebtIntoCombobox(cbCustomerDebt);
            Binding debtBinding = new Binding("SelectedItem", dataSource, "Debt", true, DataSourceUpdateMode.Never);
            debtBinding.Format += (s, e) => {
                if (e.DesiredType == typeof(string))
                {
                    e.Value = ((int)e.Value == 1) ? "Có" : "Không";
                }
            };
            debtBinding.Parse += (s, e) => {
                if (e.DesiredType == typeof(int))
                {
                    e.Value = ((string)e.Value == "Có") ? 1 : 0;
                }
            };
            cbCustomerDebt.DataBindings.Add(debtBinding);
        }

        void LoadCustomerDebtIntoCombobox(ComboBox cb, List<string> data = null)
        {
            // Thiết lập giá trị mặc định cho ComboBox cb
            cb.DropDownStyle = ComboBoxStyle.DropDownList;

            if (data == null)
            {
                // Nếu danh sách dữ liệu không được cung cấp, sử dụng giá trị mặc định
                cb.Items.Clear();
                cb.Items.AddRange(new object[] { "Có", "Không" });
            }
            else
            {
                // Sử dụng danh sách dữ liệu được cung cấp
                cb.DataSource = data;
            }

            if (cb.Items.Count > 0)
            {
                cb.SelectedIndex = 0; // Chọn giá trị đầu tiên làm giá trị mặc định
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ManagerCustomer f = new ManagerCustomer(); // Tạo một form ManagerCustomer mới
            this.Hide(); // Ẩn form hiện tại
            LoadCustomerData(customerID); // Tải lại dữ liệu khách hàng
            f.ShowDialog(); // Hiển thị form ManagerCustomer
            InfoAccount infoAccountForm = new InfoAccount(); // Tạo một form InfoAccount mới
            infoAccountForm.UpdateCustomerData(GetNewCustomer()); // Cập nhật dữ liệu mới vào form InfoAccount
            this.Close(); // Đóng form hiện tại
        }

        public void LoadCustomerData(int customerID)
        {
            Customer customer = CustomerDAO.Instance.GetCustomerByID(customerID); // Lấy thông tin khách hàng từ cơ sở dữ liệu

            if (customer != null)
            {
                // Cập nhật thông tin khách hàng vào các điều khiển trên form
                txbCustomerID.Text = customer.CustomerID.ToString();
                txbCustomerName.Text = customer.CustomerName;
                txbCustomerSDT.Text = customer.CustomerPhone;
                txbCustormerEmail.Text = customer.Email;
                txbCustormerLoan.Text = customer.Loans.ToString();
                txbCustomerCMND.Text = customer.CCCD;
                txbCustomerAdress.Text = customer.Address;
                txbCreditTern.Text = customer.CreditTerm.ToString();
                cbCustomerDebt.SelectedItem = customer.Debt;
                txbCustomerIncome.Text = customer.AverageIncome.ToString();
                cbCustomerMarital.SelectedValue = customer.MaritalStatusID;
                cbOccupationName.SelectedValue = customer.OccupationID;

                // Kiểm tra và đặt giá trị cho RadioButton giới tính
                if (customer.Gender == "Nam")
                {
                    rdbGenderBoy.Checked = true;
                }
                else
                {
                    rdbGenderGirl.Checked = true;
                }

                dtpCustomerDate.Value = customer.DateOfBirth ?? DateTime.Now;
            }
        }

        void LoadMaritalStatusIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CustomerDAO.Instance.GetListMaritalStatus();
            cb.DisplayMember = "MaritalStatusName";
            cb.ValueMember = "MaritalStatusID"; // Giả sử cột chứa ID của trạng thái hôn nhân là "MaritalStatusID"
        }

        void LoadOccupationIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CustomerDAO.Instance.GetListOccupationStatus();
            cb.DisplayMember = "OccupationName";
            cb.ValueMember = "OccupationID"; // Giả sử cột chứa ID của nghề nghiệp là "OccupationID"
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Lấy thông tin khách hàng từ các điều khiển trên giao diện
            string CustomerName = txbCustomerName.Text;
            string CCCD = txbCustomerCMND.Text;
            string Address = txbCustomerAdress.Text;
            string CustomerPhone = txbCustomerSDT.Text;
            string Email = txbCustormerEmail.Text;

            string Gender = ""; // Biến để lưu giới tính của khách hàng

            // Kiểm tra và chỉ lấy giá trị của nút radio "Nam" hoặc "Nữ"
            if (rdbGenderBoy.Checked)
            {
                Gender = rdbGenderBoy.Text;
            }
            else if (rdbGenderGirl.Checked)
            {
                Gender = rdbGenderGirl.Text;
            }
            else
            {
                // Nếu không có nút radio nào được chọn, hiển thị thông báo lỗi và dừng lại
                MessageBox.Show("Vui lòng chọn giới tính của khách hàng.");
                return;
            }

            DateTime? DateOfBirth = dtpCustomerDate.Value;
            int OccupationID = Convert.ToInt32(cbOccupationName.SelectedValue);
            decimal AverageIncome = Convert.ToDecimal(txbCustomerIncome.Text);
            int MaritalStatusID = Convert.ToInt32(cbCustomerMarital.SelectedValue);
            int Debt = cbCustomerDebt.SelectedItem.ToString() == "Có" ? 1 : 0;
            int Loans = Convert.ToInt32(txbCustormerLoan.Text);
            string CreditTerm = txbCreditTern.Text;

            // Gọi phương thức InsertCustomer của CustomerDAO và truyền các tham số cần thiết
            if (CustomerDAO.Instance.InsertCustomer(CustomerName, CCCD, Address, CustomerPhone, Email, Gender, 0, DateOfBirth, OccupationID, AverageIncome, MaritalStatusID, Debt, Loans, CreditTerm))
            {
                DialogResult result = MessageBox.Show("Thêm khách hàng mới thành công. Bạn có muốn thêm tài khoản không?", "Thêm tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra kết quả của hộp thoại MessageBox
                if (result == DialogResult.Yes)
                {
                    // Tạo mới form InfoAccount và hiển thị nó
                    InfoAccount infoAccountForm = new InfoAccount(GetNewCustomer());
                    infoAccountForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm tài khoản");
            }
        }

        private void BtnUpdateCustomer_Click(object sender, EventArgs e)
        {
            // Lấy thông tin khách hàng từ các điều khiển trên giao diện
            int customerID = Convert.ToInt32(txbCustomerID.Text);
            string customerName = txbCustomerName.Text;
            string CCCD = txbCustomerCMND.Text;
            string address = txbCustomerAdress.Text;
            string customerPhone = txbCustomerSDT.Text;
            string email = txbCustormerEmail.Text;
            string gender = rdbGenderBoy.Checked ? rdbGenderBoy.Text : rdbGenderGirl.Text;
            DateTime? dateOfBirth = dtpCustomerDate.Value;
            int occupationID = Convert.ToInt32(cbOccupationName.SelectedValue);
            decimal averageIncome = Convert.ToDecimal(txbCustomerIncome.Text);
            int maritalStatusID = Convert.ToInt32(cbCustomerMarital.SelectedValue);
            int debt = cbCustomerDebt.SelectedItem.ToString() == "Có" ? 1 : 0;
            int loans = Convert.ToInt32(txbCustormerLoan.Text);
            string creditTerm = txbCreditTern.Text;

            // Gọi phương thức UpdateCustomer từ CustomerDAO
            if (CustomerDAO.Instance.UpdateCustomer(customerID, customerName, CCCD, address, customerPhone, email, gender, 0,
                dateOfBirth, occupationID, averageIncome, maritalStatusID, debt, loans, creditTerm))
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
                // Đóng form InfoCusomer
                LoadCustomerData(customerID);
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật thông tin khách hàng.");
            }
        }

        public Customer GetNewCustomer()
        {
            // Lấy thông tin khách hàng mới từ các điều khiển trên form
            string CustomerName = txbCustomerName.Text;
            string CCCD = txbCustomerCMND.Text;
            string Address = txbCustomerAdress.Text;
            string CustomerPhone = txbCustomerSDT.Text;
            string Email = txbCustormerEmail.Text;

            string Gender = ""; // Biến để lưu giới tính của khách hàng

            // Kiểm tra và chỉ lấy giá trị của nút radio "Nam" hoặc "Nữ"
            if (rdbGenderBoy.Checked)
            {
                Gender = rdbGenderBoy.Text;
            }
            else if (rdbGenderGirl.Checked)
            {
                Gender = rdbGenderGirl.Text;
            }
            else
            {
                // Nếu không có nút radio nào được chọn, hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng chọn giới tính của khách hàng.");
            }

            DateTime? DateOfBirth = dtpCustomerDate.Value;
            int OccupationID = Convert.ToInt32(cbOccupationName.SelectedValue);
            decimal AverageIncome = Convert.ToDecimal(txbCustomerIncome.Text);
            int MaritalStatusID = Convert.ToInt32(cbCustomerMarital.SelectedValue);
            int Debt = cbCustomerDebt.SelectedItem.ToString() == "Có" ? 1 : 0;
            int Loans = Convert.ToInt32(txbCustormerLoan.Text);
            string CreditTerm = txbCreditTern.Text;

            // Tạo một đối tượng Customer mới với thông tin đã nhập
            Customer newCustomer = new Customer
            {
                CustomerName = CustomerName,
                CCCD = CCCD,
                Address = Address,
                CustomerPhone = CustomerPhone,
                Email = Email,
                Gender = Gender,
                DateOfBirth = DateOfBirth,
                OccupationID = OccupationID,
                AverageIncome = AverageIncome,
                MaritalStatusID = MaritalStatusID,
                Debt = Debt,
                Loans = Loans,
                CreditTerm = CreditTerm,
            };
            // Lấy CustomerID của khách hàng mới vừa tạo
            newCustomer.CustomerID = AccountDAO.Instance.GetCustomerIDAfterInsert();
            return newCustomer;
        }
    }
}
