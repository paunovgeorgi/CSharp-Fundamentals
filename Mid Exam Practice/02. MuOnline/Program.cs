using System;
using System.Linq;

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int healthBar = 100;
            int bitcoins = 0;
            int roomCounter = 0;

            string[] dungeonRooms = Console.ReadLine()
                .Split('|')
                .ToArray();

            for (int i = 0; i < dungeonRooms.Length; i++)
            {
            string[] room = dungeonRooms[i].Split();

            switch (room[0])
            {
                    case "potion":
                        roomCounter++;
                        int healthPack = int.Parse(room[1]);
                        if (healthBar + healthPack > 100)
                        {
                            healthPack = 100 - healthBar;
                        }
                        healthBar += healthPack;
                        if (healthPack > 0)
                        {
                            Console.WriteLine($"You healed for {healthPack} hp.");
                        }
                        Console.WriteLine($"Current health: {healthBar} hp.");
                        break;
                    case "chest":
                        roomCounter++;
                        int bitcoinChest = int.Parse(room[1]);
                        bitcoins += bitcoinChest;
                        Console.WriteLine($"You found {bitcoinChest} bitcoins.");
                        break;
                    default:
                        roomCounter++;
                        string monster = room[0];
                        int monsterAttack = int.Parse(room[1]);
                        healthBar -= monsterAttack;
                        if (healthBar > 0)
                        {
                            Console.WriteLine($"You slayed {monster}.");
                        }
                        else
                        {
                                Console.WriteLine($"You died! Killed by {monster}.");
                                Console.WriteLine($"Best room: {roomCounter}");
                                return;
                        }
                        break;
            }
                
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {healthBar}");
        }
    }
}
