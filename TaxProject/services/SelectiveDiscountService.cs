using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxProject.interfaces;

namespace TaxProject.services
{
    public class SelectiveDiscountService : ISelectiveDiscountService
    {
        public decimal DiscountPercentage { get; set; }
        public int UPS { get; set; }

        public SelectiveDiscountService(decimal discountPercentage, int uPS)
        {
            DiscountPercentage = discountPercentage;
            UPS = uPS;
        }

        public decimal GetDiscountAmount(decimal price, int ups)
        {
            if (UPS != ups)
            {
                return 0;
            }
            return Math.Round(price * DiscountPercentage, 2);
        }

    }
}