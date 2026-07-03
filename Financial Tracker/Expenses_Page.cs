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
    public partial class Expenses_Page : Form
    {
        public Expenses_Page()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings_Page setting_Page = new Settings_Page();
            setting_Page.WindowState = this.WindowState;
            setting_Page.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Dashboard dashboard = new Dashboard();
            dashboard.WindowState = this.WindowState;
            dashboard.Show();
            this.Hide();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            AddIncome addincome = new AddIncome();
            addincome.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Show_Reports_Page show_Reports_Page = new Show_Reports_Page();
            show_Reports_Page.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Login_Page login = new Login_Page();
            login.WindowState = this.WindowState;
            this.Close();
            login.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddExpenses expenses = new AddExpenses();
            expenses.Show();
        }
    }
}
