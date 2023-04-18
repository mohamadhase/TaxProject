namespace TaxProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var product = new Product("Milk", 20.25m, 123456);
            var tax = new TaxService();
            var priceCalculator = new PriceCalculator(tax);
            Console.WriteLine($"Price before Tax : {product.Price}");
            Console.WriteLine($"Price after Tax : {priceCalculator.CalculateTotalPrice(product)}");

        }
    }
}