using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Final
{
    public partial class Form1 : Form
    {
        private BudgetManager budgetManager = new BudgetManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            string source = Prompt.ShowDialog("Enter income source:", "Add Income");
            string amountStr = Prompt.ShowDialog("Enter monthly income amount:", "Add Income");

            if (decimal.TryParse(amountStr, out decimal amount))
            {
                var income = new Income(source, amount);
                budgetManager.AddIncome(income);
                budgetManager.Logger.Log($"Added income: {source} - ${amount}/month");
                RefreshLog();
                RefreshIncomeAndExpenseLists();
                MessageBox.Show("Income added.");
            }
            else
            {
                MessageBox.Show("Invalid amount.");
            }
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            string name = Prompt.ShowDialog("Enter expense name:", "Add Expense");
            string amountStr = Prompt.ShowDialog("Enter monthly expense amount:", "Add Expense");

            if (decimal.TryParse(amountStr, out decimal amount))
            {
                string interestStr = Prompt.ShowDialog("Enter interest rate (optional):", "Add Expense");
                string termStr = Prompt.ShowDialog("Enter term in months (optional):", "Add Expense");

                decimal? interest = decimal.TryParse(interestStr, out decimal i) ? i : (decimal?)null;
                int? term = int.TryParse(termStr, out int t) ? t : (int?)null;

                budgetManager.AddExpense(new Expense(name, amount, interest, term));
                budgetManager.Logger.Log($"Expense added: {name}, ${amount}");
                RefreshIncomeAndExpenseLists();
                RefreshLog();
                MessageBox.Show("Expense added.");
            }
            else
            {
                MessageBox.Show("Invalid amount.");
            }
        }

        private void btnViewBudget_Click(object sender, EventArgs e)
        {
            var summary = budgetManager.GetBudgetSummary();
            string message = $"Gross Income: ${summary.GrossIncome}\n" +
                             $"Net Income: ${summary.NetIncome}\n" +
                             $"Taxes: ${summary.Taxes}\n" +
                             $"Expenses: ${summary.Expenses}\n" +
                             $"Surplus: ${summary.Surplus}";

            budgetManager.Logger.Log("Viewed budget summary.");
            RefreshLog();
            MessageBox.Show(message, "Budget Summary");
        }

        private void btnUpdateBudget_Click(object sender, EventArgs e)
        {
            var choiceForm = new UpdateChoiceForm();
            if (choiceForm.ShowDialog() != DialogResult.OK) return;

            string type = choiceForm.Choice;

            if (type == "income")
            {
                if (budgetManager.Incomes.Count == 0)
                {
                    MessageBox.Show("No income entries to update.");
                    return;
                }

                string list = string.Join("\n", budgetManager.Incomes.Select((inc, i) => $"{i + 1}. {inc.Source} - ${inc.MonthlyAmount}"));
                string choiceStr = Prompt.ShowDialog("Select an income to update:\n" + list, "Update Income");

                if (int.TryParse(choiceStr, out int index) && index >= 1 && index <= budgetManager.Incomes.Count)
                {
                    string newSource = Prompt.ShowDialog("Enter new income source:", "Update Income");
                    string newAmountStr = Prompt.ShowDialog("Enter new monthly amount:", "Update Income");

                    if (decimal.TryParse(newAmountStr, out decimal newAmount))
                    {
                        budgetManager.Incomes[index - 1] = new Income(newSource, newAmount);
                        budgetManager.Logger.Log($"Updated income #{index}");
                        RefreshLog();
                        RefreshIncomeAndExpenseLists();
                        MessageBox.Show("Income updated.");
                    }
                    else MessageBox.Show("Invalid amount.");
                }
                else MessageBox.Show("Invalid selection.");
            }
            else if (type == "expense")
            {
                if (budgetManager.Expenses.Count == 0)
                {
                    MessageBox.Show("No expenses to update.");
                    return;
                }

                string list = string.Join("\n", budgetManager.Expenses.Select((exp, i) => $"{i + 1}. {exp.Name} - ${exp.MonthlyAmount}"));
                string choiceStr = Prompt.ShowDialog("Select an expense to update:\n" + list, "Update Expense");

                if (int.TryParse(choiceStr, out int index) && index >= 1 && index <= budgetManager.Expenses.Count)
                {
                    string newName = Prompt.ShowDialog("Enter new expense name:", "Update Expense");
                    string newAmountStr = Prompt.ShowDialog("Enter new monthly amount:", "Update Expense");
                    string newInterestStr = Prompt.ShowDialog("Enter new interest rate (optional):", "Update Expense");
                    string newTermStr = Prompt.ShowDialog("Enter new term in months (optional):", "Update Expense");

                    if (decimal.TryParse(newAmountStr, out decimal newAmount))
                    {
                        decimal? interest = decimal.TryParse(newInterestStr, out decimal i) ? i : (decimal?)null;
                        int? term = int.TryParse(newTermStr, out int t) ? t : (int?)null;

                        budgetManager.Expenses[index - 1] = new Expense(newName, newAmount, interest, term);
                        budgetManager.Logger.Log($"Updated expense #{index}");
                        RefreshLog();
                        RefreshIncomeAndExpenseLists();
                        MessageBox.Show("Expense updated.");
                    }
                    else MessageBox.Show("Invalid amount.");
                }
                else MessageBox.Show("Invalid selection.");
            }
        }

        private void RefreshLog()
        {
            lstLogger.Items.Clear();
            foreach (var entry in budgetManager.Logger.GetLogs())
            {
                lstLogger.Items.Add(entry);
            }
        }

        private void RefreshIncomeAndExpenseLists()
        {
            lstIncomes.Items.Clear();
            foreach (var income in budgetManager.Incomes)
            {
                lstIncomes.Items.Add($"{income.Source} - ${income.MonthlyAmount}");
            }

            lstExpenses.Items.Clear();
            foreach (var expense in budgetManager.Expenses)
            {
                lstExpenses.Items.Add($"{expense.Name} - ${expense.MonthlyAmount}");
            }
        }


    }
}
