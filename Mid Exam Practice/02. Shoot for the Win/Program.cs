using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string command;
            int shots = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                int indexToshoot = int.Parse(command);
                ShootingTargets(targets, indexToshoot, ref shots);
            }
            Console.Write($"Shot targets: {shots} -> ");
            Console.Write(string.Join(" ", targets));
        }
        private static int[] ShootingTargets(int[] targets, int indexToshoot,ref int shots)
        {
           
            for (int i = 0; i < targets.Length; i++)
            {
                if (indexToshoot == i)
                {
                    shots++;
                    int targetValue = targets[i];
                    targets[i] = -1;
                    for (int j = 0; j < targets.Length; j++)
                    {
                        if (targets[j] != -1)
                        {
                            if (targets[j] > targetValue)
                            {
                                targets[j] -= targetValue;
                            }
                            else if (targets[j] <= targetValue)
                            {
                                targets[j] += targetValue;
                            }
                        }
                    }
                }
            }
            return targets;
        }
    }
}
