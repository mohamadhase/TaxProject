using TaxProject.models;
using TaxProject.services;

namespace TaxProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var product = new Product("Milk", 20.25m, 123456);
            var tax = new TaxService();
            var discount = new DiscountService(0.15m);
            var report = new ReportService();
            var priceCalculator = new PriceCalculator(tax, discount,report);
        }
    }
}