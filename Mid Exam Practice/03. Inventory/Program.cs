using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine()
                .Split(", ")
                .ToList();
            string command;
            while ((command = Console.ReadLine()) != "Craft!")
            {
                string[] action = command.Split(" - ");
                switch (action[0])
                {
                    case "Collect":
                        journal = CollectItem(journal, action[1]);
                        break;
                    case "Drop":
                        journal = DropItem(journal, action[1]);
                        break;
                    case "Combine Items":
                        string[] items = action[1].Split(':');
                        journal = CombineItems(journal, items[0], items[1]);
                        break;
                    case "Renew":
                        journal = RenewJournal(journal, action[1]);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", journal));
        }
        private static List<string> RenewJournal(List<string> journal, string item)
        {
            if (journal.Contains(item))
            {
                journal.Remove(item);
                journal.Add(item);
            }
            return journal;
        }
        private static List<string> CombineItems(List<string> journal, string oldItem, string newItem)
        {
            if (journal.Contains(oldItem))
            {
                int index = journal.IndexOf(oldItem);
                journal.Insert(index + 1, newItem);
            }
            return journal;
        }

        private static List<string> DropItem(List<string> journal, string item)
        {
            if (journal.Contains(item))
            {
                journal.Remove(item);
            }
            return journal;
        }
        private static List<string> CollectItem(List<string> journal, string item)
        {
            if (!journal.Contains(item))
            {
                journal.Add(item);
            }
            return journal;
        }
    }
}