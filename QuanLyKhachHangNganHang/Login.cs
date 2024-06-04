using QuanLyKhachHangNganHang.DAO;
using QuanLyKhachHangNganHang.DTO;
using System.Security.Principal;

namespace QuanLyKhachHangNganHang
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string userName = txtEmployeeName.Text; 
            string passWord = txtPassWord.Text;
            if (PerformLogin(userName, passWord))
            {

                // Mở form quản lý bàn với thông tin tài khoản
                HomePage f = new HomePage();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }


        }
        bool PerformLogin(string userName, string passWord)
        {
            return EmployeesDAO.Instance.Login(userName, passWord);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel)
                != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
