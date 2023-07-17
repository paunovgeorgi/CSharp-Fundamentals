using System;
using System.Runtime.Intrinsics.X86;

namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string age = "";

            if (num <= 2)
            {
                age = "baby";
            }
            else if (num <= 13)
            {
                age = "child";
            }
            else if (num <= 19)
            {
                age = "teenager";
            }
            else if (num <= 65)
            {
                age = "adult";
            }
            else
            {
                age = "elder";
            }
            Console.WriteLine(age);

        }
    }
}
