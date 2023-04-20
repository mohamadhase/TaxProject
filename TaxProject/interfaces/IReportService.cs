using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxProject.interfaces
{
    public interface IReportService
    {
        void Report(decimal priceBefroe, decimal priceAfter, decimal discountAmount);
    }
}