using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targetSequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine())!= "End")
            {
                string[] action = command.Split();

                switch (action[0])
                {
                    case "Shoot":
                        targetSequence = ShotTarget(targetSequence, int.Parse(action[1]), int.Parse(action[2]));
                        break;
                    case "Add":
                        targetSequence = AddTarget(targetSequence, int.Parse(action[1]), int.Parse(action[2]));
                        break;
                    case "Strike":
                        targetSequence = StrikeTarget(targetSequence, int.Parse(action[1]), int.Parse(action[2]));
                        break;
                }
            }
            Console.WriteLine(string.Join("|", targetSequence));
        }

        private static List<int> StrikeTarget(List<int> list, int index, int radius)
        {
            if (index - radius >= 0 && index + radius <= list.Count - 1)
            {
                int indexToRemove = index;
                int startIndex = Math.Max(0, indexToRemove - radius);
                int count = Math.Min(list.Count - startIndex, radius * 2 + 1);
                list.RemoveRange(startIndex, count);
            }
            else
            {
                Console.WriteLine("Strike missed!");    
            }

            return list;
        }

        private static List<int> AddTarget(List<int> list, int index, int value)
        {
            if (index >= 0 && index <= list.Count - 1)
            {
                list.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }

            return list;
        }

        private static List<int> ShotTarget(List<int> list, int index, int power)
        {
            if (index >= 0 && index <= list.Count - 1)
            {
                list[index] -= power;
            }

            if (list[index] <= 0)
            {
                list.RemoveAt(index);
            }

            return list;
        }
    }
}
