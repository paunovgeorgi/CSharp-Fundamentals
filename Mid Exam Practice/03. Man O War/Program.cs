using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace _03._Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine()
                .Split('>')
                .Select(int.Parse)
                .ToList();
            List<int> warship = Console.ReadLine()
                .Split('>')
                .Select(int.Parse)
                .ToList();
            int maxHealth = int.Parse(Console.ReadLine());
            double minimumHp = maxHealth * 0.2;
            bool programEnd = false;
            string commands;
            while ((commands = Console.ReadLine()) != "Retire")
            {
                string[] action = commands.Split();

                switch (action[0])
                {
                    case "Fire":
                        int index = int.Parse(action[1]);
                        int damage = int.Parse(action[2]);
                        warship = PirateAttack(warship, index, damage, ref programEnd);
                        break;
                    case "Defend":
                        int startIndex = int.Parse(action[1]);
                        int endIndex = int.Parse(action[2]);
                        int warDamage = int.Parse(action[3]);

                        pirateShip = WarshipAttack(pirateShip, startIndex, endIndex, warDamage, ref programEnd); 
                        break;
                    case "Repair":
                        int repairIndex = int.Parse(action[1]);
                        int health = int.Parse(action[2]);
                        pirateShip = RepairShip(pirateShip, repairIndex, health, maxHealth);
                        break;
                    case "Status":
                        ShipStatus(pirateShip, minimumHp);
                        break;
                }
                if (programEnd)
                {
                    return;
                }
            }
            if (commands == "Retire")
            {
                int pirateSum = 0;
                int warSum = 0;
                foreach (int section in pirateShip)
                {
                    pirateSum += section;
                }
                foreach (int section in warship)
                {
                    warSum += section;
                }
                Console.WriteLine($"Pirate ship status: {pirateSum}");
                Console.WriteLine($"Warship status: {warSum}");
            }
        }
        private static void ShipStatus(List<int> pirateShip, double minimumHp)
        {
            int count = 0;
            for (int i = 0; i < pirateShip.Count; i++)
            {
                if (pirateShip[i] < minimumHp)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} sections need repair.");
        }
        private static List<int> RepairShip(List<int> pirateShip, int repairIndex, int health, int maxHealth)
        {
            if (repairIndex >= 0 && repairIndex < pirateShip.Count)
            {
                if (pirateShip[repairIndex] + health > maxHealth)
                {
                    health = maxHealth - pirateShip[repairIndex];
                }
                pirateShip[repairIndex] += health;
            }
            return pirateShip;
        }
        private static List<int> WarshipAttack(List<int> pirateShip, int startIndex, int endIndex, int warDamage,
            ref bool programEnd)
        {
            if (startIndex >= 0 && startIndex < pirateShip.Count && endIndex >= 0 && endIndex < pirateShip.Count)
            {
                
            for (int i = startIndex; i <= endIndex; i++)
            {
                pirateShip[i] -= warDamage;
                if (pirateShip[i] <= 0)
                {
                    Console.WriteLine("You lost! The pirate ship has sunken.");
                    programEnd = true;
                    break;
                }
            }
            }
            return pirateShip;
        }
        private static List<int> PirateAttack(List<int> warship, int index, int damage, ref bool programEnd)
        {
            if (index >= 0 && index < warship.Count)
            {
                warship[index] -= damage;
            if (warship[index] <= 0)
            {
                Console.WriteLine("You won! The enemy ship has sunken.");
                programEnd = true;
            }
            }
            return warship;
        }
    }
}
