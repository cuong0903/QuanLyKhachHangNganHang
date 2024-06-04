namespace QuanLyKhachHangNganHang
{
    partial class ManagerCustomer
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
            panel2 = new Panel();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            txbAccountOwnerName = new TextBox();
            txbAccounts = new TextBox();
            txbCustomerID = new TextBox();
            groupBox1 = new GroupBox();
            dtgvAccount = new DataGridView();
            panel9 = new Panel();
            dtgvCustomer = new DataGridView();
            panel6 = new Panel();
            btnSreachCustomer = new Button();
            txbSreachCustomer = new TextBox();
            label7 = new Label();
            panel7 = new Panel();
            btnAddAccount = new Button();
            btnNear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCustomer).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel7);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1306, 493);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txbAccountOwnerName);
            panel2.Controls.Add(txbAccounts);
            panel2.Controls.Add(txbCustomerID);
            panel2.Location = new Point(853, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 153);
            panel2.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 109);
            label14.Name = "label14";
            label14.Size = new Size(127, 20);
            label14.TabIndex = 17;
            label14.Text = "Tên chủ tài khoản:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 69);
            label13.Name = "label13";
            label13.Size = new Size(137, 20);
            label13.TabIndex = 16;
            label13.Text = "Số lượng tài khoản:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 24);
            label12.Name = "label12";
            label12.Size = new Size(106, 20);
            label12.TabIndex = 15;
            label12.Text = "ID khách hàng:";
            // 
            // txbAccountOwnerName
            // 
            txbAccountOwnerName.Location = new Point(172, 102);
            txbAccountOwnerName.Name = "txbAccountOwnerName";
            txbAccountOwnerName.ReadOnly = true;
            txbAccountOwnerName.Size = new Size(259, 27);
            txbAccountOwnerName.TabIndex = 14;
            // 
            // txbAccounts
            // 
            txbAccounts.Location = new Point(173, 69);
            txbAccounts.Name = "txbAccounts";
            txbAccounts.ReadOnly = true;
            txbAccounts.Size = new Size(259, 27);
            txbAccounts.TabIndex = 13;
            // 
            // txbCustomerID
            // 
            txbCustomerID.Location = new Point(172, 24);
            txbCustomerID.Name = "txbCustomerID";
            txbCustomerID.ReadOnly = true;
            txbCustomerID.Size = new Size(259, 27);
            txbCustomerID.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgvAccount);
            groupBox1.Location = new Point(855, 200);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(448, 293);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tài Khoản:";
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(1, 19);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 51;
            dtgvAccount.Size = new Size(441, 278);
            dtgvAccount.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(dtgvCustomer);
            panel9.Location = new Point(3, 41);
            panel9.Name = "panel9";
            panel9.Size = new Size(842, 449);
            panel9.TabIndex = 9;
            // 
            // dtgvCustomer
            // 
            dtgvCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCustomer.Location = new Point(7, 5);
            dtgvCustomer.Name = "dtgvCustomer";
            dtgvCustomer.RowHeadersWidth = 51;
            dtgvCustomer.Size = new Size(832, 441);
            dtgvCustomer.TabIndex = 0;
            dtgvCustomer.CellClick += dtgvCustomer_CellClick;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnSreachCustomer);
            panel6.Controls.Add(txbSreachCustomer);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(851, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(446, 35);
            panel6.TabIndex = 8;
            // 
            // btnSreachCustomer
            // 
            btnSreachCustomer.Location = new Point(335, 3);
            btnSreachCustomer.Name = "btnSreachCustomer";
            btnSreachCustomer.Size = new Size(104, 29);
            btnSreachCustomer.TabIndex = 3;
            btnSreachCustomer.Text = "Tìm kiếm";
            btnSreachCustomer.UseVisualStyleBackColor = true;
            btnSreachCustomer.Click += btnSreachCustomer_Click;
            // 
            // txbSreachCustomer
            // 
            txbSreachCustomer.Location = new Point(9, 4);
            txbSreachCustomer.Name = "txbSreachCustomer";
            txbSreachCustomer.Size = new Size(320, 27);
            txbSreachCustomer.TabIndex = 1;
            txbSreachCustomer.TextChanged += txbSreachAccount_TextChanged;
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
            panel7.Controls.Add(btnAddAccount);
            panel7.Controls.Add(btnNear);
            panel7.Controls.Add(btnDelete);
            panel7.Controls.Add(btnEdit);
            panel7.Controls.Add(btnAdd);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(842, 35);
            panel7.TabIndex = 7;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(517, 5);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(111, 29);
            btnAddAccount.TabIndex = 6;
            btnAddAccount.Text = "Tạo tài khoản";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click_1;
            // 
            // btnNear
            // 
            btnNear.Location = new Point(387, 5);
            btnNear.Name = "btnNear";
            btnNear.Size = new Size(111, 29);
            btnNear.TabIndex = 5;
            btnNear.Text = "Người Thân";
            btnNear.UseVisualStyleBackColor = true;
            btnNear.Click += btnNear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(265, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(134, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(0, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAddAccount_Click;
            // 
            // ManagerCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 495);
            Controls.Add(panel1);
            Name = "ManagerCustomer";
            Text = "Thông tin khách hàng";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCustomer).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel7;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Panel panel6;
        private Button btnSreachCustomer;
        private TextBox txbSreachCustomer;
        private Label label7;
        private Button btnNear;
        private Panel panel9;
        private DataGridView dtgvCustomer;
        private GroupBox groupBox1;
        private Panel panel2;
        private DataGridView dtgvAccount;
        private Label label14;
        private Label label13;
        private Label label12;
        private TextBox txbAccountOwnerName;
        private TextBox txbAccounts;
        private TextBox txbCustomerID;
        private Button btnAddAccount;
    }
}