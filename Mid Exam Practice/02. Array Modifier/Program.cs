using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberSequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string command;
            while ((command = Console.ReadLine())!= "end")
            {
                string[] actions = command.Split();

                switch (actions[0])
                {
                    case "swap":
                        numberSequence = SwapIndexes(numberSequence, int.Parse(actions[1]), int.Parse(actions[2]));
                        break;
                    case "multiply":
                        numberSequence = MultiplyIndexes(numberSequence, int.Parse(actions[1]), int.Parse(actions[2]));
                        break;
                    case "decrease":
                        numberSequence = DecreaseArray(numberSequence);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", numberSequence));
        }
        private static int[] DecreaseArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= 1;
            }

            return array;
        }

        private static int[] MultiplyIndexes(int[] array, int index1,int index2)
        {
            array[index1] = array[index1] * array[index2];
            return array;
        }

        private static int[] SwapIndexes(int[] array, int index1,int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
            return array;
        }
    }
}
