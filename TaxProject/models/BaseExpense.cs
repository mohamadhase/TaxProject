using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxProject.models
{
    public abstract class BaseExpense
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }

        public BaseExpense(string description, decimal amount)
        {
            Description = description;
            Amount = amount;
        }

        public abstract decimal GetCost(decimal price);
    }
}