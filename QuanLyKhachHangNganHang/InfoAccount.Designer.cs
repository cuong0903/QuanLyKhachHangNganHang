namespace QuanLyKhachHangNganHang
{
    partial class InfoAccount
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
            panel3 = new Panel();
            btnAdd = new Button();
            btnExit = new Button();
            label8 = new Label();
            btnEditAccount = new Button();
            groupBox2 = new GroupBox();
            cbCustomerDebt = new ComboBox();
            cbOccupationStatus = new ComboBox();
            rdbGenderGirl = new RadioButton();
            rdbGenderBoy = new RadioButton();
            txbCreditTern = new TextBox();
            txbCustormerLoan = new TextBox();
            txbCustomerName = new TextBox();
            txbCustomerSDT = new TextBox();
            txbCustomerIncome = new TextBox();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label17 = new Label();
            label16 = new Label();
            txbCustormerEmail = new TextBox();
            dtpCustomerDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            cbCustomerMarital = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txbCustomerID = new TextBox();
            label5 = new Label();
            txbCustomerAdress = new TextBox();
            label6 = new Label();
            txbCustomerCMND = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            txbAccountBalance = new TextBox();
            dtpAccountOpenDate = new DateTimePicker();
            label9 = new Label();
            cbAccountStatus = new ComboBox();
            label10 = new Label();
            cbAccountTypeName = new ComboBox();
            label12 = new Label();
            label15 = new Label();
            txbAccountID = new TextBox();
            label13 = new Label();
            txbAccountNumber = new TextBox();
            label11 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 510);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(btnEditAccount);
            panel3.Location = new Point(355, 464);
            panel3.Name = "panel3";
            panel3.Size = new Size(526, 43);
            panel3.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(130, 7);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm dữ liệu";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(393, 7);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "Quay Lại";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(166, 16);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 6;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(270, 7);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(94, 29);
            btnEditAccount.TabIndex = 0;
            btnEditAccount.Text = "Cập Nhật";
            btnEditAccount.UseVisualStyleBackColor = true;
            btnEditAccount.Click += btnEditAccount_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbCustomerDebt);
            groupBox2.Controls.Add(cbOccupationStatus);
            groupBox2.Controls.Add(rdbGenderGirl);
            groupBox2.Controls.Add(rdbGenderBoy);
            groupBox2.Controls.Add(txbCreditTern);
            groupBox2.Controls.Add(txbCustormerLoan);
            groupBox2.Controls.Add(txbCustomerName);
            groupBox2.Controls.Add(txbCustomerSDT);
            groupBox2.Controls.Add(txbCustomerIncome);
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(txbCustormerEmail);
            groupBox2.Controls.Add(dtpCustomerDate);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cbCustomerMarital);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txbCustomerID);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txbCustomerAdress);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txbCustomerCMND);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(8, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(867, 287);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin khách hàng:";
            // 
            // cbCustomerDebt
            // 
            cbCustomerDebt.FormattingEnabled = true;
            cbCustomerDebt.Location = new Point(602, 189);
            cbCustomerDebt.Name = "cbCustomerDebt";
            cbCustomerDebt.Size = new Size(255, 28);
            cbCustomerDebt.TabIndex = 37;
            // 
            // cbOccupationStatus
            // 
            cbOccupationStatus.FormattingEnabled = true;
            cbOccupationStatus.Location = new Point(165, 197);
            cbOccupationStatus.Name = "cbOccupationStatus";
            cbOccupationStatus.Size = new Size(258, 28);
            cbOccupationStatus.TabIndex = 34;
            // 
            // rdbGenderGirl
            // 
            rdbGenderGirl.AutoSize = true;
            rdbGenderGirl.Location = new Point(681, 130);
            rdbGenderGirl.Name = "rdbGenderGirl";
            rdbGenderGirl.Size = new Size(50, 24);
            rdbGenderGirl.TabIndex = 33;
            rdbGenderGirl.TabStop = true;
            rdbGenderGirl.Text = "Nữ";
            rdbGenderGirl.UseVisualStyleBackColor = true;
            // 
            // rdbGenderBoy
            // 
            rdbGenderBoy.AutoSize = true;
            rdbGenderBoy.Location = new Point(602, 130);
            rdbGenderBoy.Name = "rdbGenderBoy";
            rdbGenderBoy.Size = new Size(62, 24);
            rdbGenderBoy.TabIndex = 32;
            rdbGenderBoy.TabStop = true;
            rdbGenderBoy.Text = "Nam";
            rdbGenderBoy.UseVisualStyleBackColor = true;
            // 
            // txbCreditTern
            // 
            txbCreditTern.Location = new Point(602, 254);
            txbCreditTern.Name = "txbCreditTern";
            txbCreditTern.ReadOnly = true;
            txbCreditTern.Size = new Size(259, 27);
            txbCreditTern.TabIndex = 31;
            // 
            // txbCustormerLoan
            // 
            txbCustormerLoan.Location = new Point(602, 221);
            txbCustormerLoan.Name = "txbCustormerLoan";
            txbCustormerLoan.ReadOnly = true;
            txbCustormerLoan.Size = new Size(259, 27);
            txbCustormerLoan.TabIndex = 30;
            // 
            // txbCustomerName
            // 
            txbCustomerName.Location = new Point(601, 19);
            txbCustomerName.Name = "txbCustomerName";
            txbCustomerName.ReadOnly = true;
            txbCustomerName.Size = new Size(259, 27);
            txbCustomerName.TabIndex = 29;
            // 
            // txbCustomerSDT
            // 
            txbCustomerSDT.Location = new Point(601, 59);
            txbCustomerSDT.Name = "txbCustomerSDT";
            txbCustomerSDT.ReadOnly = true;
            txbCustomerSDT.Size = new Size(259, 27);
            txbCustomerSDT.TabIndex = 28;
            // 
            // txbCustomerIncome
            // 
            txbCustomerIncome.Location = new Point(165, 246);
            txbCustomerIncome.Name = "txbCustomerIncome";
            txbCustomerIncome.ReadOnly = true;
            txbCustomerIncome.Size = new Size(259, 27);
            txbCustomerIncome.TabIndex = 26;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(434, 249);
            label23.Name = "label23";
            label23.Size = new Size(98, 20);
            label23.TabIndex = 23;
            label23.Text = "Hạn tín dụng:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(434, 212);
            label22.Name = "label22";
            label22.Size = new Size(77, 20);
            label22.TabIndex = 22;
            label22.Text = "Khoản vay";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(432, 185);
            label21.Name = "label21";
            label21.Size = new Size(100, 20);
            label21.TabIndex = 21;
            label21.Text = "Tình trạng nợ:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(14, 249);
            label20.Name = "label20";
            label20.Size = new Size(145, 20);
            label20.TabIndex = 20;
            label20.Text = "Thu nhập trung bình:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(432, 158);
            label19.Name = "label19";
            label19.Size = new Size(144, 20);
            label19.TabIndex = 19;
            label19.Text = "Tình trạng hôn nhân:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(14, 205);
            label17.Name = "label17";
            label17.Size = new Size(98, 20);
            label17.TabIndex = 17;
            label17.Text = "Nghề nghiệp:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(432, 128);
            label16.Name = "label16";
            label16.Size = new Size(68, 20);
            label16.TabIndex = 16;
            label16.Text = "Giới tính:";
            // 
            // txbCustormerEmail
            // 
            txbCustormerEmail.Location = new Point(165, 128);
            txbCustormerEmail.Name = "txbCustormerEmail";
            txbCustormerEmail.ReadOnly = true;
            txbCustormerEmail.Size = new Size(259, 27);
            txbCustormerEmail.TabIndex = 3;
            // 
            // dtpCustomerDate
            // 
            dtpCustomerDate.Location = new Point(601, 97);
            dtpCustomerDate.Name = "dtpCustomerDate";
            dtpCustomerDate.Size = new Size(259, 27);
            dtpCustomerDate.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 135);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 8;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 93);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 7;
            label2.Text = "Ngày sinh:";
            // 
            // cbCustomerMarital
            // 
            cbCustomerMarital.FormattingEnabled = true;
            cbCustomerMarital.Location = new Point(602, 155);
            cbCustomerMarital.Name = "cbCustomerMarital";
            cbCustomerMarital.Size = new Size(258, 28);
            cbCustomerMarital.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 23);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 5;
            label3.Text = "ID khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(437, 67);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 12;
            label4.Text = "Số điện thoại:";
            // 
            // txbCustomerID
            // 
            txbCustomerID.Location = new Point(165, 24);
            txbCustomerID.Name = "txbCustomerID";
            txbCustomerID.ReadOnly = true;
            txbCustomerID.Size = new Size(259, 27);
            txbCustomerID.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 62);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 10;
            label5.Text = "Địa chỉ:";
            // 
            // txbCustomerAdress
            // 
            txbCustomerAdress.Location = new Point(165, 60);
            txbCustomerAdress.Name = "txbCustomerAdress";
            txbCustomerAdress.ReadOnly = true;
            txbCustomerAdress.Size = new Size(259, 27);
            txbCustomerAdress.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 102);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 11;
            label6.Text = "Số CMND/CCCD:";
            // 
            // txbCustomerCMND
            // 
            txbCustomerCMND.Location = new Point(165, 93);
            txbCustomerCMND.Name = "txbCustomerCMND";
            txbCustomerCMND.ReadOnly = true;
            txbCustomerCMND.Size = new Size(259, 27);
            txbCustomerCMND.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(434, 26);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 6;
            label7.Text = "Tên khách hàng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbAccountBalance);
            groupBox1.Controls.Add(dtpAccountOpenDate);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cbAccountStatus);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cbAccountTypeName);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txbAccountID);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txbAccountNumber);
            groupBox1.Controls.Add(label11);
            groupBox1.Location = new Point(14, 302);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(867, 156);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin tài khoản:";
            // 
            // txbAccountBalance
            // 
            txbAccountBalance.Location = new Point(138, 128);
            txbAccountBalance.Name = "txbAccountBalance";
            txbAccountBalance.Size = new Size(259, 27);
            txbAccountBalance.TabIndex = 3;
            // 
            // dtpAccountOpenDate
            // 
            dtpAccountOpenDate.Location = new Point(602, 93);
            dtpAccountOpenDate.Name = "dtpAccountOpenDate";
            dtpAccountOpenDate.Size = new Size(259, 27);
            dtpAccountOpenDate.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 136);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 8;
            label9.Text = "Số dư:";
            // 
            // cbAccountStatus
            // 
            cbAccountStatus.FormattingEnabled = true;
            cbAccountStatus.Location = new Point(602, 59);
            cbAccountStatus.Name = "cbAccountStatus";
            cbAccountStatus.Size = new Size(258, 28);
            cbAccountStatus.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(426, 93);
            label10.Name = "label10";
            label10.Size = new Size(141, 20);
            label10.TabIndex = 7;
            label10.Text = "Ngày Mở Tài Khoản:";
            // 
            // cbAccountTypeName
            // 
            cbAccountTypeName.FormattingEnabled = true;
            cbAccountTypeName.Location = new Point(602, 23);
            cbAccountTypeName.Name = "cbAccountTypeName";
            cbAccountTypeName.Size = new Size(258, 28);
            cbAccountTypeName.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 23);
            label12.Name = "label12";
            label12.Size = new Size(92, 20);
            label12.TabIndex = 5;
            label12.Text = "ID tài khoản:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(426, 62);
            label15.Name = "label15";
            label15.Size = new Size(79, 20);
            label15.TabIndex = 12;
            label15.Text = "Tình trạng:";
            // 
            // txbAccountID
            // 
            txbAccountID.Location = new Point(139, 26);
            txbAccountID.Name = "txbAccountID";
            txbAccountID.Size = new Size(259, 27);
            txbAccountID.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 62);
            label13.Name = "label13";
            label13.Size = new Size(94, 20);
            label13.TabIndex = 10;
            label13.Text = "Số tài khoản:";
            // 
            // txbAccountNumber
            // 
            txbAccountNumber.Location = new Point(139, 62);
            txbAccountNumber.Name = "txbAccountNumber";
            txbAccountNumber.Size = new Size(259, 27);
            txbAccountNumber.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(426, 26);
            label11.Name = "label11";
            label11.Size = new Size(129, 20);
            label11.TabIndex = 6;
            label11.Text = "Tên loại tài khoản:";
            // 
            // InfoAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 509);
            Controls.Add(panel1);
            Name = "InfoAccount";
            Text = "Thông tin Tài Khoản";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private TextBox txbCustormerEmail;
        private DateTimePicker dtpCustomerDate;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox cbCustomerMarital;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
        private TextBox txbCustomerID;
        private TextBox textBox2;
        private Label label5;
        private TextBox txbCustomerAdress;
        private TextBox textBox3;
        private Label label6;
        private TextBox txbCustomerCMND;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox txbAccountBalance;
        private DateTimePicker dtpAccountOpenDate;
        private Label label9;
        private ComboBox cbAccountStatus;
        private Label label10;
        private ComboBox cbAccountTypeName;
        private Label label12;
        private Label label15;
        private TextBox txbAccountID;
        private Label label13;
        private TextBox txbAccountNumber;
        private Label label11;
        private Panel panel3;
        private Button btnExit;
        private Label label8;
        private Button btnEditAccount;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label17;
        private Label label16;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox txbCustomerName;
        private TextBox txbCustormerLoan;
        private TextBox txbCreditTern;
        private RadioButton rdbGenderBoy;
        private RadioButton rdbGenderGirl;
        private TextBox textBox9;
        private TextBox txbCustomerSDT;
        private TextBox txbCustomerIncome;
        private Button btnAdd;
        private ComboBox cbOccupationStatus;
        private ComboBox cbCustomerDebt;
    }
}