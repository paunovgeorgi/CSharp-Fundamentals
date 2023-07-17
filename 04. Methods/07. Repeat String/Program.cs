string input = Console.ReadLine();
int repeatTimes = int.Parse(Console.ReadLine());
string result = Result(input, repeatTimes);
Console.WriteLine(result);
static string Result(string input, int repeat)
{
    string result = "";
    for (int i = 0; i < repeat; i++)
    {
        result += input;
    }

    return result;
}