using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices.ComTypes;

namespace _05._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 =  int.Parse(Console.ReadLine());
            int num2 =  int.Parse(Console.ReadLine());
            int num3 =  int.Parse(Console.ReadLine());

            ProductOfThreeNumbers(num1, num2, num3);

            static void ProductOfThreeNumbers(int one, int two, int three)
            {
                int negativeCounter = 0;
                if (one == 0 || two == 0 || three == 0)
                {
                    Console.WriteLine("zero");
                    return;
                }
                if (one < 0)
                {
                    negativeCounter++;
                }

                if (two < 0)
                {
                    negativeCounter++;
                }
                if (three < 3)
                {
                    negativeCounter++;
                }

                if (negativeCounter % 2 == 0)
                {
                    Console.WriteLine("positive");
                }
                else if (negativeCounter % 2 != 0)
                {
                    Console.WriteLine("negative");
                }
                
            }

        }
    }
}
