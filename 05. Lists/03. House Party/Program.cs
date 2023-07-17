using System.Collections.Generic;
using System.Xml.Linq;


int numOfCommands = int.Parse(Console.ReadLine());

List<string> guestList = new List<string>();

for (int i = 0; i < numOfCommands; i++)
{
    string[] command = Console.ReadLine().Split().ToArray();

    if (command.Length == 3)
    {
        IsGoing(command, guestList);
    }
    else
    {
        IsNotGoing(command, guestList);
    }

}

foreach (string name in guestList)
{
    Console.WriteLine(name);
}


void IsGoing(string[] command, List<string> list)
{
    if (!list.Contains(command[0]))
        {
            list.Add(command[0]);
        }
        else
        {
            Console.WriteLine($"{command[0]} is already in the list!");
        }
}
void IsNotGoing(string[] command, List<string> list)
{

    if (list.Contains(command[0]))
        {
            list.Remove(command[0]);
        }
        else
        {
            Console.WriteLine($"{command[0]} is not in the list!");
        }
}