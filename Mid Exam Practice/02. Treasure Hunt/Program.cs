using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> loot = Console.ReadLine()
                .Split('|')
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Yohoho!" )
            {
                string[] action = command.Split();
                switch (action[0])
                {
                    case "Loot":
                        loot = MoreLoot(action, loot);
                        break;
                    case "Drop":
                        int index = int.Parse(action[1]);
                        loot = DropLoot(loot, index);
                        break;
                    case "Steal":
                        int count = int.Parse(action[1]);
                        loot = Steal(loot, count);
                        break;
                }
            }
            if (loot.Count > 0)
            {
                string sum = "";
                foreach (string item in loot)
                {
                    sum += item;
                }
                double averageGain = (double)sum.Length / loot.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }

        private static List<string> Steal(List<string> list, int count)
        {
            List<string> dropItemList = new List<string>();
            if (count > list.Count - 1)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    dropItemList.Add(list[i]);
                }
                Console.WriteLine(string.Join(", ", dropItemList));
                list.Clear();
            }
            else
            {
                int startIndex = list.Count - count;
                for (int i = startIndex; i < list.Count; i++)
                {
                    dropItemList.Add(list[i]);
                }

                Console.WriteLine(string.Join(", ", dropItemList));
                list.RemoveRange(startIndex, count);
            }
            return list;
        }

        private static List<string> DropLoot(List<string> list, int index)
        {
            if (index >= 0 && index < list.Count)
            {
                string element = list[index];
                list.RemoveAt(index);
                list.Add(element);
            }
            return list;
        }

        private static List<string> MoreLoot(string[] action, List<string> list)
        {
            for (int i = 1; i < action.Length; i++)
            {
                if (!list.Contains(action[i]))
                {
                    list.Insert(0, action[i]);
                }
            }

            return list;
        }
    }
}
