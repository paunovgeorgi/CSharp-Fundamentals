using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> initialSchedule = Console.ReadLine()
                .Split(", ")
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] arguments = command.Split(':');

                switch (arguments[0])
                {
                    case "Add":
                       initialSchedule = AddTitle(initialSchedule, arguments[1]);
                        break;
                    case "Insert":
                        initialSchedule = InsertTitle(initialSchedule, arguments[1], int.Parse(arguments[2]));
                        break;
                    case "Remove":
                        initialSchedule = RemoveTitle(initialSchedule, arguments[1]);
                        break;
                    case "Swap":
                        initialSchedule = SwapTitles(initialSchedule, arguments[1], arguments[2]);
                        break;
                    case "Exercise":
                        initialSchedule = InsertExercise(initialSchedule, arguments[1]);
                        break;
                }
            }

            for (int i = 1; i < initialSchedule.Count; i++)
            {
                Console.WriteLine($"{i}.{initialSchedule[i]}");
            }
        }

        private static List<string> SwapTitles(List<string> schedule, string titleOne, string titleTwo)
        {
            if (schedule.Contains(titleOne) && schedule.Contains(titleTwo))
            { 
                
                int firstIndex = schedule.IndexOf(titleOne);
            int secondIndex = schedule.IndexOf(titleTwo);

            string temp = schedule[firstIndex];
            schedule[firstIndex] = schedule[secondIndex];
            schedule[secondIndex] = temp;

            }

            return schedule;
        }

        private static List<string> RemoveTitle(List<string> schedule, string title)
        {
            if (schedule.Contains(title))
            {
                schedule.Remove(title);
            }
            return schedule;
        }

        private static List<string> InsertTitle(List<string> schedule, string title, int index)
        {
            if (!schedule.Contains(title))
            {
                schedule.Insert(index, title);
            }

            return schedule;
        }

        private static List<string> InsertExercise(List<string> schedule, string title)
        {
                string exercise = $"{title}-Exercise";
            if (schedule.Contains(title))
            {
                if (!schedule.Contains(exercise))
                {
                    schedule.Insert(schedule.IndexOf(title) + 1, exercise);
                }
            }
            else
            {
                schedule.Add(title);
                schedule.Add(exercise);
            }
            return schedule;
        }

        private static List<string> AddTitle(List<string> schedule, string title)
        {
            if (!schedule.Contains(title))
            {
                schedule.Add(title);
            }

            return schedule;
        }
    }
}
