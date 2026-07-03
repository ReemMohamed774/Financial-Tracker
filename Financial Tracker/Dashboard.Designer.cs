namespace Financial_Tracker
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            panel7 = new Panel();
            btn_Logout = new Button();
            pictureBox5 = new PictureBox();
            panel6 = new Panel();
            btn_Setting = new Button();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            btn_Expenses = new Button();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            btn_Dashboard = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            welcome_label = new Label();
            panel3 = new Panel();
            dgvTransactions = new DataGridView();
            label7 = new Label();
            panel11 = new Panel();
            lbl_BalanceValue = new Label();
            pictureBox9 = new PictureBox();
            lbltotalExpenses = new Label();
            panel10 = new Panel();
            lbl_IncomeValue = new Label();
            pictureBox8 = new PictureBox();
            lblTotalIncome = new Label();
            panel9 = new Panel();
            lbl_ExpenseValue = new Label();
            pictureBox7 = new PictureBox();
            lblTotalBalance = new Label();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 35, 55);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 780);
            panel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel7.BackColor = Color.FromArgb(35, 45, 63);
            panel7.Controls.Add(btn_Logout);
            panel7.Controls.Add(pictureBox5);
            panel7.Location = new Point(0, 715);
            panel7.Name = "panel7";
            panel7.Size = new Size(150, 45);
            panel7.TabIndex = 6;
            // 
            // btn_Logout
            // 
            btn_Logout.BackColor = Color.FromArgb(35, 45, 63);
            btn_Logout.FlatAppearance.BorderSize = 0;
            btn_Logout.FlatStyle = FlatStyle.Flat;
            btn_Logout.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Logout.ForeColor = Color.White;
            btn_Logout.Location = new Point(47, 0);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(103, 45);
            btn_Logout.TabIndex = 7;
            btn_Logout.Text = "Log out";
            btn_Logout.TextAlign = ContentAlignment.MiddleLeft;
            btn_Logout.UseVisualStyleBackColor = false;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.logout;
            pictureBox5.Location = new Point(3, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(35, 45, 63);
            panel6.Controls.Add(btn_Setting);
            panel6.Controls.Add(pictureBox4);
            panel6.Location = new Point(0, 351);
            panel6.Name = "panel6";
            panel6.Size = new Size(219, 60);
            panel6.TabIndex = 5;
            // 
            // btn_Setting
            // 
            btn_Setting.BackColor = Color.FromArgb(35, 45, 63);
            btn_Setting.FlatAppearance.BorderSize = 0;
            btn_Setting.FlatStyle = FlatStyle.Flat;
            btn_Setting.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Setting.ForeColor = Color.White;
            btn_Setting.Location = new Point(65, 3);
            btn_Setting.Name = "btn_Setting";
            btn_Setting.Size = new Size(151, 55);
            btn_Setting.TabIndex = 6;
            btn_Setting.Text = "Settings";
            btn_Setting.TextAlign = ContentAlignment.MiddleLeft;
            btn_Setting.UseVisualStyleBackColor = false;
            btn_Setting.Click += btn_Settings_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.cogwheel;
            pictureBox4.Location = new Point(3, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(62, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += btn_Settings_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(35, 45, 63);
            panel5.Controls.Add(btn_Expenses);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(0, 264);
            panel5.Name = "panel5";
            panel5.Size = new Size(219, 60);
            panel5.TabIndex = 4;
            // 
            // btn_Expenses
            // 
            btn_Expenses.BackColor = Color.FromArgb(35, 45, 63);
            btn_Expenses.FlatAppearance.BorderSize = 0;
            btn_Expenses.FlatStyle = FlatStyle.Flat;
            btn_Expenses.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Expenses.ForeColor = Color.White;
            btn_Expenses.Location = new Point(65, 4);
            btn_Expenses.Name = "btn_Expenses";
            btn_Expenses.Size = new Size(151, 55);
            btn_Expenses.TabIndex = 6;
            btn_Expenses.Text = "Expenses";
            btn_Expenses.TextAlign = ContentAlignment.MiddleLeft;
            btn_Expenses.UseVisualStyleBackColor = false;
            btn_Expenses.Click += btn_Expenses_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.budget;
            pictureBox3.Location = new Point(3, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += btn_Expenses_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 45, 63);
            panel4.Controls.Add(btn_Dashboard);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(0, 171);
            panel4.Name = "panel4";
            panel4.Size = new Size(219, 60);
            panel4.TabIndex = 3;
            // 
            // btn_Dashboard
            // 
            btn_Dashboard.BackColor = Color.FromArgb(35, 45, 63);
            btn_Dashboard.FlatAppearance.BorderSize = 0;
            btn_Dashboard.FlatStyle = FlatStyle.Flat;
            btn_Dashboard.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Dashboard.ForeColor = Color.White;
            btn_Dashboard.Location = new Point(63, 3);
            btn_Dashboard.Name = "btn_Dashboard";
            btn_Dashboard.Size = new Size(151, 55);
            btn_Dashboard.TabIndex = 3;
            btn_Dashboard.Text = "Dashboard";
            btn_Dashboard.TextAlign = ContentAlignment.MiddleLeft;
            btn_Dashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dashboard__1_;
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dashboard;
            pictureBox1.Location = new Point(18, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 45, 65);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(welcome_label);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(219, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1553, 125);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(62, 83);
            label3.Name = "label3";
            label3.Size = new Size(224, 22);
            label3.TabIndex = 1;
            label3.Text = "Enjoy managing your finances";
            // 
            // welcome_label
            // 
            welcome_label.AutoSize = true;
            welcome_label.Font = new Font("Impact", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcome_label.ForeColor = Color.White;
            welcome_label.Location = new Point(35, 12);
            welcome_label.Name = "welcome_label";
            welcome_label.Size = new Size(308, 54);
            welcome_label.TabIndex = 0;
            welcome_label.Text = "Welcome back,";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvTransactions);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(panel10);
            panel3.Controls.Add(panel9);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(219, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(1553, 655);
            panel3.TabIndex = 2;
            // 
            // dgvTransactions
            // 
            dgvTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(62, 197);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 51;
            dgvTransactions.Size = new Size(1453, 436);
            dgvTransactions.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.AppWorkspace;
            label7.Location = new Point(44, 148);
            label7.Name = "label7";
            label7.Size = new Size(164, 28);
            label7.TabIndex = 6;
            label7.Text = "TRANSACTIONS";
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel11.BackColor = Color.FromArgb(35, 45, 63);
            panel11.Controls.Add(lbl_ExpenseValue);
            panel11.Controls.Add(pictureBox9);
            panel11.Controls.Add(lbltotalExpenses);
            panel11.Cursor = Cursors.Hand;
            panel11.Location = new Point(1200, 29);
            panel11.Name = "panel11";
            panel11.Size = new Size(315, 99);
            panel11.TabIndex = 2;
            // 
            // lbl_BalanceValue
            // 
            lbl_BalanceValue.AutoSize = true;
            lbl_BalanceValue.Font = new Font("Impact", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_BalanceValue.ForeColor = Color.White;
            lbl_BalanceValue.Location = new Point(84, 41);
            lbl_BalanceValue.Name = "lbl_BalanceValue";
            lbl_BalanceValue.Size = new Size(31, 35);
            lbl_BalanceValue.TabIndex = 4;
            lbl_BalanceValue.Text = "0";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.spending;
            pictureBox9.Location = new Point(17, 15);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(64, 64);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 1;
            pictureBox9.TabStop = false;
            // 
            // lbltotalExpenses
            // 
            lbltotalExpenses.AutoSize = true;
            lbltotalExpenses.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotalExpenses.ForeColor = SystemColors.AppWorkspace;
            lbltotalExpenses.Location = new Point(85, 15);
            lbltotalExpenses.Name = "lbltotalExpenses";
            lbltotalExpenses.Size = new Size(174, 28);
            lbltotalExpenses.TabIndex = 0;
            lbltotalExpenses.Text = "TOTAL EXPENSES";
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top;
            panel10.BackColor = Color.FromArgb(35, 45, 63);
            panel10.Controls.Add(lbl_IncomeValue);
            panel10.Controls.Add(pictureBox8);
            panel10.Controls.Add(lblTotalIncome);
            panel10.Cursor = Cursors.Hand;
            panel10.Location = new Point(622, 29);
            panel10.Name = "panel10";
            panel10.Size = new Size(315, 99);
            panel10.TabIndex = 2;
            // 
            // lbl_IncomeValue
            // 
            lbl_IncomeValue.AutoSize = true;
            lbl_IncomeValue.Font = new Font("Impact", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_IncomeValue.ForeColor = Color.White;
            lbl_IncomeValue.Location = new Point(84, 41);
            lbl_IncomeValue.Name = "lbl_IncomeValue";
            lbl_IncomeValue.Size = new Size(31, 35);
            lbl_IncomeValue.TabIndex = 2;
            lbl_IncomeValue.Text = "0";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.salary;
            pictureBox8.Location = new Point(17, 15);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(64, 64);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 1;
            pictureBox8.TabStop = false;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalIncome.ForeColor = SystemColors.AppWorkspace;
            lblTotalIncome.Location = new Point(85, 15);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(157, 28);
            lblTotalIncome.TabIndex = 0;
            lblTotalIncome.Text = "TOTAL INCOME";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(35, 45, 63);
            panel9.Controls.Add(pictureBox7);
            panel9.Controls.Add(lbl_BalanceValue);
            panel9.Controls.Add(lblTotalBalance);
            panel9.Cursor = Cursors.Hand;
            panel9.Location = new Point(45, 29);
            panel9.Name = "panel9";
            panel9.Size = new Size(315, 99);
            panel9.TabIndex = 0;
            // 
            // lbl_ExpenseValue
            // 
            lbl_ExpenseValue.AutoSize = true;
            lbl_ExpenseValue.Font = new Font("Impact", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ExpenseValue.ForeColor = Color.White;
            lbl_ExpenseValue.Location = new Point(84, 41);
            lbl_ExpenseValue.Name = "lbl_ExpenseValue";
            lbl_ExpenseValue.Size = new Size(31, 35);
            lbl_ExpenseValue.TabIndex = 3;
            lbl_ExpenseValue.Text = "0";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(17, 15);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(64, 64);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // lblTotalBalance
            // 
            lblTotalBalance.AutoSize = true;
            lblTotalBalance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBalance.ForeColor = SystemColors.AppWorkspace;
            lblTotalBalance.Location = new Point(85, 15);
            lblTotalBalance.Name = "lblTotalBalance";
            lblTotalBalance.Size = new Size(168, 28);
            lblTotalBalance.TabIndex = 0;
            lblTotalBalance.Text = "TOTAL BALANCE";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 15, 30);
            ClientSize = new Size(1772, 780);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            Text = "Dashboard";
            Activated += Show_Reports_Page_Activated;
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel9;
        private PictureBox pictureBox7;
        private Label lblTotalBalance;
        private Panel panel11;
        private PictureBox pictureBox9;
        private Label lbltotalExpenses;
        private Panel panel10;
        private PictureBox pictureBox8;
        private Label lblTotalIncome;
        private Label welcome_label;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private Panel panel7;
        private PictureBox pictureBox2;
        private Label lbl_BalanceValue;
        private Label label6;
        private PictureBox pictureBox4;
        private Label label5;
        private PictureBox pictureBox3;
        private Button btn_Dashboard;
        private Button btn_Setting;
        private Button btn_Expenses;
        private Button btn_Logout;
        private PictureBox pictureBox5;
        private Label label7;
        private DataGridView dgvTransactions;
        private Label lbl_ExpenseValue;
        private Label lbl_IncomeValue;
    }
}