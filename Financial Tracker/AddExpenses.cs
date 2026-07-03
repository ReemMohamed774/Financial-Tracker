using Microsoft.VisualBasic;
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
    public partial class AddExpenses : Form
    {
        public AddExpenses()
        {
            InitializeComponent();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            try
            {
                // Verify the inputs
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

                // 1. Calculate the available balance (Income - Expenses already spent)
                double currentBalance = Properties.Settings.Default.TotalIncome - Properties.Settings.Default.TotalExpenses;
                double balanceAfterExpense = currentBalance - amountValue;
                double totalExpensesBefore = Properties.Settings.Default.TotalExpenses;
                double totalExpensesAfter = totalExpensesBefore + amountValue;
                string currency = Properties.Settings.Default.Currency;

                // 2. Check if the new expense is more than the available balance
                if (balanceAfterExpense < 0)
                {
                    MessageBox.Show("Transaction failed! Your balance is 0. You cannot spend more! ⛔", "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // New alert: Has the safety limit (minimum balance) been reached?
                if (balanceAfterExpense <= Properties.Settings.Default.MinBalance)
                {
                    MessageBox.Show($"Warning: Your balance will reach {balanceAfterExpense} {currency}, " +
                                    $"which is at or below your safety limit of {Properties.Settings.Default.MinBalance}! ⚠️",
                                    "Minimum Balance Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // 3. Optional: Warning if you are about to exceed your budget limit
                if (totalExpensesBefore <= Properties.Settings.Default.BudgetLimit && totalExpensesAfter > Properties.Settings.Default.BudgetLimit)
                {
                    MessageBox.Show($"Warning: You have just exceeded your budget limit of {Properties.Settings.Default.BudgetLimit} {currency}! ⚠️",
                                    "Budget Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                var newExpense = new FinanceLogic.Expense()
                {
                    Amount = amountValue,
                    Date = dtpDate.Value,
                    Category = (FinanceLogic.Category)(cmbCategory.SelectedIndex + 17),
                    Description = txtDescription.Text
                };

                // Update settings and save the file
                Properties.Settings.Default.TotalExpenses += amountValue;
                Properties.Settings.Default.Save();

                FinanceManager.AddTransaction(newExpense);
                FinanceManager.SaveToFile();

                MessageBox.Show("Expense added successfully! ✅");

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
