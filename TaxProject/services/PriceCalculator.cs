using System.Net.WebSockets;
using TaxProject.enums;
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
            var discountOrder = _discountCalculator.GetDiscountOrder();
            var selectiveDiscountOrder = _discountCalculator.GetSelectiveDiscountOrder();
            var discountAmount = 0m;
            var selectiveDiscountAmount = 0m;
            var totalDiscount = 0m;
            var taxAmount = 0m;
            var totalPrice = 0m;
            if (discountOrder == DiscountOrder.BeforeTax && selectiveDiscountOrder == DiscountOrder.BeforeTax)
            {
                 discountAmount = _discountCalculator.GetDiscountAmuont(price,product.UPC,true);
                 selectiveDiscountAmount = _discountCalculator.GetSelectiveDiscountAmount(price, product.UPC,false);
                 totalDiscount = discountAmount + selectiveDiscountAmount;
                 price = price - totalDiscount;
                 taxAmount = _tax.GetTaxAmount(price);
            }
            else if (discountOrder == DiscountOrder.BeforeTax && selectiveDiscountOrder == DiscountOrder.AfterTax)
            {
                 discountAmount = _discountCalculator.GetDiscountAmuont(price, product.UPC, true);
                 price = price - discountAmount;
                 taxAmount = _tax.GetTaxAmount(price);
                 selectiveDiscountAmount = _discountCalculator.GetSelectiveDiscountAmount(price, product.UPC, false);
                 totalDiscount = discountAmount + selectiveDiscountAmount;
            }
            else if (discountOrder == DiscountOrder.AfterTax && selectiveDiscountOrder == DiscountOrder.BeforeTax)
            {
                 selectiveDiscountAmount = _discountCalculator.GetSelectiveDiscountAmount(price, product.UPC, false);
                 price = price - selectiveDiscountAmount;
                 taxAmount = _tax.GetTaxAmount(price);
                 discountAmount = _discountCalculator.GetDiscountAmuont(price, product.UPC, true);
                 totalDiscount = discountAmount + selectiveDiscountAmount;
            }
            else
            {
                 taxAmount = _tax.GetTaxAmount(price);
                 discountAmount = _discountCalculator.GetDiscountAmuont(price, product.UPC, true);
                 selectiveDiscountAmount = _discountCalculator.GetSelectiveDiscountAmount(price, product.UPC, false);
                 totalDiscount = discountAmount + selectiveDiscountAmount;
            }
            var totalExpensesCost = product.GetTotalExpenses();
            totalPrice = product.Price + taxAmount - totalDiscount + totalExpensesCost;
            _report.Report(product, totalPrice, totalDiscount,taxAmount);
            return totalPrice;
        }
    }
}