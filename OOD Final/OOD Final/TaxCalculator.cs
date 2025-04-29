
namespace OOD_Final
{
    public class TaxCalculator
    {
        public decimal FederalRate { get; set; }
        public decimal SocialSecurityRate { get; set; }
        public decimal? StateRate { get; set; }

        public TaxCalculator()
        {
            FederalRate = 0.12m;
            SocialSecurityRate = 0.062m;
            StateRate = null;
        }

        public decimal CalculateFederal(decimal income)
        {
            return income * FederalRate;
        }

        public decimal CalculateSocialSecurity(decimal income)
        {
            return income * SocialSecurityRate;
        }

        public decimal CalculateState(decimal income)
        {
            if (StateRate.HasValue)
            {
                return income * StateRate.Value;
            }
            return 0m;
        }

        public decimal CalculateTotalTaxes(decimal income)
        {
            return CalculateFederal(income) + CalculateSocialSecurity(income) + CalculateState(income);
        }
    }
}

