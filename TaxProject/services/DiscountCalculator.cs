using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxProject.enums;
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

        public DiscountOrder GetDiscountOrder()
        {
            return _discountService.DiscountOrder;

        }

        public DiscountOrder GetSelectiveDiscountOrder()
        {
            return _selectiveDiscount.DiscountOrder;
        }

        public decimal GetDiscountAmuont(decimal price)
        {
            return _discountService.GetDiscountAmuont(price);
        }
        public decimal GetSelectiveDiscountAmount(decimal price, int upc)
        {
            return _selectiveDiscount.GetDiscountAmount(price, upc);
        }
    }
}