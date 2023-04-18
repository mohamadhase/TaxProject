using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxProject
{
    public class PriceCalculator : IPriceCalculator
    {
        private ITaxService _tax;
        public PriceCalculator(ITaxService tax)
        {
            _tax = tax;
        }
        public decimal CalculateTotalPrice(Product product)
        {
            return product.Price + _tax.GetTaxAmount(product.Price);
        }
    }
}
