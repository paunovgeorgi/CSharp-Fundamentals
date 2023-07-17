using System;

namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmplyee = int.Parse(Console.ReadLine());
            int secondEmplyee = int.Parse(Console.ReadLine());
            int thirdEmplyee = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int numOfAnswersPerHour = firstEmplyee + secondEmplyee + thirdEmplyee;
            int hours = 0;
            while (studentsCount > 0)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    continue;
                }
                studentsCount -= numOfAnswersPerHour;
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
