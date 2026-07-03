namespace Financial_Tracker
{
    partial class Login_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            lblErrorLogIn = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblUserName = new Label();
            rbFemale = new RadioButton();
            txtUserName = new TextBox();
            rbMale = new RadioButton();
            btnLogIn = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblErrorLogIn
            // 
            lblErrorLogIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblErrorLogIn.AutoSize = true;
            lblErrorLogIn.ForeColor = Color.White;
            lblErrorLogIn.Location = new Point(489, 392);
            lblErrorLogIn.Name = "lblErrorLogIn";
            lblErrorLogIn.Size = new Size(0, 15);
            lblErrorLogIn.TabIndex = 8;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Gabriola", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(0, 0, 64);
            lblPassword.Location = new Point(36, 281);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 35);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top;
            txtPassword.BackColor = Color.FromArgb(35, 45, 65);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(152, 289);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(171, 23);
            txtPassword.TabIndex = 4;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Gabriola", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(0, 0, 64);
            lblUserName.Location = new Point(24, 233);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(99, 35);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name :";
            // 
            // rbFemale
            // 
            rbFemale.Anchor = AnchorStyles.Top;
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbFemale.ForeColor = Color.DimGray;
            rbFemale.Location = new Point(237, 342);
            rbFemale.Margin = new Padding(3, 2, 3, 2);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(77, 25);
            rbFemale.TabIndex = 6;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top;
            txtUserName.BackColor = Color.FromArgb(35, 45, 65);
            txtUserName.ForeColor = Color.White;
            txtUserName.Location = new Point(152, 241);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(171, 23);
            txtUserName.TabIndex = 3;
            // 
            // rbMale
            // 
            rbMale.Anchor = AnchorStyles.Top;
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbMale.ForeColor = Color.DimGray;
            rbMale.Location = new Point(79, 338);
            rbMale.Margin = new Padding(3, 2, 3, 2);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 25);
            rbMale.TabIndex = 8;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.Top;
            btnLogIn.BackgroundImage = Properties.Resources.enter__1_;
            btnLogIn.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(158, 394);
            btnLogIn.Margin = new Padding(3, 2, 3, 2);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(52, 43);
            btnLogIn.TabIndex = 5;
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.FromArgb(192, 255, 192);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-36, -20);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(463, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogIn);
            panel1.Controls.Add(rbMale);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(rbFemale);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(lblPassword);
            panel1.Location = new Point(335, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 467);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 255, 255);
            label1.Location = new Point(79, 138);
            label1.Name = "label1";
            label1.Size = new Size(209, 27);
            label1.TabIndex = 10;
            label1.Text = "Financial Tracker";
            label1.Click += label1_Click;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 15, 30);
            ClientSize = new Size(1088, 562);
            Controls.Add(lblErrorLogIn);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Page";
            Load += Login_Page_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblErrorLogIn;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblUserName;
        private RadioButton rbFemale;
        public TextBox txtUserName;
        private RadioButton rbMale;
        private Button btnLogIn;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
    }
}