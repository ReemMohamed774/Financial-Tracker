namespace Financial_Tracker
{
    public partial class Welcome_Page : Form
    {
        public Welcome_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Page login = new Login_Page();
            login.WindowState = this.WindowState;
            this.Hide();
            login.Show();
        }
        private void btnContributers_Click(object sender, EventArgs e)
        {
            Contributors contributors = new Contributors();
            contributors.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(15, 23, 42);
        }

        private void Welcome_Page_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }



}



