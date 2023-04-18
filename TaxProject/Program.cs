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
            var priceCalculator = new PriceCalculator(tax,discount);
            Console.WriteLine($"Price before Tax and Discount : ${product.Price}");
            Console.WriteLine($"Price after Tax And Discount : ${priceCalculator.CalculateTotalPrice(product)}");

        }
    }
}