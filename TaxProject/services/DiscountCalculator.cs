using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxProject.interfaces;

namespace TaxProject.services
{
    public class DiscountCalculator : IDiscountCalculator
    {
        private readonly IDiscountService _discountService;
        private readonly ISelectiveDiscountService _selectiveDiscount;

        public DiscountCalculator(IDiscountService discountService, ISelectiveDiscountService selectiveDiscount)
        {
            _discountService = discountService;
            _selectiveDiscount = selectiveDiscount;
        }

        public decimal GetTotalDiscount(decimal price, int upc)
        {
            var discountAmount = _discountService.GetDiscountAmuont(price);
            var selectiveDiscountAmount = _selectiveDiscount.GetDiscountAmount(price, upc);
            return discountAmount + selectiveDiscountAmount;

        }
    }
}