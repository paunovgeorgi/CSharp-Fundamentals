using Microsoft.VisualBasic.CompilerServices;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int sequenceCount = 0;
            string key = "";
            Dictionary<string, int> minerals = new Dictionary<string, int>();
            while ((input = Console.ReadLine())!= "stop")
            {
                if (sequenceCount % 2 == 0)
                {
                    key = input;
                    minerals.Add(key, 0);
                }
                if (sequenceCount % 2 != 0)
                {
                    minerals[key] += int.Parse(input);
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