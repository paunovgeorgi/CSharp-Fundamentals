using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            char[] stringArray = username.ToCharArray();
            Array.Reverse(stringArray);
            string reversedPass = new string(stringArray);
            string password = "";
            int tries = 1;

            while ((password = Console.ReadLine()) != reversedPass)
            {
                Console.WriteLine("Incorrect password. Try again.");
                if (tries == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                tries++;
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
