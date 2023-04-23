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
        public DiscountType DiscountType { get; set; }

        public DiscountCalculator(IDiscountService discountService, ISelectiveDiscountService selectiveDiscount, DiscountType discountType)
        {
            _discountService = discountService;
            _selectiveDiscount = selectiveDiscount;
            DiscountType = discountType;
        }

        public DiscountOrder GetDiscountOrder()
        {
            return _discountService.DiscountOrder;

        }

        public DiscountOrder GetSelectiveDiscountOrder()
        {
            return _selectiveDiscount.DiscountOrder;
        }

        public decimal GetDiscountAmuont(decimal price,int upc,bool first)
        {
            if (DiscountType == DiscountType.Multiplicative && first)
            {
                price = price - _selectiveDiscount.GetDiscountAmount(price, upc);
            }
            return _discountService.GetDiscountAmuont(price);
        }
        public decimal GetSelectiveDiscountAmount(decimal price, int upc,bool first)
        {
            if (DiscountType == DiscountType.Multiplicative && first)
            {
                price = price - _discountService.GetDiscountAmuont(price);
            }
            return _selectiveDiscount.GetDiscountAmount(price, upc);
        }
    }
}