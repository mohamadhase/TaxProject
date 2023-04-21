using TaxProject.enums;
using TaxProject.interfaces;
namespace TaxProject.services
{
    public class DiscountService : IDiscountService
    {
        public decimal DiscountPercentage { get; set; }
        public DiscountOrder DiscountOrder { get; set; }
        public DiscountService(decimal discountPercentage,DiscountOrder discountOrder)
        {
            DiscountPercentage = discountPercentage;
            DiscountOrder = discountOrder;
        }

        public decimal GetDiscountAmuont(decimal price)
        {
            return Math.Round(price * DiscountPercentage, 2);
        }
    }
}