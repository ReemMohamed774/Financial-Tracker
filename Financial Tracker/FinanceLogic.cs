using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Tracker
{
    internal class FinanceLogic
    {



        // 1. Enumerations:
        public enum TransactionType { Income, Expense }
        public enum Category
        {
            // --- Income Categories  ---
            Salary_Wages, Freelance_Contract, Work, Business_Income, Bonuses, Overtime_Pay,
            Dividends, Interest_Income, Rental_Income, Capital_Gains, Pension_Retirement,
            Government_Benefits, Side_Hustle_Income, Gifts, Selling_Items, Refunds_Cashback, Other_Income,

            // --- Expense Categories ---
            Rent_Mortgage, Utilities, Groceries, Transportation, Dining_Out, Entertainment,
            Subscriptions, Healthcare, Insurance, Debt_Payments, Education, Shopping_Retail,
            Travel, Personal_Care, Household_Supplies, Other_Expense
        }

        // 2. Class Definitions & Inheritance:
        public abstract class Transaction // abstract so that no one can create an object directly from it
        {
            public double Amount { get; set; }
            public DateTime Date { get; set; }
            public Category Category { get; set; }
            public string Description { get; set; }
            public abstract TransactionType TType { get; }
        }

        // Genetics of exchange operations
        public class Expense : Transaction
        {
            public override TransactionType TType => TransactionType.Expense;
        }

        // Inheritance of income processes
        public class Income : Transaction
        {
            public override TransactionType TType => TransactionType.Income;
        }

        //Core Engine (File Handling & Arrays)
        public static class FinanceManager
        {
            //Use List (which is a Dynamic Array) to store objects
            public static List<Transaction> Transactions = new List<Transaction>();
            private static string filePath = "my_data.txt";

            // Method to add a new process
            public static void AddTransaction(Transaction t)
            {
                Transactions.Add(t);
            }

            //File Handling: Save data to a file
            public static void SaveToFile()
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (var t in Transactions)
                        {
                            writer.WriteLine($"{t.TType}|{t.Amount}|{t.Date:yyyy-MM-dd}|{t.Category}|{t.Description}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error saving: " + ex.Message);
                }
            }

            //File Handling: Reading data from a file
            public static void LoadFromFile()
            {
                if (!File.Exists(filePath)) return;

                Transactions.Clear(); // We delete what's there so it doesn't happen again
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] p = line.Split('|');
                    Transaction t;

                    // We look at the type to deny Object from the correct class (Polymorphism)
                    if (p[0] == "Expense") t = new Expense();
                    else t = new Income();

                    t.Amount = double.Parse(p[1]);
                    t.Date = DateTime.Parse(p[2]);
                    if (Enum.TryParse(p[3], out Category tempCat))
                    {
                        t.Category = tempCat;
                    }
                    else
                    {
                        t.Category = Category.Other_Expense;
                    }
                    t.Description = p[4];

                    Transactions.Add(t);
                }
            }
        }
    }
}

