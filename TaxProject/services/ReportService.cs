using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxProject.interfaces;

namespace TaxProject.services
{
    public class ReportService : IReportService
    {
        public void Report(decimal priceBefroe, decimal priceAfter, decimal discountAmount)
        {
            Console.WriteLine($"Price ${priceBefroe}");
            Console.WriteLine($"Total Price After Tax and Discount ${priceAfter}");
            if (discountAmount > 0)
            {
                Console.WriteLine($"${discountAmount} amount was deduced");
            }

        }
    }
}