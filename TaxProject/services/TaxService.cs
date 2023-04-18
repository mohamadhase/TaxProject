using TaxProject.interfaces;

namespace TaxProject.services
{
    public class TaxService : ITaxService
    {
        public decimal TaxPercentage { get; set; }

        public TaxService(decimal taxPercentage = 0.20m)
        {
            TaxPercentage = taxPercentage;
        }

        public decimal GetTaxAmount(decimal price)
        {
            return Math.Round(price * TaxPercentage, 2);
        }
    }
}