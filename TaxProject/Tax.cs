namespace TaxProject
{
    public class Tax : ITax
    {
        public decimal TaxPercentage { get; set; }
        public decimal GetTaxAnount(decimal price)
        {
            return price * TaxPercentage;
        }
    }
}