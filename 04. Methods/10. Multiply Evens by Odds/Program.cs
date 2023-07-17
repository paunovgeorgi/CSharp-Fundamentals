using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdd(number));
        }
        static int GetMultipleOfEvenAndOdd(int number)
        {
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            return evenSum * oddSum;
        }
        static int GetSumOfEvenDigits(int number)
        {
            int currentNum = 0;
            int sum = 0;
            while (number > 0)
            {
                currentNum = number % 10;
                if (currentNum % 2 == 0)
                {
                    Math.Abs(sum += currentNum);
                }
                number /= 10;
            }
            return sum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int currentNum = 0;
            int sum = 0;
            while (number > 0)
            {
                currentNum = number % 10;
                if (currentNum % 2 != 0)
                {
                    Math.Abs(sum += currentNum);
                }
                number /= 10;
            }
            return sum;
        }
    }
}
