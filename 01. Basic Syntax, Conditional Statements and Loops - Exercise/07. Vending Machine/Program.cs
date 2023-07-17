using System;
using System.Reflection.Metadata.Ecma335;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstInput = "";
            double accumulatedAmount = 0;

            while ((firstInput = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(firstInput);
                if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    continue;
                }
                accumulatedAmount += coins;
            }
            string product = "";
            double totalPrice = 0;
            double moneyLeft = accumulatedAmount;
            while ((product = Console.ReadLine()) != "End")
            {
                double price = 0;
                switch (product)
                {
                    case "Nuts": price = 2; break;
                    case "Water": price = 0.7; break;
                    case "Crisps": price = 1.5; break;
                    case "Soda": price = 0.8; break;
                    case "Coke": price = 1; break;
                    default: Console.WriteLine("Invalid product"); continue;
                        
                }
                if (price <= accumulatedAmount)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    totalPrice += price;
                    accumulatedAmount -= price;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }             
            }
            if (accumulatedAmount < 0)
            {
                accumulatedAmount = 0;
            }
            Console.WriteLine($"Change: {accumulatedAmount:f2}");
        }
    }
}
