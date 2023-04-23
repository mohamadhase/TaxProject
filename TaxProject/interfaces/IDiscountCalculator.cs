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
        decimal GetDiscountAmuont(decimal price,int upc,bool first);
        decimal GetSelectiveDiscountAmount(decimal price, int upc, bool first);

        DiscountOrder GetDiscountOrder();
        DiscountOrder GetSelectiveDiscountOrder();
    }
}