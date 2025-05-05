
namespace OOD_Final
{
    public class Income
    {
        public string Source { get; set; }
        public decimal MonthlyAmount { get; set; }

        public Income(string source, decimal monthlyAmount)
        {
                Source = source;
            MonthlyAmount = monthlyAmount;
        }

        public decimal GetAnnualAmount()
        {
            return MonthlyAmount * 12;
        }
    }
}
