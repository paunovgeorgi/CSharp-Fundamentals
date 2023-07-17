using System;
using System.Text.RegularExpressions;
string input = Console.ReadLine();
string pattern = @"\b(?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
MatchCollection dates = Regex.Matches(input, pattern);
foreach (Match date in dates)
{
    Console.WriteLine($"Day: {date.Groups["day"]}, Month: {date.Groups["month"]}, Year: {date.Groups["year"]}");
}