namespace TaxProject.interfaces
{
    public interface ITaxService
    {
        decimal TaxPercentage { get; set; }

        decimal GetTaxAmount(decimal price);
    }
}