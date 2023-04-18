namespace TaxProject
{
    public class Product
    {
        public string Name { get; set; }

        private decimal _price;

        public decimal Price
        {
            get => _price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }
                _price = value;
            }
        }

        public int UPC { get; set; }
        public Product(string name, decimal price, int uPC)
        {
            Name = name;
            Price = price;
            UPC = uPC;
        }

    }
}
