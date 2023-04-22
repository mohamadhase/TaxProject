using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxProject.models
{
    public class AbsoluteExpense : BaseExpense
    {
        public AbsoluteExpense(string description, decimal amount) : base(description, amount)
        {
        }

        public override decimal GetCost(decimal price)
        {
            return Amount;
        }
    }
}
