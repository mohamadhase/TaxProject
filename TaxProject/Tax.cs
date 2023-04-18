namespace TaxProject
{
    public class Tax : ITax
    {
        public decimal TaxPercentage { get; set; }
        public Tax(decimal taxPercentage = 0.20m)
        {
            TaxPercentage = taxPercentage;
        }

        public decimal GetTaxAmount(decimal price)
        {
            return Math.Round(price * TaxPercentage,2);
        }
    }
}