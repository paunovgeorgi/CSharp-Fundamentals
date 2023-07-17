using System.Text.RegularExpressions;
string input = Console.ReadLine();
string pattern = @"(@|#)(?<normal>[A-Za-z]{3,})\1\1(?<reversed>[A-Za-z]{3,})\1";
MatchCollection collection = Regex.Matches(input, pattern);
List<string> pairCollection = new List<string>();
int pairs = collection.Count;
string matchingPairs = string.Empty;
foreach (Match pair in collection)
{
    string reversed = string.Concat(pair.Groups["normal"].Value.Reverse());
    if (reversed == pair.Groups["reversed"].Value)
    {
        matchingPairs = $"{pair.Groups["normal"]} <=> {pair.Groups["reversed"]}";
        pairCollection.Add(matchingPairs);
    }
}
if (pairs == 0)
{

    Console.WriteLine("No word pairs found!");
}
else
{
    Console.WriteLine($"{pairs} word pairs found!");
}
if (pairCollection.Count > 0)
{
    Console.WriteLine("The mirror words are:");
    Console.Write(string.Join(", ", pairCollection));
}
else
{
    Console.WriteLine("No mirror words!");
}