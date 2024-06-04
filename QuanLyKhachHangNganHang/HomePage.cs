using QuanLyKhachHangNganHang.DAO;
using QuanLyKhachHangNganHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachHangNganHang
{
    public partial class HomePage : Form
    {
        private Employee loginAccount; // Biến lưu trữ tài khoản nhân viên đăng nhập

        public HomePage()
        {
            InitializeComponent();
            RefreshListAccount();
        }

        // Sự kiện khi nhấn nút thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            Login f = new Login(); // Tạo đối tượng form Login
            this.Hide();
            f.ShowDialog();
            this.Show(); // Hiển thị lại form HomePage sau khi form Login đóng
        }

        // Phương thức làm mới danh sách tài khoản
        public void RefreshListAccount()
        {
            LoadListHomePageHistory(); // Tải lại danh sách tài khoản từ cơ sở dữ liệu
        }

        // Phương thức tải danh sách tài khoản lên DataGridView
        void LoadListHomePageHistory()
        {
            dtgvHomePage.DataSource = AccountDAO.Instance.GetListAccount(); // Lấy dữ liệu từ cơ sở dữ liệu và gán cho DataGridView
        }

        // Sự kiện khi nhấn vào mục "Quản Lý Tài Khoản" trên menu
        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerAccount f = new ManagerAccount(); // Tạo đối tượng form ManagerAccount
            this.Hide();
            f.ShowDialog(); 
            this.Show(); // Hiển thị lại form HomePage sau khi form ManagerAccount đóng
        }

        // Sự kiện khi form Login đóng
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Thoát ứng dụng
        }

        // Sự kiện khi nhấn vào mục "Quản Lý Khách Hàng" trên menu
        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerCustomer f = new ManagerCustomer(); // Tạo đối tượng form ManagerCustomer
            this.Hide(); 
            f.ShowDialog();
            this.Show(); // Hiển thị lại form HomePage sau khi form ManagerCustomer đóng
        }

        // Sự kiện khi nhấn vào mục "Quản Lý Giao Dịch" trên menu
        private void quảnLýGiaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerTransaction f = new ManagerTransaction(); // Tạo đối tượng form ManagerTransaction
            this.Hide(); 
            f.ShowDialog(); 
            this.Show(); // Hiển thị lại form HomePage sau khi form ManagerTransaction đóng
        }

        // Sự kiện khi nhấn vào mục "Quản Lý Nhân Viên" trên menu
        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerEmployee f = new ManagerEmployee(); // Tạo đối tượng form ManagerEmployee
            this.Hide(); 
            f.ShowDialog(); 
            this.Show(); // Hiển thị lại form HomePage sau khi form ManagerEmployee đóng
        }

        // Sự kiện khi nhấn nút tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgvHomePage.DataSource = SearchAccount(txSearch.Text); // Tìm kiếm và hiển thị kết quả tìm kiếm tài khoản
        }

        // Phương thức tìm kiếm tài khoản
        List<Account> SearchAccount(string AccountSearch)
        {
            List<Account> account = AccountDAO.Instance.SearchAccount(AccountSearch); // Gọi phương thức tìm kiếm từ DAO
            return account; // Trả về danh sách tài khoản tìm được
        }
    }
}
