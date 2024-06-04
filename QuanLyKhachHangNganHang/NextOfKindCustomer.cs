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
    public partial class NextOfKindCustomer : Form
    {
        private int customerID;
        private string customerName;
        public string CustomerName { get; }
        public NextOfKindCustomer(int customerID)
        {
            InitializeComponent();
            LoadListNextOfKin();
            this.customerID = customerID;
            this.customerName = CustomerDAO.Instance.GetCustomerNameByID(customerID);
            AddNextOfKinBinding();
            LoadNextOfKinForCustomer(customerID);
        }
        void LoadListNextOfKin()
        {
            // Lấy danh sách người thân từ DAO
            List<NextOfKin> nextOfKinList = NextOfKinDAO.Instance.GetListNextOfKin();

            // Gán danh sách người thân vào DataGridView
            dtgvNextOfKin.DataSource = nextOfKinList;

        }

        private void LoadNextOfKinForCustomer(int customerID)
        {
            List<NextOfKin> nextOfKinList = NextOfKinDAO.Instance.GetListNextOfKinByCustomerID(customerID);
            dtgvNextOfKin.DataSource = nextOfKinList;
            AddNextOfKinBinding(); // Cập nhật lại ánh xạ dữ liệu
        }
        void AddNextOfKinBinding()
        {
            // Gỡ bỏ tất cả các ánh xạ dữ liệu cũ trước khi thêm mới
            txbNextofKinID.DataBindings.Clear();
            txbNextOfKinName.DataBindings.Clear();
            txbCustomerID.DataBindings.Clear();
            txbCustomerName.DataBindings.Clear();
            txbRelationship.DataBindings.Clear();
            txbNextOfKindSDT.DataBindings.Clear();
            txbNextOfKindAddress.DataBindings.Clear();

            // Thêm ánh xạ dữ liệu mới
            txbNextofKinID.DataBindings.Add(new Binding("Text", dtgvNextOfKin.DataSource, "NextOfKinID", true, DataSourceUpdateMode.Never));
            txbNextOfKinName.DataBindings.Add(new Binding("Text", dtgvNextOfKin.DataSource, "NextOfKinName", true, DataSourceUpdateMode.Never));
            txbCustomerID.DataBindings.Add(new Binding("Text", customerID, ""));
            txbCustomerName.DataBindings.Add(new Binding("Text", customerName, ""));

            txbRelationship.DataBindings.Add(new Binding("Text", dtgvNextOfKin.DataSource, "NextOfKinRelationship", true, DataSourceUpdateMode.Never));
            txbNextOfKindSDT.DataBindings.Add(new Binding("Text", dtgvNextOfKin.DataSource, "NextOfKinPhone", true, DataSourceUpdateMode.Never));
            txbNextOfKindAddress.DataBindings.Add(new Binding("Text", dtgvNextOfKin.DataSource, "NextOfKinAddress", true, DataSourceUpdateMode.Never));
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int CustomerID = Convert.ToInt32(txbCustomerID.Text);
            string NextOfKinName = txbNextOfKinName.Text;
            string NextOfKinRelationship = txbRelationship.Text;
            string NextOfKinPhone = txbNextOfKindSDT.Text;
            string NextOfKinAddress = txbNextOfKindAddress.Text;

            if (NextOfKinDAO.Instance.InsertNextOfKin(CustomerID, NextOfKinName, NextOfKinRelationship, NextOfKinPhone, NextOfKinAddress))
            {
                MessageBox.Show("Thêm tài khoản thành công");

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm tải khoản");
            }
            LoadNextOfKinForCustomer(customerID);
            AddNextOfKinBinding(); // Cập nhật lại ánh xạ dữ liệu
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int NextOfKinID = Convert.ToInt32(txbNextofKinID.Text);
            int CustomerID = Convert.ToInt32(txbCustomerID.Text);
            string NextOfKinName = txbNextOfKinName.Text;
            string NextOfKinRelationship = txbRelationship.Text;
            string NextOfKinPhone = txbNextOfKindSDT.Text;
            string NextOfKinAddress = txbNextOfKindAddress.Text;

            if (NextOfKinDAO.Instance.UpdateNextOfKin(NextOfKinID, CustomerID, NextOfKinName, NextOfKinRelationship, NextOfKinPhone, NextOfKinAddress))
            {
                MessageBox.Show("Sửa loại tài khoản thành công");
                LoadNextOfKinForCustomer(customerID);
                AddNextOfKinBinding(); // Cập nhật lại ánh xạ dữ liệu
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa loại tài khoản");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dtgvNextOfKin.SelectedCells.Count > 0)
            {
                // Lấy chỉ số dòng của ô được chọn
                int selectedRowIndex = dtgvNextOfKin.SelectedCells[0].RowIndex;

                // Lấy giá trị của cột ID từ dòng được chọn
                object cellValue = dtgvNextOfKin.Rows[selectedRowIndex].Cells["NextOfKinID"].Value;

                // Kiểm tra xem giá trị cột ID có hợp lệ không
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int NextOfKinID))
                {
                    // Thực hiện xóa loại tài khoản với ID đã lấy được
                    if (NextOfKinDAO.Instance.DeleteNextOfKin(NextOfKinID))
                    {
                        MessageBox.Show("Xóa loại tài khoản thành công");
                        LoadNextOfKinForCustomer(customerID);
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

        private void dtgvNextOfKin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
