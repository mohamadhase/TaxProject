namespace TaxProject
{
    public interface IPriceCalculator
    {
        decimal CalculateTotalPrice(Product product);
    }
}