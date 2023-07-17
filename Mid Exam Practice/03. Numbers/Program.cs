using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Numbers
{ internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbers = numbers.OrderByDescending(x => x).ToList();
            bool noTopNum = false;
            List<int> topList = new List<int>();
            TopNumbers(numbers, AverageNumber(numbers), topList, ref noTopNum);
            AverageNumber(numbers);

            if (noTopNum)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", topList));
            }
        }
        private static List<int> TopNumbers(List<int> numbers, int averageNumber, List<int> topList, ref bool topNum)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > averageNumber)
                {
                    topList.Add(numbers[i]);
                    counter++;
                }
                if (counter == 5)
                {
                    break;
                }
            }
            if (counter == 0)
            {
                topNum = true;
            }
                return topList;
        }
        private static int AverageNumber(List<int> list)
        {
            int sumOfNumbers = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sumOfNumbers += list[i];
            }

            return  sumOfNumbers / list.Count;
        }
    }
}
