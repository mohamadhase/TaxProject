using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxProject.enums;
using TaxProject.interfaces;

namespace TaxProject.services
{
    public class SelectiveDiscountService : ISelectiveDiscountService
    {
        public decimal DiscountPercentage { get; set; }
        public int UPS { get; set; }
        public DiscountOrder DiscountOrder { get; set; }

        public SelectiveDiscountService(decimal discountPercentage, int uPS,DiscountOrder discountOrder)
        {
            DiscountPercentage = discountPercentage;
            UPS = uPS;
            DiscountOrder = discountOrder;
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