
using System.Collections.Generic;
using System.Security.Cryptography;

List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string operations = "";

while ((operations = Console.ReadLine()) != "End")
{
    string[] commands = operations.Split();

    switch (commands[0])
    {
        case "Add":
            numbers.Add(int.Parse(commands[1]));
            break;
        case "Insert":
            if (int.Parse(commands[2]) < 0 || int.Parse(commands[2]) >= numbers.Count)
            {
                Console.WriteLine("Invalid index");
                break;
            }
            numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
            break;
        case "Remove":
            if (int.Parse(commands[1]) < 0 || int.Parse(commands[1]) >= numbers.Count)
            {
                Console.WriteLine("Invalid index");
                break;
            }
            numbers.RemoveAt(int.Parse(commands[1]));
            break;
        case "Shift":
            switch (commands[1])
            {
                case "left":
                    ShiftLeft(commands, numbers);
                    break;
                case "right":
                   ShiftRight(commands, numbers);
                    break;
            }

            break;
    }
}

Console.WriteLine(string.Join(" ", numbers));


void ShiftRight(string[] command, List<int> list)
{
    for (int i = 0; i < int.Parse(command[2]); i++)
    {
        int temp = list[list.Count - 1];
        list.Insert(0, temp);
        list.RemoveAt(list.Count - 1);
    }
}

void ShiftLeft(string[] command, List<int> list)
{
    for (int i = 0; i < int.Parse(command[2]); i++)
    {
        int temp = list[0];
        list.Add(temp);
        list.RemoveAt(0);
    }
}

