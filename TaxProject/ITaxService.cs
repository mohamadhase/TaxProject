namespace TaxProject
{
    public interface ITax
    {
        decimal TaxPercentage { get; set; }

        decimal GetTaxAmount(decimal price);
    }
}