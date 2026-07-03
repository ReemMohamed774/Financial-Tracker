using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Financial_Tracker.FinanceLogic;

namespace Financial_Tracker
{
    public partial class AddIncome : Form
    {
        public AddIncome()
        {
            InitializeComponent();
        }



        private void AddIncome_Load(object sender, EventArgs e)
        {
        }



        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrWhiteSpace(txtAmount.Text) || cmbCategory.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in the amount and select a category! ⚠️", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!double.TryParse(txtAmount.Text, out double amountValue) || amountValue <= 0)
                {
                    MessageBox.Show("Please enter a valid amount!");
                    return;
                }

                //Make an Object of type Income
                var newIncome = new FinanceLogic.Income()
                {
                    Amount = amountValue,
                    Date = dtpDate.Value,
                    Category = (FinanceLogic.Category)cmbCategory.SelectedIndex,
                    Description = txtDescription.Text
                };
                Properties.Settings.Default.TotalIncome += amountValue;
                Properties.Settings.Default.Save();

                // File handling
                FinanceManager.AddTransaction(newIncome);
                FinanceManager.SaveToFile();

                MessageBox.Show("Income added successfully! 💰");

                txtAmount.Clear();
                txtDescription.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDiscardProfile_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
