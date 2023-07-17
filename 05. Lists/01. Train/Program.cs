List<int> wagons = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

int maxPerWagon = int.Parse(Console.ReadLine());

string command = "";

while ((command = Console.ReadLine()) != "end")
{
    string[] commandArray = command.Split();

    switch (commandArray[0])
    {
        case "Add":
            wagons.Add(int.Parse(commandArray[1]));
            break;
        default:
            AddPassengersToWagon(wagons, int.Parse(commandArray[0]), maxPerWagon);
            break;

    }
}

Console.WriteLine(string.Join(" ", wagons));

static void AddPassengersToWagon(List<int> list, int number, int maxNumber)
{
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] + number <= maxNumber)
        {
            list[i] += number;
            break;
        }
    }
}