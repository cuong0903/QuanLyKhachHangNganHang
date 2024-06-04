namespace QuanLyKhachHangNganHang
{
    partial class HomePage
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
            dtgvHomePage = new DataGridView();
            panel2 = new Panel();
            btnSearch = new Button();
            txSearch = new TextBox();
            btnExit = new Button();
            menuStrip1 = new MenuStrip();
            tổngQuanToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            quảnLýTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            quảnLýKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýGiaoDịchToolStripMenuItem = new ToolStripMenuItem();
            quảnLýNhânViênToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvHomePage).BeginInit();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 449);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvHomePage);
            panel3.Location = new Point(1, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(935, 368);
            panel3.TabIndex = 1;
            // 
            // dtgvHomePage
            // 
            dtgvHomePage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvHomePage.Location = new Point(5, 6);
            dtgvHomePage.Name = "dtgvHomePage";
            dtgvHomePage.RowHeadersWidth = 51;
            dtgvHomePage.Size = new Size(924, 359);
            dtgvHomePage.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txSearch);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(0, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1014, 47);
            panel2.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(581, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txSearch
            // 
            txSearch.Location = new Point(302, 17);
            txSearch.Name = "txSearch";
            txSearch.Size = new Size(273, 27);
            txSearch.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(827, 24);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 1;
            btnExit.Text = "Đăng Xuất";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(0, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tổngQuanToolStripMenuItem, quảnLýToolStripMenuItem, thốngKêToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1014, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tổngQuanToolStripMenuItem
            // 
            tổngQuanToolStripMenuItem.Name = "tổngQuanToolStripMenuItem";
            tổngQuanToolStripMenuItem.Size = new Size(94, 24);
            tổngQuanToolStripMenuItem.Text = "Tổng quan";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýTàiKhoảnToolStripMenuItem, quảnLýKháchHàngToolStripMenuItem, quảnLýGiaoDịchToolStripMenuItem, quảnLýNhânViênToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(75, 24);
            quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            quảnLýTàiKhoảnToolStripMenuItem.Size = new Size(226, 26);
            quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý Tài Khoản";
            quảnLýTàiKhoảnToolStripMenuItem.Click += quảnLýTàiKhoảnToolStripMenuItem_Click;
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            quảnLýKháchHàngToolStripMenuItem.Size = new Size(226, 26);
            quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý Khách Hàng";
            quảnLýKháchHàngToolStripMenuItem.Click += quảnLýKháchHàngToolStripMenuItem_Click;
            // 
            // quảnLýGiaoDịchToolStripMenuItem
            // 
            quảnLýGiaoDịchToolStripMenuItem.Name = "quảnLýGiaoDịchToolStripMenuItem";
            quảnLýGiaoDịchToolStripMenuItem.Size = new Size(226, 26);
            quảnLýGiaoDịchToolStripMenuItem.Text = "Quản Lý Giao Dịch";
            quảnLýGiaoDịchToolStripMenuItem.Click += quảnLýGiaoDịchToolStripMenuItem_Click;
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            quảnLýNhânViênToolStripMenuItem.Size = new Size(226, 26);
            quảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            quảnLýNhânViênToolStripMenuItem.Click += quảnLýNhânViênToolStripMenuItem_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(86, 24);
            thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 432);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "HomePage";
            Text = "Trang Chủ";
            FormClosing += Login_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvHomePage).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Button btnExit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tổngQuanToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private ToolStripMenuItem quảnLýGiaoDịchToolStripMenuItem;
        private ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private GroupBox groupBox1;
        private TextBox txSearchCustomerName;
        private TextBox txSearchTransactionID;
        private TextBox txSearchAccountNumber;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txSearch;
        private Button btnSearch;
        private DataGridView dtgvHomePage;
        private Label label1;
    }
}