using System.Diagnostics;
using System.Text.RegularExpressions;
string input;
string pattern = @"[%](?<name>[A-Z][a-z]+)[%].*[<](?<product>\w+)[>].*[|](?<count>\d+)[|].*?(?<price>\d+.\d+|\d+)[$]";
Regex regex = new Regex(pattern);
double totalAmount = 0;
while ((input = Console.ReadLine()) !="end of shift")
{
    if (regex.IsMatch((input)))
    {
        Match match = Regex.Match(input, pattern);
        string name = match.Groups["name"].Value;
        string product = match.Groups["product"].Value;
        int count = int.Parse(match.Groups["count"].Value);
        double price = double.Parse(match.Groups["price"].Value);
        totalAmount += price * count;
        Console.WriteLine($"{name}: {product} - {count * price:f2}");
    }
}
Console.WriteLine($"Total income: {totalAmount:f2}");