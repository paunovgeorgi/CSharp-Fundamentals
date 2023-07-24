using System;
using System.Text.RegularExpressions;
string input = Console.ReadLine();
List<string> mirrorWords = new List<string>();
string pattern = @"(@|#)(?<firstWord>[A-Za-z]{3,})\1{2}(?<secondWord>[A-Za-z]{3,})\1";
MatchCollection matches = Regex.Matches(input, pattern);
foreach (Match pair in matches)
{
    string reversed = string.Concat(pair.Groups["secondWord"].Value.Reverse());
    if (pair.Groups["firstWord"].Value == reversed)
    {
        string mirrorMatch = $"{pair.Groups["firstWord"].Value} <=> {pair.Groups["secondWord"].Value}";
        mirrorWords.Add(mirrorMatch);
    }
}
if (matches.Count == 0)
{
    Console.WriteLine("No word pairs found!");
}
else
{
    Console.WriteLine($"{matches.Count} word pairs found!");
}
if (mirrorWords.Count == 0)
{
    Console.WriteLine("No mirror words!");
}
else
{
    Console.WriteLine("The mirror words are:");
    Console.WriteLine(string.Join(", ", mirrorWords));
}
