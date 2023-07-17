using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToList();

            string command;
            int currentIndex = 0;
            int lastPosition = 0;

            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] action = command.Split();
                int length = int.Parse(action[1]);

                currentIndex += length;
                if (currentIndex > neighborhood.Count - 1)
                {
                    currentIndex = 0;
                }
                lastPosition = currentIndex;
                if (neighborhood[currentIndex] <= 0)
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                    continue;
                }
                neighborhood[currentIndex] -= 2;

                if (neighborhood[currentIndex] <= 0)
                {
                    Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                }
            }
            bool allZeros = neighborhood.All(x => x == 0);
            int failed = 0;
            Console.WriteLine($"Cupid's last position was {lastPosition}.");
            if (allZeros)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                foreach (int house in neighborhood)
                {
                    if (house > 0)
                    {
                        failed++;
                    }
                }
                Console.WriteLine($"Cupid has failed {failed} places.");
            }
        }
    }
}
