using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                .Split('!')
                .ToList();
            string command;
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] type = command.Split();
                switch (type[0])
                {
                    case "Urgent":
                        groceries = UrgentItems(groceries, type[1]);
                        break;
                    case "Unnecessary":
                        groceries = UnnecessaryItems(groceries, type[1]);
                        break;
                    case "Correct":
                        groceries = CorrectItems(groceries, type[1], type[2]);
                        break;
                    case "Rearrange":
                        groceries = RearrangeItems(groceries, type[1]);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", groceries));

        }
        private static List<string> RearrangeItems(List<string> groceries, string item)
        {
            if (groceries.Contains(item))
            {
                groceries.Remove(item);
                groceries.Add(item);
            }
            return groceries;
        }
        private static List<string> CorrectItems(List<string> groceries, string oldItem, string newItem)
        {
            if (groceries.Contains(oldItem))
            {
                int index = groceries.IndexOf(oldItem);
                groceries[index] = newItem;
            }
            return groceries;
        }
        private static List<string> UnnecessaryItems(List<string> groceries, string item)
        {
            if (groceries.Contains(item))
            {
                groceries.Remove(item);
            }
            return groceries;
        }
        private static List<string> UrgentItems(List<string> groceries, string item)
        {
            if (!groceries.Contains(item))
            {
                groceries.Insert(0, item);
            }
            return groceries;
        }
    }
}
