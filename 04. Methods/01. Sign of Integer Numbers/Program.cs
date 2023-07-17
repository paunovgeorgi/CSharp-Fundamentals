static void DefineNumber(int number)
{

    if (number > 0)
    {
        Console.WriteLine($"The number {number} is positive.");
    }
    else if (number < 0)
    {
        Console.WriteLine($"The number {number} is negative.");
    }
    else
    {
        Console.WriteLine($"The number {number} is zero.");
    }
}
int number = int.Parse(Console.ReadLine());
DefineNumber(number * 24);