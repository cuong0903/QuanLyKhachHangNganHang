namespace QuanLyKhachHangNganHang
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtPassWord = new TextBox();
            txtEmployeeName = new TextBox();
            btnExit = new Button();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPassWord);
            panel1.Controls.Add(txtEmployeeName);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 202);
            panel1.TabIndex = 0;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(208, 71);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(324, 27);
            txtPassWord.TabIndex = 2;
            txtPassWord.Text = "admin";
            txtPassWord.UseSystemPasswordChar = true;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(208, 28);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(324, 27);
            txtEmployeeName.TabIndex = 1;
            txtEmployeeName.Text = "admin";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnExit.Location = new Point(438, 146);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 36);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnLogin.Location = new Point(269, 146);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(145, 36);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(20, 74);
            label2.Name = "label2";
            label2.Size = new Size(107, 24);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(13, 28);
            label1.Name = "label1";
            label1.Size = new Size(163, 24);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng Nhập:";
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(556, 210);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Trang Đăng Nhập";
            FormClosing += Login_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtPassWord;
        private TextBox txtEmployeeName;
        private Button btnExit;
        private Button btnLogin;
        private Label label2;
        private Label label1;
    }
}
