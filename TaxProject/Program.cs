namespace TaxProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product product = new Product("Milk", 2.99m, 123456);
            ITax tax = new Tax();
            
        }
    }
}