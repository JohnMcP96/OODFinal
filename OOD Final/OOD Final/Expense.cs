
namespace OOD_Final
{
    public class Expense
    {
        public string Name { get; set; }
        public decimal MonthlyAmount { get; set; }
        public decimal? InterestRate { get; set; }
        public int? TermMonths { get; set; }

        public Expense(string name, decimal monthlyAmount, decimal? interestRate = null, int? termMonths = null)
        {
            Name = name;
            MonthlyAmount = monthlyAmount;
            InterestRate = interestRate;
            TermMonths = termMonths;
        }

        public decimal GetAnnualAmount()
        {
            return MonthlyAmount * 12;
        }
    }
}

