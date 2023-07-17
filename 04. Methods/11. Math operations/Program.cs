using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            char charOperatr = char.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine(MathOperator(firstNum, charOperatr, secondNum));

        }
            static double MathOperator(double firstNumber, char symbol, double secondNUmber)
            {
                double result = 0;
                if (symbol == '/')
                {
                    result = firstNumber / secondNUmber;
                }
                else if (symbol == '*')
                {
                    result = firstNumber * secondNUmber;
                }
                else if (symbol == '+')
                {
                    result = firstNumber + secondNUmber;
                }
                else
                {
                    result = firstNumber - secondNUmber;
                }

                return result;


            }

        
    }
}
