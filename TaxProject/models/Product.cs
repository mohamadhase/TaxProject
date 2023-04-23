using TaxProject.enums;

namespace TaxProject.models
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
        public List<BaseExpense> Expenses { get; set; }
        public Currency Currency { get; set; }

        public Product(string name, decimal price, int upc,Currency currency = Currency.USD)
        {
            Name = name;
            Price = price;
            UPC = upc;
            Expenses = new List<BaseExpense>();
            Currency = currency;
        }

        public void AddExpense(BaseExpense expense)
        {
            Expenses.Add(expense);
        }

        public void RemoveExpense(BaseExpense expense)
        {
            Expenses.Remove(expense);
        }

        public decimal GetTotalExpenses()
        {
            return Expenses.Sum(expense => expense.GetCost(Price));
        }
    }
}