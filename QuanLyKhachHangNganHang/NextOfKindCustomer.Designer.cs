namespace QuanLyKhachHangNganHang
{
    partial class NextOfKindCustomer
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
            dtgvNextOfKin = new DataGridView();
            panel6 = new Panel();
            btnSreach = new Button();
            txbSreach = new TextBox();
            label7 = new Label();
            panel3 = new Panel();
            txbCustomerName = new TextBox();
            label8 = new Label();
            txbNextOfKindAddress = new TextBox();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txbNextOfKinName = new TextBox();
            txbNextOfKindSDT = new TextBox();
            txbRelationship = new TextBox();
            txbCustomerID = new TextBox();
            txbNextofKinID = new TextBox();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvNextOfKin).BeginInit();
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
            panel1.Location = new Point(4, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 392);
            panel1.TabIndex = 0;
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
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(dtgvNextOfKin);
            panel9.Location = new Point(4, 55);
            panel9.Name = "panel9";
            panel9.Size = new Size(330, 329);
            panel9.TabIndex = 10;
            // 
            // dtgvNextOfKin
            // 
            dtgvNextOfKin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvNextOfKin.Location = new Point(4, 3);
            dtgvNextOfKin.Name = "dtgvNextOfKin";
            dtgvNextOfKin.RowHeadersWidth = 51;
            dtgvNextOfKin.Size = new Size(323, 319);
            dtgvNextOfKin.TabIndex = 0;
            dtgvNextOfKin.CellContentClick += dtgvNextOfKin_CellContentClick;
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
            panel3.Controls.Add(txbCustomerName);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txbNextOfKindAddress);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txbNextOfKinName);
            panel3.Controls.Add(txbNextOfKindSDT);
            panel3.Controls.Add(txbRelationship);
            panel3.Controls.Add(txbCustomerID);
            panel3.Controls.Add(txbNextofKinID);
            panel3.Location = new Point(340, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(444, 319);
            panel3.TabIndex = 4;
            // 
            // txbCustomerName
            // 
            txbCustomerName.Location = new Point(196, 132);
            txbCustomerName.Name = "txbCustomerName";
            txbCustomerName.ReadOnly = true;
            txbCustomerName.Size = new Size(251, 27);
            txbCustomerName.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 135);
            label8.Name = "label8";
            label8.Size = new Size(119, 20);
            label8.TabIndex = 12;
            label8.Text = "Tên Khách Hàng:";
            // 
            // txbNextOfKindAddress
            // 
            txbNextOfKindAddress.Location = new Point(193, 270);
            txbNextOfKindAddress.Name = "txbNextOfKindAddress";
            txbNextOfKindAddress.Size = new Size(248, 27);
            txbNextOfKindAddress.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 277);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 10;
            label1.Text = "Địa chỉ người thân:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 224);
            label6.Name = "label6";
            label6.Size = new Size(176, 20);
            label6.TabIndex = 9;
            label6.Text = "Số điện thoại người thân:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 177);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 8;
            label5.Text = "Mối Quan hệ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 93);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 7;
            label4.Text = "ID Khách Hàng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 54);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 6;
            label3.Text = "Tên Người thân:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 11);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 5;
            label2.Text = "ID Người thân:";
            // 
            // txbNextOfKinName
            // 
            txbNextOfKinName.Location = new Point(196, 51);
            txbNextOfKinName.Name = "txbNextOfKinName";
            txbNextOfKinName.Size = new Size(248, 27);
            txbNextOfKinName.TabIndex = 4;
            // 
            // txbNextOfKindSDT
            // 
            txbNextOfKindSDT.Location = new Point(193, 224);
            txbNextOfKindSDT.Name = "txbNextOfKindSDT";
            txbNextOfKindSDT.Size = new Size(248, 27);
            txbNextOfKindSDT.TabIndex = 3;
            // 
            // txbRelationship
            // 
            txbRelationship.Location = new Point(196, 177);
            txbRelationship.Name = "txbRelationship";
            txbRelationship.Size = new Size(248, 27);
            txbRelationship.TabIndex = 2;
            // 
            // txbCustomerID
            // 
            txbCustomerID.Location = new Point(196, 93);
            txbCustomerID.Name = "txbCustomerID";
            txbCustomerID.ReadOnly = true;
            txbCustomerID.Size = new Size(251, 27);
            txbCustomerID.TabIndex = 1;
            // 
            // txbNextofKinID
            // 
            txbNextofKinID.Location = new Point(193, 11);
            txbNextofKinID.Name = "txbNextofKinID";
            txbNextofKinID.ReadOnly = true;
            txbNextofKinID.Size = new Size(248, 27);
            txbNextofKinID.TabIndex = 0;
            // 
            // NextOfKindCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 396);
            Controls.Add(panel1);
            Name = "NextOfKindCustomer";
            Text = "NextOfKindCustomer";
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvNextOfKin).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox txbNextOfKindAddress;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txbNextOfKinName;
        private TextBox txbNextOfKindSDT;
        private TextBox txbRelationship;
        private TextBox txbCustomerID;
        private TextBox txbNextofKinID;
        private Panel panel6;
        private Button btnSreach;
        private TextBox txbSreach;
        private Label label7;
        private Panel panel9;
        private DataGridView dtgvNextOfKin;
        private Panel panel7;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox txbCustomerName;
        private Label label8;
    }
}