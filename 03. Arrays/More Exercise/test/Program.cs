using System;
using System.Linq.Expressions;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfNames = int.Parse(Console.ReadLine());
            double[] finalArray = new double[numOfNames];
            for (int i = 0; i < numOfNames; i++)
            {
                string name = Console.ReadLine();
                char[] nameArr = new char[name.Length];

                finalArray[i] = VowelPlusConsonantSum(nameArr, name);
            }

            Array.Sort(finalArray);

            foreach (double element in finalArray)
            {
                Console.WriteLine(element);
            }

        }
        private static double VowelPlusConsonantSum(char[] charArray, string stringInput)
        {
            int vowelSum = 0;
            double consonanSum = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = stringInput[i];
                if (charArray[i] == 'a' || charArray[i] == 'e' || charArray[i] == 'o' || charArray[i] == 'u' || charArray[i] == 'i')
                {
                    vowelSum += (int)charArray[i];
                }
                else
                {
                    consonanSum += (int)charArray[i] / charArray.Length;
                }
            }

            int vowelTotal = vowelSum * charArray.Length;
            

            return vowelTotal + consonanSum;
        }
    }
}
