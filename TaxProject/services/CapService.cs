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

        public decimal ApplyCap(decimal amount)
        {
            var cap = CapAmount;
            if (CapAmount <= 1)
            {
                cap = Math.Round(CapAmount * amount,2);
            }
            if (amount >= cap)
            {
                return cap;
            }
            return amount;
        }
    }
}
