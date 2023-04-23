using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxProject.interfaces;

namespace TaxProject.services
{
    public class CapService : ICapService
    {
        public decimal CapAmount { get; set; }

        public CapService(decimal amount)
        {
            CapAmount = amount;
        }

        public decimal ApplyCap(decimal price,decimal amount)
        {
            var cap = CapAmount;
            if (CapAmount <= 1)
            {
                cap = Math.Round(CapAmount * price, 2);
            }
            if (amount >= cap)
            {
                return cap;
            }
            return amount;
        }
    }
}
