using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float startingBalance = float.Parse(Console.ReadLine());         
            string input = "";
            float totalSpent = 0;
            var disney = 0.55f;
            while ((input = Console.ReadLine()) != "Game Time")
            {
                float price = 0;
                switch (input)
                {
                    case "OutFall 4": price = 39.99f; break;
                    case "CS: OG": price = 15.99f; break;
                    case "Zplinter Zell": price = 19.99f; break;
                    case "Honored 2": price = 59.99f; break;
                    case "RoverWatch": price = 29.99f; break;
                    case "RoverWatch Origins Edition": price = 39.99f; break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }
                if (startingBalance >= price)
                {
                    Console.WriteLine($"Bought {input}");
                }                              
                else if (startingBalance < price)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                startingBalance -= price;
                if (startingBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                totalSpent += price;
            }
            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${startingBalance:f2}");

        }
    }
}