namespace _03._Orders
{
    public class Product
    {
        public Product(double price, double quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        public double Price { get; set; }
        public double Quantity { get; set; }
        public double TotalPrice
        {
            get { return Price * Quantity; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            string input;
            while ((input = Console.ReadLine())!= "buy")
            {
                string[] items = input.Split();
                string name = items[0];
                double price = double.Parse(items[1]);
                double quantity = double.Parse(items[2]);

                if (!products.ContainsKey(name))
                {
                    products.Add(name, new Product(price, quantity));
                }
                else
                {
                    products[name].Price = price;
                    products[name].Quantity += quantity;
                }
            }
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value.TotalPrice:f2}");
            }
        }
    }
}