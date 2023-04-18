namespace TaxProject
{
    public class Tax : ITax
    {
        public decimal TaxPercentage { get; set; }
        public decimal GetTaxAmount(decimal price)
        {
            return Math.Round(price * TaxPercentage,2);
        }
    }
}