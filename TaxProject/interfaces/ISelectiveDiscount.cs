using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxProject.interfaces
{
    public interface ISelectiveDiscount
    {
        decimal GetDiscountAmount(decimal price, int ups);
    }
}