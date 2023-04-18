namespace TaxProject
{
    public interface ITax
    {
        decimal TaxPercentage { get; set; }

        decimal GetTaxAnount(decimal price);
    }
}