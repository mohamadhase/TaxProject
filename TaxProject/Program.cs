using TaxProject.enums;
using TaxProject.models;
using TaxProject.services;

namespace TaxProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var product = new Product("Milk", 20.25m, 12345);
            var tax = new TaxService();
            var discount = new DiscountService(0.15m,DiscountOrder.AfterTax);
            var selectiveDiscount = new SelectiveDiscountService(0.07m, 12345,DiscountOrder.BeforeTax);
            var discountCalculator = new DiscountCalculator(discount, selectiveDiscount);
            var report = new ReportService();
            var priceCalculator = new PriceCalculator(tax, discountCalculator, report);
            priceCalculator.CalculateTotalPrice(product);
        }
    }
}