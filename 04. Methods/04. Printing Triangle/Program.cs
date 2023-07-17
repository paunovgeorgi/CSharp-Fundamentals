Console.Write("Input number of symbols: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Input symbol: ");
string symbol = Console.ReadLine();

Triangle(number, symbol);

static void Triangle(int number, string symbol)
{

    for (int row = 1; row <= number; row++)
    {
        for (int col = 1; col <= row; col++)
        {
            Console.Write(symbol + " ");
        }

        Console.WriteLine();
    }

    for (int row = number - 1; row >= 1; row--)
    {
        for (int col = 1; col <= row; col++)
        {
            Console.Write(symbol + " ");
        }

        Console.WriteLine();
    }
}
