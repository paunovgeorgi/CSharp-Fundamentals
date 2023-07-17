using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> input = Console.ReadLine()
               .Split()
               .ToList();
           string command;

           while ((command = Console.ReadLine()) != "3:1")
           {
               string[] action = command.Split();
               switch (action[0])
               {
                    case "merge":
                        int startIndex = int.Parse(action[1]);
                        int endIndex = int.Parse(action[2]);
                        input = MergeElements(input, startIndex, endIndex);
                        break;
                    case "divide":
                        int index = int.Parse(action[1]);
                        int partitions = int.Parse(action[2]);
                        input = DivideElements(input, index, partitions);
                        break;
               }
           }
           Console.WriteLine(string.Join(" ", input));
        }

        private static List<string> DivideElements(List<string> list, int index, int partitions)
        {
            List<string> tempList = new List<string>();
            string wholeElement = list[index];

            if (wholeElement.Length % partitions == 0)
            {
            int rotationRate = wholeElement.Length / partitions;
                for (int i = 0; i < wholeElement.Length; i+= rotationRate)
                {
                    string temporary = "";
                    for (int j = i; j < rotationRate + i; j++)
                    {
                        temporary += wholeElement[j];
                    }
                    tempList.Add(temporary);
                }
            list.RemoveAt(index);
            for (int i = tempList.Count -1; i >= 0; i--)
            {
                list.Insert(index, tempList[i]);
            }
            }
            else if (wholeElement.Length % partitions != 0)
            {
                int equalPartLength = wholeElement.Length / partitions;
                int lastPartLength = equalPartLength + wholeElement.Length % partitions;

                for (int i = 0; i < partitions - 1; i++)
                {
                    string temporary = wholeElement.Substring(i * equalPartLength, equalPartLength);
                    tempList.Add(temporary);
                }

                string lastPart = wholeElement.Substring((partitions - 1) * equalPartLength, lastPartLength);
                tempList.Add(lastPart);
                list.RemoveAt(index);
                for (int i = tempList.Count - 1; i >= 0; i--)
                {
                    list.Insert(index, tempList[i]);
                }
            }

            return list;
        }

        private static List<string> MergeElements(List<string> list, int startIndex, int endIndex)
        {
            if (startIndex >= 0 && endIndex < list.Count)
            {
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                list[startIndex] += list[i];
            }
            list.RemoveRange(startIndex + 1, endIndex - startIndex);
            }
            else if (startIndex >= 0 && startIndex < list.Count && endIndex >= list.Count)
            {
                endIndex = list.Count - 1;
                for (int i = startIndex + 1; i <= endIndex; i++)
                {
                    list[startIndex] += list[i];
                }
                list.RemoveRange(startIndex + 1, endIndex - startIndex);
            }    
            else if (startIndex < 0 && endIndex < list.Count)
            {
                startIndex = 0;
                for (int i = startIndex + 1; i <= endIndex; i++)
                {
                    list[startIndex] += list[i];
                }
                list.RemoveRange(startIndex + 1, endIndex);
            }

            return list;
        }
    }
}
