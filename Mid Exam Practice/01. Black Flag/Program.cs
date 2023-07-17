using System;

namespace _01._Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double plunderPerDay = double.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double additionalPlunder = plunderPerDay * 0.5;
            double totalPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                totalPlunder += plunderPerDay;
                if (i % 3 == 0)
                {
                    totalPlunder += additionalPlunder;
                }

                if (i % 5 == 0)
                {
                    totalPlunder -= totalPlunder * 0.3;
                }
            }
            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {totalPlunder / expectedPlunder * 100:f2}% of the plunder.");
            }
        }
    }
}
