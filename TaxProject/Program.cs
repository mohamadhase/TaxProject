using TaxProject.models;
using TaxProject.services;

namespace TaxProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product product = new("Milk", 20.25m, 123456);
            TaxService tax = new();
            DiscountService discount = new(0.15m);
            PriceCalculator priceCalculator = new(tax, discount);
            Console.WriteLine($"Price before Tax and Discount : ${product.Price}");
            Console.WriteLine($"Price after Tax And Discount : ${priceCalculator.CalculateTotalPrice(product)}");

        }
    }
}