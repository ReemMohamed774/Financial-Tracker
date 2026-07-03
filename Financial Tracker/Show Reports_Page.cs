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
    public partial class Show_Reports_Page : Form // لعرض التقارير المالية لليوزر 
    {
        public Show_Reports_Page()
        {
            InitializeComponent();           // auto generated 
            RefreshReportsData();          // اول ما الصفحة تشتغل بتعرض تحديث البيانات 
            tblShowReports.BackgroundColor = Color.FromArgb(45, 45, 48);  // جزء التنسيق 
            tblShowReports.BorderStyle = BorderStyle.None;
            tblShowReports.EnableHeadersVisualStyles = false;


            tblShowReports.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            tblShowReports.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tblShowReports.ColumnHeadersHeight = 40;


            tblShowReports.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            tblShowReports.DefaultCellStyle.ForeColor = Color.White;
            tblShowReports.DefaultCellStyle.SelectionBackColor = Color.FromArgb(63, 63, 70);
            tblShowReports.RowHeadersVisible = false;
            tblShowReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e) // للتنقل بين صفحات البرنامج 
        {
            Dashboard dashboard = new Dashboard(); // يفتح الداش بورد
            dashboard.Show();
            this.Hide(); // يخفي الشو ريبورت  this هنا عايدة علي الشو ريبورت 
        }

        private void button5_Click(object sender, EventArgs e) //تسجيل الخروج من النظام 
        {
            this.Close();
            Login_Page login = new Login_Page();
            login.Show();
        }

        private void Show_Reports_Page_Load(object sender, EventArgs e)
        {
            FinanceManager.LoadFromFile(); // لحفظ البيانات في البرنامج حتي بعد ما البرنامج يقفل 
            LoadReportData();
        }
        private void RefreshReportsData()
        {
            // 1. Update numbers
            double income = Properties.Settings.Default.TotalIncome; // اجمالي الدخل 
            double expenses = Properties.Settings.Default.TotalExpenses; // اجمالي المصروفات 
            double balance = income - expenses; //نحسب الاجمالي عن طريق طرحهم من بعض 


            // 2. Display values 
            string currency = Properties.Settings.Default.Currency;
            lblincomereport.Text = income.ToString("N0") + $" {currency}"; // عرض الفلوس علي حسب العملة اللي اليوزر بيستخدمها 
            lblexpensesreport.Text = expenses.ToString("N0") + $" {currency}";
            lblbalancereport.Text = balance.ToString("N0") + $" {currency}";

            // 3. Update the table
            FinanceLogic.FinanceManager.LoadFromFile();

            // 4. Link the table
            if (tblShowReports != null)
            {
                tblShowReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tblShowReports.DataSource = null;
                tblShowReports.DataSource = FinanceLogic.FinanceManager.Transactions.Select(t => new // لينك علشان نجهز بيانات العمليات المالية وتتعرض في الداتا جريد فيو 
                {
                    Date = t.Date.ToShortDateString(),
                    Amount = t.Amount.ToString("N2"),
                    Type = t.TType.ToString(),
                    Category = t.Category.ToString(),
                    Description = t.Description
                }).ToList();
            }
        }
        private void LoadReportData()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Type");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Date");
            dt.Columns.Add("Category");
            dt.Columns.Add("Description");

            double totalIncome = 0;
            double totalExpenses = 0;

            foreach (var t in FinanceManager.Transactions)
            {
                dt.Rows.Add(
                    t.TType.ToString(),
                    t.Amount,
                    t.Date.ToShortDateString(),
                    t.Category.ToString(),
                    t.Description
                );

                if (t.TType == TransactionType.Income)
                    totalIncome += t.Amount;
                else
                    totalExpenses += t.Amount;
            }

            tblShowReports.Columns.Clear();
            tblShowReports.DataSource = dt;

            lblTotalIncome.Text = totalIncome.ToString();
            lblTotalExpenses.Text = totalExpenses.ToString();
            lblTotal.Text = (totalIncome - totalExpenses).ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
