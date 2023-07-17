using System.Net;

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
        case "Contains":
            ContainsNumber(numbers, commandArray[1]);
            break;
        case "PrintEven":
            PrintAllEvenNumbers(numbers);
            break;
        case "PrintOdd":
            PrintAllOddNumbers(numbers);
            break;
        case "GetSum":
            SumOfAllNumbers(numbers);
            break;
        case "Filter":
            FilterNumbersBasedOnCondition(numbers, commandArray[1], commandArray[2]);
            break;
    }
}

Console.WriteLine(string.Join(" ", numbers));


static void ContainsNumber(List<int> list, string number)
{

    if (list.Contains(int.Parse(number)))
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No such number");
    }

}

static void PrintAllEvenNumbers(List<int> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] % 2 == 0)
        {
            Console.Write($"{list[i]} ");
        }
    }
}

static void PrintAllOddNumbers(List<int> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] % 2 != 0)
        {
            Console.Write(list[i] + " ");
        }
    }
}

static void SumOfAllNumbers(List<int> list)
{
    int sum = 0;
    for (int i = 0; i < list.Count; i++)
    {
        sum += list[i];
    }

    Console.WriteLine(sum);
}


static void FilterNumbersBasedOnCondition(List<int> list, string condition, string number)
{
    for (int i = 0; i < list.Count; i++)
    {
        switch (condition)
        {
            case "<":
                if (list[i] < int.Parse(number))
                {
                    Console.Write(list[i] + " ");
                }
                break;
            case "<=":
                if (list[i] <= int.Parse(number))
                {
                    Console.Write(list[i] + " ");
                }
                break;
            case ">":
                if (list[i] > int.Parse(number))
                {
                    Console.Write(list[i] + " ");
                }
                break;
            case ">=":
                if (list[i] >= int.Parse(number))
                {
                    Console.Write(list[i] + " ");
                }
                break;
        }

    }
}

