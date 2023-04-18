using TaxProject.interfaces;
namespace TaxProject.services
{


    public class DiscountService : IDiscountService
    {
        public decimal DiscountPercentage { get; set; }
        public DiscountService(decimal discountPercentage)
        {
            DiscountPercentage = discountPercentage;
        }

        public decimal GetDiscountAmuont(decimal price)
        {
            return Math.Round(price * DiscountPercentage, 2);
        }
    }
}