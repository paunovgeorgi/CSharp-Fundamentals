using System;
using System.Runtime.ExceptionServices;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int workNum = number;
            int sum = 0;

            while (workNum > 0)
            {
                int individualSum = 1;
                for (int i = 1; i <= workNum % 10; i++)
                {
                    individualSum *= i;
                }
                sum += individualSum;
                workNum = workNum / 10;
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
