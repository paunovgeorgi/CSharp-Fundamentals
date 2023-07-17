using System.Text;
using System.Text.RegularExpressions;
string input;
string pattern = @">>(?<item>[A-Z]+|[A-Z][a-z]+)<<(?<price>\d+.\d+|\d+)!(?<quantity>\d+)\b";
Regex regex = new Regex(pattern);
var sb = new StringBuilder();
double totalPrice = 0;
while ((input = Console.ReadLine())!= "Purchase")
{
    if (regex.IsMatch((input)))
    {
        Match match = Regex.Match(input, pattern);
        string itemName = match.Groups["item"].Value;
        totalPrice += double.Parse(match.Groups["price"].Value) * double.Parse(match.Groups["quantity"].Value);
        sb.AppendLine(itemName);
    }
}
Console.WriteLine("Bought furniture:");
Console.Write(sb);
Console.WriteLine($"Total money spend: {totalPrice:f2}");