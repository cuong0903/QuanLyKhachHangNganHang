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
    public partial class ManagerEmployee : Form
    {
        public ManagerEmployee()
        {
            InitializeComponent();
            LoadListEmployee();
            AddEmployeeBinding();
        }
        List<Employee> SearchEmployeeByName(string EmployeeName)
        {
            List<Employee> employeeslist = EmployeesDAO.Instance.SearchEmployeeName(EmployeeName);
            return employeeslist;
        }



        void LoadListEmployee()
        {
            dtgvEmployee.DataSource = EmployeesDAO.Instance.GetListEmplyees();
        }


        void AddEmployeeBinding()
        {
            // Gỡ bỏ tất cả các ánh xạ dữ liệu cũ trước khi thêm mới
            /*            txbEmployeeID.DataBindings.Clear();
                        txbEmployeeName.DataBindings.Clear();
                        txbDisplayName.DataBindings.Clear();
                        txbPosition.DataBindings.Clear();*/



            // Gỡ bỏ tất cả các ánh xạ dữ liệu cũ trước khi thêm mới
            txbEmployeeID.DataBindings.Clear();
            txbEmployeeName.DataBindings.Clear();
            txbDisplayName.DataBindings.Clear();
            txbPosition.DataBindings.Clear();

            // Thêm ánh xạ dữ liệu mới nếu chưa tồn tại
            if (txbEmployeeID.DataBindings.Count == 0)
            {
                txbEmployeeID.DataBindings.Add(new Binding("Text", dtgvEmployee.DataSource, "EmployeeID", true, DataSourceUpdateMode.Never));
            }
            if (txbEmployeeName.DataBindings.Count == 0)
            {
                txbEmployeeName.DataBindings.Add(new Binding("Text", dtgvEmployee.DataSource, "EmployeeName", true, DataSourceUpdateMode.Never));
            }
            if (txbDisplayName.DataBindings.Count == 0)
            {
                txbDisplayName.DataBindings.Add(new Binding("Text", dtgvEmployee.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            }
            if (txbPassWord.DataBindings.Count == 0)
            {
                txbPassWord.DataBindings.Add(new Binding("Text", dtgvEmployee.DataSource, "Password", true, DataSourceUpdateMode.Never));
            }
            if (txbPosition.DataBindings.Count == 0)
            {
                txbPosition.DataBindings.Add(new Binding("Text", dtgvEmployee.DataSource, "Position", true, DataSourceUpdateMode.Never));
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dtgvEmployee.SelectedCells.Count > 0)
            {
                // Lấy chỉ số dòng của ô được chọn
                int selectedRowIndex = dtgvEmployee.SelectedCells[0].RowIndex;

                // Lấy giá trị của cột ID từ dòng được chọn
                object cellValue = dtgvEmployee.Rows[selectedRowIndex].Cells["EmployeeID"].Value;

                // Kiểm tra xem giá trị cột ID có hợp lệ không
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int EmployeeID))
                {
                    // Thực hiện xóa loại tài khoản với ID đã lấy được
                    if (EmployeesDAO.Instance.DeleteEmployee(EmployeeID))
                    {
                        MessageBox.Show("Xóa loại dịch vụ thành công");
                        LoadListEmployee();
                        AddEmployeeBinding();
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string EmployeeName = txbEmployeeName.Text;
            string DisplayName = txbDisplayName.Text;
            string Password = txbPassWord.Text;
            int Position = Convert.ToInt32(txbPosition.Text);

            if (EmployeesDAO.Instance.InsertEmployee(EmployeeName, DisplayName, Password, Position))
            {
                MessageBox.Show("Thêm dịch thành công");
                LoadListEmployee();
                AddEmployeeBinding();

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm dịch vụ");
            }


        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            int EmployeeID = Convert.ToInt32(txbEmployeeID.Text);
            string EmployeeName = txbEmployeeName.Text;
            string DisplayName = txbDisplayName.Text;
            string Password = txbPassWord.Text;
            int Position = Convert.ToInt32(txbPosition.Text);

            if (EmployeesDAO.Instance.UpdateEmployee(EmployeeID, EmployeeName, DisplayName, Password, Position))
            {
                MessageBox.Show("Sửa loại dịch vụ thành công");
                LoadListEmployee();

            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa loại dịch vụ");
            }


        }
        private void btnSreach_Click(object sender, EventArgs e)
        {
            dtgvEmployee.DataSource = SearchEmployeeByName(txbSreach.Text);
        }

        private void ManagerEmployee_Load(object sender, EventArgs e)
        {

        }
    }


}
