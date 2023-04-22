using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxProject.models;

namespace TaxProject.interfaces
{
    public interface IReportService
    {
        void Report(Product product, decimal priceAfter, decimal discountAmount,decimal taxAmount);
    }
}