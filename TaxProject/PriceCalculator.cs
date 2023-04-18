using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxProject
{
    public class PriceCalculator : IPriceCalculator
    {
        private ITax _tax;
        public PriceCalculator(ITax tax)
        {
            _tax = tax;
        }
        public decimal CalculateTotalPrice(Product product)
        {
            return product.Price + _tax.GetTaxAmount(product.Price);
        }
    }
}
