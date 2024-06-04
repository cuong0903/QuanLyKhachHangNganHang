namespace QuanLyKhachHangNganHang
{
    partial class InfoTransaction
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
            btnDelete = new Button();
            label7 = new Label();
            btnUpdate = new Button();
            panel2 = new Panel();
            dtgvTransaction = new DataGridView();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpTransactionDate = new DateTimePicker();
            cbServiceName = new ComboBox();
            txbTransactionAmount = new TextBox();
            txbTransactionDescription = new TextBox();
            txbTransactionID = new TextBox();
            groupBox1 = new GroupBox();
            txbAccountBalance = new TextBox();
            txbCustomerrName = new TextBox();
            label14 = new Label();
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
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTransaction).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(4, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 489);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(btnUpdate);
            panel3.Location = new Point(446, 433);
            panel3.Name = "panel3";
            panel3.Size = new Size(424, 53);
            panel3.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(39, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm giao dịch";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(337, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(77, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "Quay Lại";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(258, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(73, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(166, 16);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(166, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(83, 29);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvTransaction);
            panel2.Location = new Point(1, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(439, 327);
            panel2.TabIndex = 2;
            // 
            // dtgvTransaction
            // 
            dtgvTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTransaction.Location = new Point(2, 0);
            dtgvTransaction.Name = "dtgvTransaction";
            dtgvTransaction.RowHeadersWidth = 51;
            dtgvTransaction.Size = new Size(433, 319);
            dtgvTransaction.TabIndex = 0;
            dtgvTransaction.CellClick += InfoTransaction_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dtpTransactionDate);
            groupBox2.Controls.Add(cbServiceName);
            groupBox2.Controls.Add(txbTransactionAmount);
            groupBox2.Controls.Add(txbTransactionDescription);
            groupBox2.Controls.Add(txbTransactionID);
            groupBox2.Location = new Point(446, 159);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(424, 274);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin giao dịch";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 248);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 26;
            label5.Text = "Mô tả giao dịch:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 111);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 25;
            label4.Text = "Ngày giao dịch:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 67);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 24;
            label3.Text = "Tên dịch vụ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 160);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 23;
            label2.Text = "Số tiền:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 29);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 16;
            label1.Text = "ID giao dịch:";
            // 
            // dtpTransactionDate
            // 
            dtpTransactionDate.Location = new Point(156, 104);
            dtpTransactionDate.Name = "dtpTransactionDate";
            dtpTransactionDate.Size = new Size(259, 27);
            dtpTransactionDate.TabIndex = 16;
            // 
            // cbServiceName
            // 
            cbServiceName.FormattingEnabled = true;
            cbServiceName.Location = new Point(157, 59);
            cbServiceName.Name = "cbServiceName";
            cbServiceName.Size = new Size(258, 28);
            cbServiceName.TabIndex = 22;
            // 
            // txbTransactionAmount
            // 
            txbTransactionAmount.Location = new Point(156, 153);
            txbTransactionAmount.Name = "txbTransactionAmount";
            txbTransactionAmount.Size = new Size(259, 27);
            txbTransactionAmount.TabIndex = 21;
            // 
            // txbTransactionDescription
            // 
            txbTransactionDescription.Location = new Point(155, 241);
            txbTransactionDescription.Name = "txbTransactionDescription";
            txbTransactionDescription.Size = new Size(259, 27);
            txbTransactionDescription.TabIndex = 20;
            // 
            // txbTransactionID
            // 
            txbTransactionID.Location = new Point(157, 26);
            txbTransactionID.Name = "txbTransactionID";
            txbTransactionID.Size = new Size(259, 27);
            txbTransactionID.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbAccountBalance);
            groupBox1.Controls.Add(txbCustomerrName);
            groupBox1.Controls.Add(label14);
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
            groupBox1.Location = new Point(3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(867, 156);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin tài khoản:";
            // 
            // txbAccountBalance
            // 
            txbAccountBalance.Location = new Point(138, 128);
            txbAccountBalance.Name = "txbAccountBalance";
            txbAccountBalance.ReadOnly = true;
            txbAccountBalance.Size = new Size(259, 27);
            txbAccountBalance.TabIndex = 3;
            // 
            // txbCustomerrName
            // 
            txbCustomerrName.Location = new Point(141, 20);
            txbCustomerrName.Name = "txbCustomerrName";
            txbCustomerrName.ReadOnly = true;
            txbCustomerrName.Size = new Size(259, 27);
            txbCustomerrName.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 23);
            label14.Name = "label14";
            label14.Size = new Size(111, 20);
            label14.TabIndex = 11;
            label14.Text = "Tên khách hàng";
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
            label12.Location = new Point(8, 55);
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
            txbAccountID.Location = new Point(138, 55);
            txbAccountID.Name = "txbAccountID";
            txbAccountID.ReadOnly = true;
            txbAccountID.Size = new Size(259, 27);
            txbAccountID.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(8, 100);
            label13.Name = "label13";
            label13.Size = new Size(94, 20);
            label13.TabIndex = 10;
            label13.Text = "Số tài khoản:";
            // 
            // txbAccountNumber
            // 
            txbAccountNumber.Location = new Point(138, 95);
            txbAccountNumber.Name = "txbAccountNumber";
            txbAccountNumber.ReadOnly = true;
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
            // InfoTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 491);
            Controls.Add(panel1);
            Name = "InfoTransaction";
            Text = "Thông Tin Giao Dịch";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTransaction).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private DataGridView dtgvTransaction;
        private TextBox txbTransactionID;
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
        private Label label14;
        private TextBox txbCustomerrName;
        private Label label11;
        private DateTimePicker dtpTransactionDate;
        private ComboBox cbServiceName;
        private TextBox txbTransactionAmount;
        private TextBox txbTransactionDescription;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnExit;
        private Button btnDelete;
        private Label label7;
        private Button btnUpdate;
        private Button btnAdd;
    }
}