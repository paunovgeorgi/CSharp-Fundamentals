using System.Numerics;
using System.Text.RegularExpressions;
string input = Console.ReadLine();
string numbers = new string(input.Where(char.IsDigit).ToArray());
string pattern = @"(\:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";
List<string> theCoolOnes = new List<string>();
BigInteger coolThreshold = 1;
foreach (char num in numbers)
{
    coolThreshold *= int.Parse(num.ToString());
}
MatchCollection emojiCollection = Regex.Matches(input, pattern);
string emojis = string.Empty;
foreach (Match match in emojiCollection)
{
    int sum = 0;
    foreach (char c in match.Groups["emoji"].Value)
    {
        sum += (int)(c);
    }
    if (sum > coolThreshold)
    {
        theCoolOnes.Add(match.Value);
    }
}
Console.WriteLine($"Cool threshold: {coolThreshold}");
Console.WriteLine($"{emojiCollection.Count} emojis found in the text. The cool ones are:");
foreach (string emoji in theCoolOnes)
{
    Console.WriteLine(emoji);
}