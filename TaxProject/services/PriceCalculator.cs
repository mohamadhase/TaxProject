using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxProject.interfaces;

namespace TaxProject
{
    public class PriceCalculator : IPriceCalculator
    {
        private readonly ITaxService _tax;
        private readonly IDiscountService _discount;
        public PriceCalculator(ITaxService tax,IDiscountService discount)
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
            return totalPrice;
        }
    }
}
