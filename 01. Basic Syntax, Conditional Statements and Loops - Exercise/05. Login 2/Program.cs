using System;
using System.Linq;

namespace _05._Login_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = "";
            int tries = 1;

            while ((password = Console.ReadLine()) != string.Concat(username.Reverse()))
            {
                if (tries == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                tries++;
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
