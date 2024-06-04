namespace QuanLyKhachHangNganHang
{
    partial class ManagerTransaction
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
            tcManagerAccount = new TabControl();
            tpTransaction = new TabPage();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            dtpTransactionDate = new DateTimePicker();
            cbServiceName = new ComboBox();
            txbTransactionAmount = new TextBox();
            txbTransactionDescription = new TextBox();
            txbTransactionID = new TextBox();
            panel10 = new Panel();
            panel6 = new Panel();
            btnSreachTransaction = new Button();
            txbSreachTransaction = new TextBox();
            label7 = new Label();
            panel7 = new Panel();
            btnExport = new Button();
            btnCheckAccount = new Button();
            panel9 = new Panel();
            dtgvTransactionHistory = new DataGridView();
            tpService = new TabPage();
            panel5 = new Panel();
            btnSreachService = new Button();
            txbSreachService = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            btnDeleteService = new Button();
            btnEditService = new Button();
            btnAddService = new Button();
            panel3 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txbServiceName = new TextBox();
            txbServiceStatus = new TextBox();
            txbServiceDescription = new TextBox();
            txbServicePrice = new TextBox();
            txbServiceID = new TextBox();
            panel2 = new Panel();
            dtgvService = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tcManagerAccount.SuspendLayout();
            tpTransaction.SuspendLayout();
            groupBox2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTransactionHistory).BeginInit();
            tpService.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvService).BeginInit();
            SuspendLayout();
            // 
            // tcManagerAccount
            // 
            tcManagerAccount.Controls.Add(tpTransaction);
            tcManagerAccount.Controls.Add(tpService);
            tcManagerAccount.Location = new Point(2, 12);
            tcManagerAccount.Name = "tcManagerAccount";
            tcManagerAccount.SelectedIndex = 0;
            tcManagerAccount.Size = new Size(913, 442);
            tcManagerAccount.TabIndex = 1;
            // 
            // tpTransaction
            // 
            tpTransaction.Controls.Add(groupBox2);
            tpTransaction.Controls.Add(panel10);
            tpTransaction.Controls.Add(panel6);
            tpTransaction.Controls.Add(panel7);
            tpTransaction.Controls.Add(panel9);
            tpTransaction.Location = new Point(4, 29);
            tpTransaction.Name = "tpTransaction";
            tpTransaction.Padding = new Padding(3);
            tpTransaction.Size = new Size(905, 409);
            tpTransaction.TabIndex = 0;
            tpTransaction.Text = "Giao Dịch";
            tpTransaction.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(dtpTransactionDate);
            groupBox2.Controls.Add(cbServiceName);
            groupBox2.Controls.Add(txbTransactionAmount);
            groupBox2.Controls.Add(txbTransactionDescription);
            groupBox2.Controls.Add(txbTransactionID);
            groupBox2.Location = new Point(457, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(442, 274);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin giao dịch";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 196);
            label9.Name = "label9";
            label9.Size = new Size(117, 20);
            label9.TabIndex = 26;
            label9.Text = "Mô tả giao dịch:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 111);
            label10.Name = "label10";
            label10.Size = new Size(113, 20);
            label10.TabIndex = 25;
            label10.Text = "Ngày giao dịch:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 67);
            label11.Name = "label11";
            label11.Size = new Size(86, 20);
            label11.TabIndex = 24;
            label11.Text = "Tên dịch vụ:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 160);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 23;
            label12.Text = "Số tiền:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 29);
            label13.Name = "label13";
            label13.Size = new Size(93, 20);
            label13.TabIndex = 16;
            label13.Text = "ID giao dịch:";
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
            txbTransactionDescription.Location = new Point(155, 196);
            txbTransactionDescription.Name = "txbTransactionDescription";
            txbTransactionDescription.Size = new Size(259, 27);
            txbTransactionDescription.TabIndex = 20;
            // 
            // txbTransactionID
            // 
            txbTransactionID.Location = new Point(157, 26);
            txbTransactionID.Name = "txbTransactionID";
            txbTransactionID.ReadOnly = true;
            txbTransactionID.Size = new Size(259, 27);
            txbTransactionID.TabIndex = 16;
            // 
            // panel10
            // 
            panel10.Location = new Point(454, 351);
            panel10.Name = "panel10";
            panel10.Size = new Size(445, 52);
            panel10.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnSreachTransaction);
            panel6.Controls.Add(txbSreachTransaction);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(454, 15);
            panel6.Name = "panel6";
            panel6.Size = new Size(443, 35);
            panel6.TabIndex = 7;
            // 
            // btnSreachTransaction
            // 
            btnSreachTransaction.Location = new Point(346, 3);
            btnSreachTransaction.Name = "btnSreachTransaction";
            btnSreachTransaction.Size = new Size(94, 29);
            btnSreachTransaction.TabIndex = 3;
            btnSreachTransaction.Text = "Tìm kiếm";
            btnSreachTransaction.UseVisualStyleBackColor = true;
            btnSreachTransaction.Click += btnSreachTransaction_Click;
            // 
            // txbSreachTransaction
            // 
            txbSreachTransaction.Location = new Point(11, 4);
            txbSreachTransaction.Name = "txbSreachTransaction";
            txbSreachTransaction.Size = new Size(329, 27);
            txbSreachTransaction.TabIndex = 1;
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
            panel7.Controls.Add(btnExport);
            panel7.Controls.Add(btnCheckAccount);
            panel7.Location = new Point(5, 15);
            panel7.Name = "panel7";
            panel7.Size = new Size(443, 35);
            panel7.TabIndex = 6;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(266, 2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(94, 29);
            btnExport.TabIndex = 5;
            btnExport.Text = "Xuất file";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnCheckAccount
            // 
            btnCheckAccount.Location = new Point(32, 3);
            btnCheckAccount.Name = "btnCheckAccount";
            btnCheckAccount.Size = new Size(203, 29);
            btnCheckAccount.TabIndex = 0;
            btnCheckAccount.Text = "Kiểm tra tài khoản";
            btnCheckAccount.UseVisualStyleBackColor = true;
            btnCheckAccount.Click += btnCheckAccount_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(dtgvTransactionHistory);
            panel9.Location = new Point(8, 56);
            panel9.Name = "panel9";
            panel9.Size = new Size(440, 338);
            panel9.TabIndex = 4;
            // 
            // dtgvTransactionHistory
            // 
            dtgvTransactionHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTransactionHistory.Location = new Point(7, 5);
            dtgvTransactionHistory.Name = "dtgvTransactionHistory";
            dtgvTransactionHistory.RowHeadersWidth = 51;
            dtgvTransactionHistory.Size = new Size(430, 342);
            dtgvTransactionHistory.TabIndex = 0;
            dtgvTransactionHistory.CellClick += DtgvTransactionHistory_CellClick;
            // 
            // tpService
            // 
            tpService.Controls.Add(panel5);
            tpService.Controls.Add(panel4);
            tpService.Controls.Add(panel3);
            tpService.Controls.Add(panel2);
            tpService.Location = new Point(4, 29);
            tpService.Name = "tpService";
            tpService.Padding = new Padding(3);
            tpService.Size = new Size(905, 409);
            tpService.TabIndex = 1;
            tpService.Text = "Dịch vụ";
            tpService.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnSreachService);
            panel5.Controls.Add(txbSreachService);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(453, 11);
            panel5.Name = "panel5";
            panel5.Size = new Size(443, 35);
            panel5.TabIndex = 3;
            // 
            // btnSreachService
            // 
            btnSreachService.Location = new Point(346, 3);
            btnSreachService.Name = "btnSreachService";
            btnSreachService.Size = new Size(94, 29);
            btnSreachService.TabIndex = 2;
            btnSreachService.Text = "Tìm kiếm";
            btnSreachService.UseVisualStyleBackColor = true;
            btnSreachService.Click += btnSreachService_Click;
            // 
            // txbSreachService
            // 
            txbSreachService.Location = new Point(11, 4);
            txbSreachService.Name = "txbSreachService";
            txbSreachService.Size = new Size(329, 27);
            txbSreachService.TabIndex = 1;
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
            panel4.Controls.Add(btnDeleteService);
            panel4.Controls.Add(btnEditService);
            panel4.Controls.Add(btnAddService);
            panel4.Location = new Point(4, 11);
            panel4.Name = "panel4";
            panel4.Size = new Size(443, 35);
            panel4.TabIndex = 2;
            // 
            // btnDeleteService
            // 
            btnDeleteService.Location = new Point(210, 0);
            btnDeleteService.Name = "btnDeleteService";
            btnDeleteService.Size = new Size(94, 29);
            btnDeleteService.TabIndex = 3;
            btnDeleteService.Text = "Xóa";
            btnDeleteService.UseVisualStyleBackColor = true;
            btnDeleteService.Click += btnDeleteService_Click;
            // 
            // btnEditService
            // 
            btnEditService.Location = new Point(110, 0);
            btnEditService.Name = "btnEditService";
            btnEditService.Size = new Size(94, 29);
            btnEditService.TabIndex = 2;
            btnEditService.Text = "Sửa";
            btnEditService.UseVisualStyleBackColor = true;
            btnEditService.Click += btnEditService_Click;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(10, 0);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(94, 29);
            btnAddService.TabIndex = 0;
            btnAddService.Text = "Thêm";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txbServiceName);
            panel3.Controls.Add(txbServiceStatus);
            panel3.Controls.Add(txbServiceDescription);
            panel3.Controls.Add(txbServicePrice);
            panel3.Controls.Add(txbServiceID);
            panel3.Location = new Point(453, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(446, 289);
            panel3.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 244);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 9;
            label6.Text = "Tình trạng dịch vụ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 192);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 8;
            label5.Text = "Mô tả dịch vụ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 137);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 7;
            label4.Text = "Phí dịch vụ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 78);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 6;
            label3.Text = "Tên dịch vụ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 28);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 5;
            label2.Text = "ID dịch vụ:";
            // 
            // txbServiceName
            // 
            txbServiceName.Location = new Point(169, 71);
            txbServiceName.Name = "txbServiceName";
            txbServiceName.Size = new Size(259, 27);
            txbServiceName.TabIndex = 4;
            // 
            // txbServiceStatus
            // 
            txbServiceStatus.Location = new Point(169, 237);
            txbServiceStatus.Name = "txbServiceStatus";
            txbServiceStatus.Size = new Size(259, 27);
            txbServiceStatus.TabIndex = 3;
            // 
            // txbServiceDescription
            // 
            txbServiceDescription.Location = new Point(169, 185);
            txbServiceDescription.Name = "txbServiceDescription";
            txbServiceDescription.Size = new Size(259, 27);
            txbServiceDescription.TabIndex = 2;
            // 
            // txbServicePrice
            // 
            txbServicePrice.Location = new Point(169, 130);
            txbServicePrice.Name = "txbServicePrice";
            txbServicePrice.Size = new Size(259, 27);
            txbServicePrice.TabIndex = 1;
            // 
            // txbServiceID
            // 
            txbServiceID.Location = new Point(169, 21);
            txbServiceID.Name = "txbServiceID";
            txbServiceID.ReadOnly = true;
            txbServiceID.Size = new Size(259, 27);
            txbServiceID.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvService);
            panel2.Location = new Point(7, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 338);
            panel2.TabIndex = 0;
            // 
            // dtgvService
            // 
            dtgvService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvService.Location = new Point(7, 5);
            dtgvService.Name = "dtgvService";
            dtgvService.RowHeadersWidth = 51;
            dtgvService.Size = new Size(430, 330);
            dtgvService.TabIndex = 0;
            // 
            // ManagerTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 455);
            Controls.Add(tcManagerAccount);
            Name = "ManagerTransaction";
            Text = "ManagerTransaction";
            tcManagerAccount.ResumeLayout(false);
            tpTransaction.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTransactionHistory).EndInit();
            tpService.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvService).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcManagerAccount;
        private TabPage tpTransaction;
        private Panel panel10;
        private Panel panel6;
        private Button btnSreachTransaction;
        private TextBox txbSreachTransaction;
        private Label label7;
        private Panel panel7;
        private Button btnDeleteTransaction;
        private Button btnEditTransaction;
        private Button btnCheckAccount;
        private Panel panel9;
        private DataGridView dtgvTransactionHistory;
        private TabPage tpService;
        private Panel panel5;
        private Button btnSreachService;
        private TextBox txbSreachService;
        private Label label1;
        private Panel panel4;
        private Button btnDeleteService;
        private Button btnEditService;
        private Button btnAddService;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txbServiceName;
        private TextBox txbServiceStatus;
        private TextBox txbServiceDescription;
        private TextBox txbServicePrice;
        private TextBox txbServiceID;
        private Panel panel2;
        private DataGridView dtgvService;
        private GroupBox groupBox2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private DateTimePicker dtpTransactionDate;
        private ComboBox cbServiceName;
        private TextBox txbTransactionAmount;
        private TextBox txbTransactionDescription;
        private TextBox txbTransactionID;
        private Button btnExport;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}