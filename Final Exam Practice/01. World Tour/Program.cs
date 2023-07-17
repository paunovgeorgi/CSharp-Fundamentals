string travelInput = Console.ReadLine();
string input;
while ((input = Console.ReadLine())!= "Travel")
{
    string[] arguments = input.Split(':');
    string command = arguments[0];
    switch (command)
    {
        case "Add Stop":
            travelInput = AddDestination(arguments, travelInput);
            break;
        case "Remove Stop":
            travelInput = RemoveDestination(arguments, travelInput);
            break;
        case "Switch":
            travelInput = SwitchDestination(arguments, travelInput);
            break;
    }
}
Console.WriteLine($"Ready for world tour! Planned stops: {travelInput}");
string RemoveDestination(string[] strings, string? s)
{
    int startIndex = int.Parse(strings[1]);
    int endIndex = int.Parse(strings[2]);
    if (startIndex >= 0 && endIndex < s.Length)
    {
        s = s.Remove(startIndex, endIndex - startIndex + 1);
    }

    Console.WriteLine(s);
    return s;
}
string SwitchDestination(string[] arguments1, string? travelInput1)
{
    string oldString = arguments1[1];
    string newString = arguments1[2];
    if (travelInput1.Contains(oldString))
    {
        travelInput1 = travelInput1.Replace(oldString, newString);
    }

    Console.WriteLine(travelInput1);
    return travelInput1;
}
string AddDestination(string[] strings1, string? s1)
{
    int index = int.Parse(strings1[1]);
    string text = strings1[2];
    if (index >= 0 && index < s1.Length)
    {
        s1 = s1.Insert(index, text);
    }

    Console.WriteLine(s1);
    return s1;
}