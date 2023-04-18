using TaxProject.interfaces;
using TaxProject.models;

namespace TaxProject.services
{
    public class PriceCalculator : IPriceCalculator
    {
        private readonly ITaxService _tax;
        private readonly IDiscountService _discount;
        private readonly IReportService _report;

        public PriceCalculator(ITaxService tax, IDiscountService discount, IReportService report)
        {
            _tax = tax;
            _discount = discount;
            _report = report;
        }

        public decimal CalculateTotalPrice(Product product)
        {
            var price = product.Price;
            var taxAmount = _tax.GetTaxAmount(price);
            var discountAmount = _discount.GetDiscountAmuont(price);
            var totalPrice = price + taxAmount - discountAmount;
            _report.Report(price,totalPrice,discountAmount);
            return totalPrice;
        }
    }
}