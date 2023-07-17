using System;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int numOfNames = int.Parse(Console.ReadLine());
            double[] finalArray = new double[numOfNames];*/

            string name = Console.ReadLine();
            int vowelSum = 0;
            double consonantSum = 0;
            
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'o' || name[i] == 'u' || name[i] == 'y' ||
                    name[i] == 'i')
                {
                    vowelSum += name[i];
                }
                else
                {
                    consonantSum += (int)name[i] / name.Length;
                }

            }

            int totalVowelSum = vowelSum * name.Length;
            Console.WriteLine(totalVowelSum);
        }







    }
}
