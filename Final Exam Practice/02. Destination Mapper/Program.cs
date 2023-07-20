using System.Text.RegularExpressions;
string input = Console.ReadLine();
string pattern = @"(=|/)(?<destination>[A-Z][A-Za-z]{2,})\1";
MatchCollection destinations = Regex.Matches(input, pattern);
int travelPoints = 0;
foreach (Match place in destinations)
{
    travelPoints += place.Groups["destination"].Length;
}
Console.WriteLine($"Destinations: {string.Join(", ", destinations.Select(x => x.Groups["destination"]))}");
Console.WriteLine($"Travel Points: {travelPoints}");