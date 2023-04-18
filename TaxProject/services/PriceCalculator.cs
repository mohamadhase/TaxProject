using TaxProject.interfaces;
using TaxProject.models;

namespace TaxProject.services
{
    public class PriceCalculator : IPriceCalculator
    {
        private readonly ITaxService _tax;
        private readonly IDiscountService _discount;
        public PriceCalculator(ITaxService tax, IDiscountService discount)
        {
            _tax = tax;
            _discount = discount;
        }
        public decimal CalculateTotalPrice(Product product)
        {
            var price = product.Price;
            var taxAmount = _tax.GetTaxAmount(price);
            var discountAmount = _discount.GetDiscountAmuont(price);
            var totalPrice = price + taxAmount - discountAmount;
            Report(discountAmount);
            return totalPrice;
        }

        private void Report(decimal discountAmount)
        {
            if (discountAmount > 0)
            {
                Console.WriteLine($"${discountAmount} amount which was deduced");
            }
        }
    }
}