using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_Tracker
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }
        public string username = Properties.Settings.Default.Username;
        public string password = Properties.Settings.Default.Password;

        private void btnLogIn_Click(object sender, EventArgs e)
        {


            string Username = txtUserName.Text;
            string Password = txtPassword.Text;

            //  Data verification
            if (Username == username && Password == password)
            {
                MessageBox.Show("Hello, you are logged in");

                //  Open the Dashboard and hide the login page
                Dashboard dashboard = new Dashboard();
                dashboard.WindowState = this.WindowState;
                dashboard.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid username or password. Try again!");

                // Cleaning the cells
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Page_Load(object sender, EventArgs e)
        {

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}