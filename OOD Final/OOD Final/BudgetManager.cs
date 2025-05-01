using System.Collections.Generic;
using System.Linq;

namespace OOD_Final
{
    public class BudgetManager
    {
        public List<Income> Incomes { get; private set; }
        public List<Expense> Expenses { get; private set; }
        public TaxCalculator TaxCalc { get; private set; }
        public Logger Logger { get; private set; }

        public BudgetManager()
        {
            Incomes = new List<Income>();
            Expenses = new List<Expense>();
            TaxCalc = new TaxCalculator();
            Logger = new Logger();
        }

        public void AddIncome(Income income)
        {
            Incomes.Add(income);
        }

        public void AddExpense(Expense expense)
        {
            Expenses.Add(expense);
        }

        public BudgetEntry GetBudgetSummary()
        {
            decimal gross = Incomes.Sum(i => i.MonthlyAmount * 12);
            decimal taxes = TaxCalc.CalculateTotalTaxes(gross);
            decimal net = gross - taxes;
            decimal totalExpenses = Expenses.Sum(e => e.MonthlyAmount * 12);
            decimal surplus = net - totalExpenses;

            return new BudgetEntry
            {
                GrossIncome = gross,
                NetIncome = net,
                Taxes = taxes,
                Expenses = totalExpenses,
                Surplus = surplus
            };
        }
    }
}

