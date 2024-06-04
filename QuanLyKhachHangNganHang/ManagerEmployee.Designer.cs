namespace QuanLyKhachHangNganHang
{
    partial class ManagerEmployee
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
            panel7 = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            panel9 = new Panel();
            dtgvEmployee = new DataGridView();
            panel6 = new Panel();
            btnSreach = new Button();
            txbSreach = new TextBox();
            label7 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txbEmployeeName = new TextBox();
            txbPosition = new TextBox();
            txbPassWord = new TextBox();
            txbDisplayName = new TextBox();
            txbEmployeeID = new TextBox();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvEmployee).BeginInit();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 392);
            panel1.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnDelete);
            panel7.Controls.Add(btnEdit);
            panel7.Controls.Add(btnAdd);
            panel7.Location = new Point(5, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(329, 35);
            panel7.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(232, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(115, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // panel9
            // 
            panel9.Controls.Add(dtgvEmployee);
            panel9.Location = new Point(4, 55);
            panel9.Name = "panel9";
            panel9.Size = new Size(330, 329);
            panel9.TabIndex = 10;
            // 
            // dtgvEmployee
            // 
            dtgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvEmployee.Location = new Point(4, 3);
            dtgvEmployee.Name = "dtgvEmployee";
            dtgvEmployee.RowHeadersWidth = 51;
            dtgvEmployee.Size = new Size(323, 319);
            dtgvEmployee.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnSreach);
            panel6.Controls.Add(txbSreach);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(338, 15);
            panel6.Name = "panel6";
            panel6.Size = new Size(446, 35);
            panel6.TabIndex = 9;
            // 
            // btnSreach
            // 
            btnSreach.Location = new Point(335, 3);
            btnSreach.Name = "btnSreach";
            btnSreach.Size = new Size(104, 29);
            btnSreach.TabIndex = 3;
            btnSreach.Text = "Tìm kiếm";
            btnSreach.UseVisualStyleBackColor = true;
            btnSreach.Click += btnSreach_Click;
            // 
            // txbSreach
            // 
            txbSreach.Location = new Point(9, 4);
            txbSreach.Name = "txbSreach";
            txbSreach.Size = new Size(320, 27);
            txbSreach.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(356, 7);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txbEmployeeName);
            panel3.Controls.Add(txbPosition);
            panel3.Controls.Add(txbPassWord);
            panel3.Controls.Add(txbDisplayName);
            panel3.Controls.Add(txbEmployeeID);
            panel3.Location = new Point(340, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(444, 319);
            panel3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 284);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 244);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 9;
            label6.Text = "Vị Trí:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 192);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 8;
            label5.Text = "Mật Khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 137);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 7;
            label4.Text = "Tên Hiển Thị:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 78);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 6;
            label3.Text = "Tên Đăng Nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 28);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 5;
            label2.Text = "ID Nhân Viên:";
            // 
            // txbEmployeeName
            // 
            txbEmployeeName.Location = new Point(132, 75);
            txbEmployeeName.Name = "txbEmployeeName";
            txbEmployeeName.Size = new Size(309, 27);
            txbEmployeeName.TabIndex = 4;
            // 
            // txbPosition
            // 
            txbPosition.Location = new Point(132, 237);
            txbPosition.Name = "txbPosition";
            txbPosition.Size = new Size(309, 27);
            txbPosition.TabIndex = 3;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(132, 192);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(309, 27);
            txbPassWord.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(132, 130);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(312, 27);
            txbDisplayName.TabIndex = 1;
            // 
            // txbEmployeeID
            // 
            txbEmployeeID.Location = new Point(132, 25);
            txbEmployeeID.Name = "txbEmployeeID";
            txbEmployeeID.ReadOnly = true;
            txbEmployeeID.Size = new Size(309, 27);
            txbEmployeeID.TabIndex = 0;
            // 
            // ManagerEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 413);
            Controls.Add(panel1);
            Name = "ManagerEmployee";
            Text = "ManagerEmployee";
            Load += ManagerEmployee_Load;
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvEmployee).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel7;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Panel panel9;
        private DataGridView dtgvEmployee;
        private Panel panel6;
        private Button btnSreach;
        private TextBox txbSreach;
        private Label label7;
        private Panel panel3;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txbEmployeeName;
        private TextBox txbPosition;
        private TextBox txbPassWord;
        private TextBox txbDisplayName;
        private TextBox txbEmployeeID;
    }
}