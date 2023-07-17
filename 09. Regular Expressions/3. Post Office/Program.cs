using System.Text.RegularExpressions;

List<string> uniques = new List<string>();
string[] input = Console.ReadLine().Split('|');
string firstPart = input[0];
string secondPart = input[1];
string thirdPart = input[2];


string firstPattern = @"([$|#|%|*|&])([A-Z]+)\1";
string secondPattern = @"(?<letter>[6|7|8|9][\d]):(?<length>(?:[0|1|]\d)|20)";

string letters = Regex.Match(firstPart, firstPattern).Groups[2].Value;
MatchCollection lengths = Regex.Matches(secondPart, secondPattern);
foreach (Match length in lengths)
{
    if (uniques.Contains(length.Value))
    {
        uniques.Add(length.Value);
    }
}

foreach (Match length in lengths)
{
    char currentChar = char.Parse(length.Groups[1].Value);
    if (currentChar == letters[0])
    {
        
    }
}

Console.WriteLine(letters[0]);
int test = letters[0];
Console.WriteLine(test);
