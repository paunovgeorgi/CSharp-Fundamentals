using System.Text.RegularExpressions;
string input = Console.ReadLine();
string pattern = @"(=|/)([A-Z][A-Za-z]{2,})\1";
MatchCollection collection = Regex.Matches(input, pattern);
List<string> destinations = new List<string>();
int travelPoints = 0;
foreach (Match destination in collection)
{
    travelPoints += destination.Groups[2].Length;
    destinations.Add(destination.Groups[2].Value);
}
Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
Console.WriteLine($"Travel Points: {travelPoints}");