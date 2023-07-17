namespace _05._Shopping_Spree
{
    public class Person
    {
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Products = new List<string>();
        }

        public string Name { get; set; }
        public double Money { get; set; }

        public List<string> Products { get; set; }
    }
    public class Product
    {
        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; }
        public double Cost { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> currentProducts = new List<Product>();
            string[] initialPersonInput = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);
            string test = string.Join(" ",initialPersonInput);
            string[] initialInput = test.Split(new []{'=', ' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < initialInput.Length; i++)
            {
                if (i % 2 == 0)
                {
                    string name = initialInput[i];
                    double money = double.Parse(initialInput[i + 1]);
                    people.Add(new Person(name, money));
                }
            }
            string[] productInputInitial = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            string test2 = string.Join(" ", productInputInitial);
            string[] productInput = test2.Split(new []{'=', ' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < productInput.Length; i++)
            {
                if (i % 2 == 0)
                {
                    string name = productInput[i];
                    double cost = double.Parse(productInput[i + 1]);
                    currentProducts.Add(new Product(name, cost));
                }
            }
            string command;
            List<string> bagOfProducts = new List<string>();
            while ((command = Console.ReadLine())!= "END")
            {
                string[] action = command.Split();

                foreach (var person in people.Where(x=>x.Name == action[0]))
                {
                    foreach (var product in currentProducts.Where(x=>x.Name == action[1]))
                        {
                            if (product.Cost > person.Money)
                            {
                                Console.WriteLine($"{person.Name} can't afford {product.Name}");
                            }
                            else
                            {
                                person.Products.Add(product.Name);
                                person.Money -= product.Cost;
                                Console.WriteLine($"{person.Name} bought {product.Name}");
                            }
                        }
                }
            }
            foreach (var person in people)
            {
                if (person.Products.Count > 0)
                {
                    Console.Write(person.Name + " " + "-" + " ");
                    Console.Write(string.Join(", ", person.Products));
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");    
                }
                Console.WriteLine();
            }

        }
    }
}