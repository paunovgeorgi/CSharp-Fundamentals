int number = int.Parse(Console.ReadLine());
string message = "";
for (int i = 1; i <= number; i++)
{
    int inputNum = int.Parse(Console.ReadLine());
    switch (inputNum)
    {
        case 2: message += "a"; break;
        case 22: message += "b"; break;
        case 222: message += "c"; break;
    }
}
Console.WriteLine(message);

