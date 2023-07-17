List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string command = "";

while ((command = Console.ReadLine()) != "end")
{
    string[] commandArray = command.Split();

    switch (commandArray[0])
    {
        case "Delete":
            DeleteElement(numbers, int.Parse(commandArray[1]));
            break;
        case "Insert":
            InsertElement(numbers, int.Parse(commandArray[1]), int.Parse(commandArray[2]));
            break;
    }
}

Console.WriteLine(string.Join(" ", numbers));

static void DeleteElement(List<int> numbers, int element)
{
    numbers.RemoveAll(x => x == element);
}


static void InsertElement(List<int> numbers, int element, int position)
{
    numbers.Insert(position, element);
}