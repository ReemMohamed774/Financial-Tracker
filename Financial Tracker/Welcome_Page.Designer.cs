namespace Financial_Tracker
{
    partial class Welcome_Page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_Page));
            panel1 = new Panel();
            btnGo = new Button();
            label2 = new Label();
            label1 = new Label();
            btnContributers = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(btnGo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(299, 79);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 282);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnGo
            // 
            btnGo.Anchor = AnchorStyles.Top;
            btnGo.BackgroundImage = Properties.Resources.next_button;
            btnGo.BackgroundImageLayout = ImageLayout.Zoom;
            btnGo.FlatAppearance.BorderSize = 0;
            btnGo.FlatStyle = FlatStyle.Flat;
            btnGo.Location = new Point(141, 203);
            btnGo.Margin = new Padding(3, 2, 3, 2);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(80, 65);
            btnGo.TabIndex = 6;
            btnGo.UseVisualStyleBackColor = false;
            btnGo.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(30, 41, 59);
            label2.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 255, 255);
            label2.Location = new Point(47, 120);
            label2.Name = "label2";
            label2.Size = new Size(277, 33);
            label2.TabIndex = 4;
            label2.Text = "Financial Tracker";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(30, 41, 59);
            label1.Font = new Font("Ink Free", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(4, 25);
            label1.Name = "label1";
            label1.Size = new Size(361, 60);
            label1.TabIndex = 3;
            label1.Text = "Welcome to your";
            label1.Click += label1_Click;
            // 
            // btnContributers
            // 
            btnContributers.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnContributers.BackColor = Color.FromArgb(30, 41, 59);
            btnContributers.Font = new Font("Imprint MT Shadow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContributers.ForeColor = Color.White;
            btnContributers.Location = new Point(27, 467);
            btnContributers.Margin = new Padding(3, 2, 3, 2);
            btnContributers.Name = "btnContributers";
            btnContributers.Size = new Size(129, 36);
            btnContributers.TabIndex = 1;
            btnContributers.Text = "Contributors";
            btnContributers.UseVisualStyleBackColor = false;
            btnContributers.Click += btnContributers_Click;
            // 
            // Welcome_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 24, 39);
            BackgroundImage = Properties.Resources.Blue_Money_Background_for_Project1;
            ClientSize = new Size(889, 512);
            Controls.Add(btnContributers);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Welcome_Page";
            Text = "Welcome Page";
            Load += Welcome_Page_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnGo;
        private Button btnContributers;
    }
}
