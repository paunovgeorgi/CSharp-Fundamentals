using System;
using System.Collections.Generic;

namespace _01_Count_Chars___Dot3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int sequenceCount = 0;
            string key = "";
            Dictionary<string, double> minerals = new Dictionary<string, double>();
            while ((input = Console.ReadLine()) != "stop")
            {
                if (sequenceCount % 2 == 0)
                {
                    key = input;
                    if (!minerals.ContainsKey(key))
                    {
                        minerals.Add(key, 0);
                    }
                }
                if (sequenceCount % 2 != 0)
                {
                    minerals[key] += double.Parse(input);
                }
                sequenceCount++;
            }

            foreach (var mineral in minerals)
            {
                Console.WriteLine($"{mineral.Key} -> {mineral.Value}");
            }
        }
    }
}
