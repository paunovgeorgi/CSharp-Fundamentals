using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double totalPrice;

            if (type == "Students")
            {
                switch (day)
                {
                    case "Friday": price+= 8.45; break;
                    case "Saturday": price += 9.80; break;
                    case "Sunday": price += 10.46; break;
                }
                totalPrice = numOfPeople * price;
                if (numOfPeople >= 30)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (type == "Business")
            {
                switch (day)
                {
                    case "Friday": price += 10.90; break;
                    case "Saturday": price += 15.60; break;
                    case "Sunday": price += 16; break;
                }
                totalPrice = numOfPeople * price;
                if (numOfPeople >= 100)
                {
                    totalPrice = totalPrice - (10 * price);
                }
            }
            else
            {
                switch (day)
                {
                    case "Friday": price += 15; break;
                    case "Saturday": price += 20; break;
                    case "Sunday": price += 22.50; break;
                }
                totalPrice = numOfPeople * price;
                if (numOfPeople >= 10 && numOfPeople <= 20)
                {
                    totalPrice *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
