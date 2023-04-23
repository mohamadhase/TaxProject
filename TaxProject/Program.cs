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
            var PackagingCost = new PercentageExpense("Packaging", 0.01m);
            var TransportCost = new AbsoluteExpense("Transport", 2.2m);
            product.AddExpense(PackagingCost);
            product.AddExpense(TransportCost);
            var tax = new TaxService(0.21m);
            var discount = new DiscountService(0.15m,DiscountOrder.AfterTax);
            var selectiveDiscount = new SelectiveDiscountService(0.07m, 12345,DiscountOrder.AfterTax);
            var discountCalculator = new DiscountCalculator(discount, selectiveDiscount,DiscountType.Multiplicative);
            var report = new ReportService();
            var cap = new CapService(0.20M);
            var priceCalculator = new PriceCalculator(tax, discountCalculator, report,cap);
            priceCalculator.CalculateTotalPrice(product);
        }
    }
}