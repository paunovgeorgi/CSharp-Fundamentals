string input = Console.ReadLine();
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

Calculation(input, number1, number2);

static void Calculation(string command, int number1, int number2)
{
    if (command == "add")
    {
        Console.WriteLine(number1 + number2);
    }
    else if (command == "multiply")
    {
        Console.WriteLine(number1 * number2);
    }
    else if (command == "substract")
    {
        Console.WriteLine(number1 - number2);
    }
    else
    {
        Console.WriteLine(number1 / number2);
    }
}
