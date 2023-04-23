using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxProject.interfaces;
using TaxProject.models;

namespace TaxProject.services
{
    public class ReportService : IReportService
    {
        public void Report(Product product, decimal priceAfter, decimal discountAmount, decimal taxAmount)
        {
            Console.WriteLine($"Cost : ${product.Price}");
            Console.WriteLine($"Tax : ${taxAmount}");
            if (discountAmount > 0)
            {
            Console.WriteLine($"Discounts : ${discountAmount}");
            }
            product.Expenses.ForEach(expense => Console.WriteLine($"{expense.Description} : ${expense.GetCost(product.Price)}"));
            Console.WriteLine($"Total : ${priceAfter}");
            if (discountAmount > 0)
            {
            Console.WriteLine($"${discountAmount} total discount");
            }

        }
    }
}