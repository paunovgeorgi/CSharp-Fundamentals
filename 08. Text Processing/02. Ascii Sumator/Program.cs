char firstChar = char.Parse(Console.ReadLine());
char secondChar = char.Parse(Console.ReadLine());
string text = Console.ReadLine();
int sum = 0;
foreach (char c in text)
{
    if (c > firstChar && c < secondChar )
    {
        sum += (int)c;
    }
}
Console.WriteLine(sum);