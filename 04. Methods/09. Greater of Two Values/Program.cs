using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace test_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var inputOne = Console.ReadLine();
            var inputTwo = Console.ReadLine();

            bool isValidInputOne = int.TryParse(inputOne, out int inputOneInt);
            bool isValidInputTwo = int.TryParse(inputTwo, out int inputTwoInt);
            bool isValidInputOneChar = char.TryParse(inputOne, out char inputOneChar);
            bool isValidInputTwoChar = char.TryParse(inputTwo, out char inputTwoChar);

            if (isValidInputOne && isValidInputTwo)
            {
                Console.WriteLine(GetMax(inputOneInt, inputTwoInt));
            }
            else if (isValidInputOneChar && isValidInputTwoChar)
            {
                Console.WriteLine(GetMax(inputOneChar, inputTwoChar));
            }
            else
            {
                Console.WriteLine(GetMax(inputOne, inputTwo));
            }

        }

        static string GetMax(string inputOne, string inputTwo)
        {
            if (string.Compare(inputOne, inputTwo) == 1)
            {
                return inputOne;
            }
            else
            {
                return inputTwo;
            }
        }
        static int GetMax(int inputOne, int inputTwo)
        {
            if (inputOne > inputTwo)
            {
                return inputOne;
            }
            else
            {
                return inputTwo;
            }
        }
        static char GetMax(char inputOne, char inputTwo)
        {
            if (inputOne > inputTwo)
            {
                return inputOne;
            }
            else
            {
                return inputTwo;
            }
        }
    }
}

