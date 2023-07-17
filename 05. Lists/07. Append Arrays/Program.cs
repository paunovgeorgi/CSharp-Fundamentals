using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries ).ToArray();
            List<string> output = new List<string>();
            
            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                string[] temp = inputArray[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                output.AddRange(temp);
            }

            Console.WriteLine(string.Join(" ", output));
        }

    }
}
