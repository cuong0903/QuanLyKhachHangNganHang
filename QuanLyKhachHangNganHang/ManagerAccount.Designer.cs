namespace QuanLyKhachHangNganHang
{
    partial class ManagerAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tcManagerAccount = new TabControl();
            tpAccount = new TabPage();
            panel10 = new Panel();
            btnCheckTransactionHistory = new Button();
            panel6 = new Panel();
            btnSreachAccount = new Button();
            txbSreachAccount = new TextBox();
            label7 = new Label();
            panel7 = new Panel();
            btnDeleteAccount = new Button();
            btnEditAccount = new Button();
            btnAddAccount = new Button();
            panel8 = new Panel();
            cbAccountTypeName = new ComboBox();
            cbAccountStatus = new ComboBox();
            dtpAccountOpenDate = new DateTimePicker();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txbCustomerName = new TextBox();
            txbAccountBalance = new TextBox();
            txbAccountNumber = new TextBox();
            txbAccountID = new TextBox();
            panel9 = new Panel();
            dtgvAccount = new DataGridView();
            tpAccountType = new TabPage();
            panel5 = new Panel();
            btnSreachAccountType = new Button();
            txbSreachAccountType = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            btnDeleteAccountType = new Button();
            btnEditAccountType = new Button();
            btnAddAccountType = new Button();
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txbAccountTypeName = new TextBox();
            txbInterestRate = new TextBox();
            txbAccountTypeDescription = new TextBox();
            txbAccountTypeID = new TextBox();
            panel2 = new Panel();
            dtgvAccountType = new DataGridView();
            panel1.SuspendLayout();
            tcManagerAccount.SuspendLayout();
            tpAccount.SuspendLayout();
            panel10.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            tpAccountType.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccountType).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tcManagerAccount);
            panel1.Location = new Point(3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1238, 445);
            panel1.TabIndex = 0;
            // 
            // tcManagerAccount
            // 
            tcManagerAccount.Controls.Add(tpAccount);
            tcManagerAccount.Controls.Add(tpAccountType);
            tcManagerAccount.Location = new Point(3, 3);
            tcManagerAccount.Name = "tcManagerAccount";
            tcManagerAccount.SelectedIndex = 0;
            tcManagerAccount.Size = new Size(1237, 442);
            tcManagerAccount.TabIndex = 0;
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(panel10);
            tpAccount.Controls.Add(panel6);
            tpAccount.Controls.Add(panel7);
            tpAccount.Controls.Add(panel8);
            tpAccount.Controls.Add(panel9);
            tpAccount.Location = new Point(4, 29);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(1229, 409);
            tpAccount.TabIndex = 0;
            tpAccount.Text = "Tài Khoản";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnCheckTransactionHistory);
            panel10.Location = new Point(776, 347);
            panel10.Name = "panel10";
            panel10.Size = new Size(445, 52);
            panel10.TabIndex = 8;
            // 
            // btnCheckTransactionHistory
            // 
            btnCheckTransactionHistory.Location = new Point(147, 18);
            btnCheckTransactionHistory.Name = "btnCheckTransactionHistory";
            btnCheckTransactionHistory.Size = new Size(181, 29);
            btnCheckTransactionHistory.TabIndex = 1;
            btnCheckTransactionHistory.Text = "Kiểm tra Giao Dịch";
            btnCheckTransactionHistory.UseVisualStyleBackColor = true;
            btnCheckTransactionHistory.Click += btnCheckTransactionHistory_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnSreachAccount);
            panel6.Controls.Add(txbSreachAccount);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(779, 15);
            panel6.Name = "panel6";
            panel6.Size = new Size(443, 35);
            panel6.TabIndex = 7;
            // 
            // btnSreachAccount
            // 
            btnSreachAccount.Location = new Point(346, 3);
            btnSreachAccount.Name = "btnSreachAccount";
            btnSreachAccount.Size = new Size(94, 29);
            btnSreachAccount.TabIndex = 3;
            btnSreachAccount.Text = "Tìm kiếm";
            btnSreachAccount.UseVisualStyleBackColor = true;
            btnSreachAccount.Click += btnSreachAccount_Click;
            // 
            // txbSreachAccount
            // 
            txbSreachAccount.Location = new Point(11, 4);
            txbSreachAccount.Name = "txbSreachAccount";
            txbSreachAccount.Size = new Size(329, 27);
            txbSreachAccount.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(356, 7);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnDeleteAccount);
            panel7.Controls.Add(btnEditAccount);
            panel7.Controls.Add(btnAddAccount);
            panel7.Location = new Point(5, 15);
            panel7.Name = "panel7";
            panel7.Size = new Size(762, 35);
            panel7.TabIndex = 6;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(552, 4);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(94, 29);
            btnDeleteAccount.TabIndex = 3;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(327, 3);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(94, 29);
            btnEditAccount.TabIndex = 2;
            btnEditAccount.Text = "Sửa";
            btnEditAccount.UseVisualStyleBackColor = true;
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(32, 3);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(94, 29);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(cbAccountTypeName);
            panel8.Controls.Add(cbAccountStatus);
            panel8.Controls.Add(dtpAccountOpenDate);
            panel8.Controls.Add(label15);
            panel8.Controls.Add(label14);
            panel8.Controls.Add(label13);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label10);
            panel8.Controls.Add(label11);
            panel8.Controls.Add(label12);
            panel8.Controls.Add(txbCustomerName);
            panel8.Controls.Add(txbAccountBalance);
            panel8.Controls.Add(txbAccountNumber);
            panel8.Controls.Add(txbAccountID);
            panel8.Location = new Point(776, 52);
            panel8.Name = "panel8";
            panel8.Size = new Size(446, 289);
            panel8.TabIndex = 5;
            // 
            // cbAccountTypeName
            // 
            cbAccountTypeName.FormattingEnabled = true;
            cbAccountTypeName.Location = new Point(170, 134);
            cbAccountTypeName.Name = "cbAccountTypeName";
            cbAccountTypeName.Size = new Size(258, 28);
            cbAccountTypeName.TabIndex = 15;
            // 
            // cbAccountStatus
            // 
            cbAccountStatus.FormattingEnabled = true;
            cbAccountStatus.Location = new Point(169, 175);
            cbAccountStatus.Name = "cbAccountStatus";
            cbAccountStatus.Size = new Size(258, 28);
            cbAccountStatus.TabIndex = 14;
            // 
            // dtpAccountOpenDate
            // 
            dtpAccountOpenDate.Location = new Point(169, 215);
            dtpAccountOpenDate.Name = "dtpAccountOpenDate";
            dtpAccountOpenDate.Size = new Size(259, 27);
            dtpAccountOpenDate.TabIndex = 13;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 183);
            label15.Name = "label15";
            label15.Size = new Size(79, 20);
            label15.TabIndex = 12;
            label15.Text = "Tình trạng:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(9, 97);
            label14.Name = "label14";
            label14.Size = new Size(127, 20);
            label14.TabIndex = 11;
            label14.Text = "Tên chủ tài khoản:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 57);
            label13.Name = "label13";
            label13.Size = new Size(94, 20);
            label13.TabIndex = 10;
            label13.Text = "Số tài khoản:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 244);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 255);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 8;
            label9.Text = "Số dư:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 216);
            label10.Name = "label10";
            label10.Size = new Size(141, 20);
            label10.TabIndex = 7;
            label10.Text = "Ngày Mở Tài Khoản:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 137);
            label11.Name = "label11";
            label11.Size = new Size(129, 20);
            label11.TabIndex = 6;
            label11.Text = "Tên loại tài khoản:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 12);
            label12.Name = "label12";
            label12.Size = new Size(92, 20);
            label12.TabIndex = 5;
            label12.Text = "ID tài khoản:";
            // 
            // txbCustomerName
            // 
            txbCustomerName.Location = new Point(169, 90);
            txbCustomerName.Name = "txbCustomerName";
            txbCustomerName.Size = new Size(259, 27);
            txbCustomerName.TabIndex = 4;
            // 
            // txbAccountBalance
            // 
            txbAccountBalance.Location = new Point(169, 248);
            txbAccountBalance.Name = "txbAccountBalance";
            txbAccountBalance.Size = new Size(259, 27);
            txbAccountBalance.TabIndex = 3;
            // 
            // txbAccountNumber
            // 
            txbAccountNumber.Location = new Point(170, 57);
            txbAccountNumber.Name = "txbAccountNumber";
            txbAccountNumber.Size = new Size(259, 27);
            txbAccountNumber.TabIndex = 1;
            // 
            // txbAccountID
            // 
            txbAccountID.Location = new Point(169, 12);
            txbAccountID.Name = "txbAccountID";
            txbAccountID.ReadOnly = true;
            txbAccountID.Size = new Size(259, 27);
            txbAccountID.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(dtgvAccount);
            panel9.Location = new Point(8, 56);
            panel9.Name = "panel9";
            panel9.Size = new Size(762, 338);
            panel9.TabIndex = 4;
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(4, 3);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.Size = new Size(755, 342);
            dtgvAccount.TabIndex = 0;
            dtgvAccount.CellClick += dtgvAccount_CellClick;
            // 
            // tpAccountType
            // 
            tpAccountType.Controls.Add(panel5);
            tpAccountType.Controls.Add(panel4);
            tpAccountType.Controls.Add(panel3);
            tpAccountType.Controls.Add(panel2);
            tpAccountType.Location = new Point(4, 29);
            tpAccountType.Name = "tpAccountType";
            tpAccountType.Padding = new Padding(3);
            tpAccountType.Size = new Size(1229, 409);
            tpAccountType.TabIndex = 1;
            tpAccountType.Text = "Loại Tài Khoản";
            tpAccountType.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnSreachAccountType);
            panel5.Controls.Add(txbSreachAccountType);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(760, 11);
            panel5.Name = "panel5";
            panel5.Size = new Size(443, 35);
            panel5.TabIndex = 3;
            // 
            // btnSreachAccountType
            // 
            btnSreachAccountType.Location = new Point(346, 3);
            btnSreachAccountType.Name = "btnSreachAccountType";
            btnSreachAccountType.Size = new Size(94, 29);
            btnSreachAccountType.TabIndex = 2;
            btnSreachAccountType.Text = "Tìm kiếm";
            btnSreachAccountType.UseVisualStyleBackColor = true;
            btnSreachAccountType.Click += btnSreachAccountType_Click;
            // 
            // txbSreachAccountType
            // 
            txbSreachAccountType.Location = new Point(11, 4);
            txbSreachAccountType.Name = "txbSreachAccountType";
            txbSreachAccountType.Size = new Size(329, 27);
            txbSreachAccountType.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 7);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnDeleteAccountType);
            panel4.Controls.Add(btnEditAccountType);
            panel4.Controls.Add(btnAddAccountType);
            panel4.Location = new Point(4, 11);
            panel4.Name = "panel4";
            panel4.Size = new Size(750, 35);
            panel4.TabIndex = 2;
            // 
            // btnDeleteAccountType
            // 
            btnDeleteAccountType.Location = new Point(590, 6);
            btnDeleteAccountType.Name = "btnDeleteAccountType";
            btnDeleteAccountType.Size = new Size(94, 29);
            btnDeleteAccountType.TabIndex = 3;
            btnDeleteAccountType.Text = "Xóa";
            btnDeleteAccountType.UseVisualStyleBackColor = true;
            btnDeleteAccountType.Click += btnDeleteAccountType_Click;
            // 
            // btnEditAccountType
            // 
            btnEditAccountType.Location = new Point(356, 6);
            btnEditAccountType.Name = "btnEditAccountType";
            btnEditAccountType.Size = new Size(94, 29);
            btnEditAccountType.TabIndex = 2;
            btnEditAccountType.Text = "Sửa";
            btnEditAccountType.UseVisualStyleBackColor = true;
            btnEditAccountType.Click += btnEditAccountType_Click;
            // 
            // btnAddAccountType
            // 
            btnAddAccountType.Location = new Point(101, 2);
            btnAddAccountType.Name = "btnAddAccountType";
            btnAddAccountType.Size = new Size(94, 29);
            btnAddAccountType.TabIndex = 0;
            btnAddAccountType.Text = "Thêm";
            btnAddAccountType.UseVisualStyleBackColor = true;
            btnAddAccountType.Click += btnAddAccountType_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txbAccountTypeName);
            panel3.Controls.Add(txbInterestRate);
            panel3.Controls.Add(txbAccountTypeDescription);
            panel3.Controls.Add(txbAccountTypeID);
            panel3.Location = new Point(760, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(446, 289);
            panel3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 192);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 8;
            label5.Text = "Mức lãi xuất:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 137);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 7;
            label4.Text = "Mô tả loại tài khoản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 78);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 6;
            label3.Text = "Tên loại tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 28);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 5;
            label2.Text = "ID loại tài khoản:";
            // 
            // txbAccountTypeName
            // 
            txbAccountTypeName.Location = new Point(169, 71);
            txbAccountTypeName.Name = "txbAccountTypeName";
            txbAccountTypeName.Size = new Size(259, 27);
            txbAccountTypeName.TabIndex = 4;
            // 
            // txbInterestRate
            // 
            txbInterestRate.Location = new Point(169, 185);
            txbInterestRate.Name = "txbInterestRate";
            txbInterestRate.Size = new Size(259, 27);
            txbInterestRate.TabIndex = 2;
            // 
            // txbAccountTypeDescription
            // 
            txbAccountTypeDescription.Location = new Point(169, 130);
            txbAccountTypeDescription.Name = "txbAccountTypeDescription";
            txbAccountTypeDescription.Size = new Size(259, 27);
            txbAccountTypeDescription.TabIndex = 1;
            // 
            // txbAccountTypeID
            // 
            txbAccountTypeID.Location = new Point(169, 21);
            txbAccountTypeID.Name = "txbAccountTypeID";
            txbAccountTypeID.ReadOnly = true;
            txbAccountTypeID.Size = new Size(259, 27);
            txbAccountTypeID.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvAccountType);
            panel2.Location = new Point(7, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(747, 338);
            panel2.TabIndex = 0;
            // 
            // dtgvAccountType
            // 
            dtgvAccountType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccountType.Location = new Point(3, 0);
            dtgvAccountType.Name = "dtgvAccountType";
            dtgvAccountType.RowHeadersWidth = 51;
            dtgvAccountType.Size = new Size(740, 330);
            dtgvAccountType.TabIndex = 0;
            dtgvAccountType.CellClick += dtgvAccountType_CellClick;
            // 
            // ManagerAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 452);
            Controls.Add(panel1);
            Name = "ManagerAccount";
            Text = "ManagerAccount";
            panel1.ResumeLayout(false);
            tcManagerAccount.ResumeLayout(false);
            tpAccount.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            tpAccountType.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccountType).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tcManagerAccount;
        private TabPage tpAccount;
        private TabPage tpAccountType;
        private Panel panel5;
        private Panel panel4;
        private Button btnEditAccountType;
        private Button btnAddAccountType;
        private Panel panel3;
        private Panel panel2;
        private Button btnDeleteAccountType;
        private TextBox txbSreachAccountType;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox txbAccountTypeID;
        private TextBox txbAccountTypeDescription;
        private DataGridView dtgvAccountType;
        private Panel panel6;
        private TextBox txbSreachAccount;
        private Label label7;
        private Panel panel7;
        private Button btnDeleteAccount;
        private Button btnEditAccount;
        private Button btnAddAccount;
        private Panel panel8;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txbCustomerName;
        private TextBox txbAccountBalance;
        private TextBox txbAccountNumber;
        private TextBox txbAccountID;
        private Panel panel9;
        private DataGridView dtgvAccount;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSreachAccount;
        private Button btnSreachAccountType;
        private ComboBox cbAccountTypeName;
        private ComboBox cbAccountStatus;
        private DateTimePicker dtpAccountOpenDate;
        private Label label15;
        private Label label14;
        private Label label13;
        private Panel panel10;
        private Button btnCheckTransactionHistory;
        private TextBox txbInterestRate;
        private TextBox txbAccountTypeName;
    }
}