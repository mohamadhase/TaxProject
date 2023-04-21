using TaxProject.enums;

namespace TaxProject.interfaces
{
    public interface IDiscountService
    {
        DiscountOrder DiscountOrder { get; set; }
        decimal GetDiscountAmuont(decimal price);
    }
}