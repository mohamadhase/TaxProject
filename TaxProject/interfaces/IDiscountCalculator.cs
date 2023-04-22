using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxProject.enums;

namespace TaxProject.interfaces
{
   public interface IDiscountCalculator
    {
        decimal GetDiscountAmuont(decimal price);
        decimal GetSelectiveDiscountAmount(decimal price, int upc);

        DiscountOrder GetDiscountOrder();
        DiscountOrder GetSelectiveDiscountOrder();
    }
}