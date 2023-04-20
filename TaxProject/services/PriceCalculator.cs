using TaxProject.interfaces;
using TaxProject.models;

namespace TaxProject.services
{
    public class PriceCalculator : IPriceCalculator
    {
        private readonly ITaxService _tax;
        private readonly IReportService _report;
        private readonly IDiscountCalculator _discountCalculator;

        public PriceCalculator(ITaxService tax, IDiscountCalculator discountCalculator, IReportService report)
        {
            _tax = tax;
            _discountCalculator = discountCalculator;
            _report = report;
        }

        public decimal CalculateTotalPrice(Product product)
        {
            var price = product.Price;
            var taxAmount = _tax.GetTaxAmount(price);
            var TotalDiscount = _discountCalculator.GetTotalDiscount(price, product.UPC);
            var totalPrice = price + taxAmount - TotalDiscount;
            _report.Report(price,totalPrice, TotalDiscount);
            return totalPrice;
        }
    }
}