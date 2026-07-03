namespace Financial_Tracker
{
    partial class AddExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExpenses));
            button4 = new Button();
            pictureBox5 = new PictureBox();
            panel1 = new Panel();
            btnSaveChanges = new Button();
            btnDiscardProfile = new Button();
            label5 = new Label();
            txtDescription = new TextBox();
            cmbCategory = new ComboBox();
            label3 = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            txtAmount = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(35, 45, 63);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(47, 0);
            button4.Name = "button4";
            button4.Size = new Size(103, 45);
            button4.TabIndex = 7;
            button4.Text = "Log out";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.logout;
            pictureBox5.Location = new Point(3, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 42);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(35, 45, 63);
            panel1.Controls.Add(btnSaveChanges);
            panel1.Controls.Add(btnDiscardProfile);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(cmbCategory);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 599);
            panel1.TabIndex = 7;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Anchor = AnchorStyles.Top;
            btnSaveChanges.BackColor = Color.FromArgb(35, 45, 63);
            btnSaveChanges.BackgroundImage = Properties.Resources.check;
            btnSaveChanges.BackgroundImageLayout = ImageLayout.Stretch;
            btnSaveChanges.FlatAppearance.BorderSize = 0;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(185, 515);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(64, 64);
            btnSaveChanges.TabIndex = 12;
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnDiscardProfile
            // 
            btnDiscardProfile.Anchor = AnchorStyles.Top;
            btnDiscardProfile.BackColor = Color.FromArgb(35, 45, 63);
            btnDiscardProfile.BackgroundImage = Properties.Resources.no;
            btnDiscardProfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnDiscardProfile.FlatAppearance.BorderSize = 0;
            btnDiscardProfile.FlatStyle = FlatStyle.Flat;
            btnDiscardProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiscardProfile.ForeColor = Color.White;
            btnDiscardProfile.Location = new Point(297, 515);
            btnDiscardProfile.Name = "btnDiscardProfile";
            btnDiscardProfile.Size = new Size(64, 64);
            btnDiscardProfile.TabIndex = 13;
            btnDiscardProfile.UseVisualStyleBackColor = false;
            btnDiscardProfile.Click += btnDiscardProfile_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(8, 368);
            label5.Name = "label5";
            label5.Size = new Size(105, 25);
            label5.TabIndex = 8;
            label5.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top;
            txtDescription.Location = new Point(116, 368);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(364, 133);
            txtDescription.TabIndex = 7;
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.Top;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Rent / Mortgage", "Utilities", "Groceries", "Transportation", "Dining Out", "Entertainment", "Subscriptions", "Healthcare", "Insurance", "Debt Payments", "Education", "Shopping / Retail", "Travel", "Personal Care", "Household Supplies", "Other" });
            cmbCategory.Location = new Point(116, 293);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(364, 28);
            cmbCategory.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 296);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 5;
            label3.Text = "Category";
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Top;
            dtpDate.Location = new Point(116, 222);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(364, 27);
            dtpDate.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(61, 224);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 3;
            label2.Text = "Date";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 158);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 2;
            label1.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Top;
            txtAmount.Location = new Point(116, 156);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(364, 27);
            txtAmount.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.expense__1_;
            pictureBox1.Location = new Point(218, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AddExpenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 15, 30);
            ClientSize = new Size(531, 601);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddExpenses";
            Text = "AddExpenses";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button4;
        private PictureBox pictureBox5;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox txtAmount;
        private ComboBox cmbCategory;
        private Label label3;
        private DateTimePicker dtpDate;
        private Label label5;
        private TextBox txtDescription;
        private Button btnSaveChanges;
        private Button btnDiscardProfile;
    }
}