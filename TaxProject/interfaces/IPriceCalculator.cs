using TaxProject.models;

namespace TaxProject.interfaces
{
    public interface IPriceCalculator
    {
        decimal CalculateTotalPrice(Product product);
    }
}