using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxProject.enums;

namespace TaxProject.interfaces
{
    public interface ISelectiveDiscountService
    {
        DiscountOrder DiscountOrder { get; set; }
        decimal GetDiscountAmount(decimal price, int ups);
    }
}