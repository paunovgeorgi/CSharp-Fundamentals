using System.Text.RegularExpressions;
string input = Console.ReadLine();
string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
//Regex regex = new Regex(pattern);

MatchCollection match = Regex.Matches(input, pattern);
Console.WriteLine(string.Join(" ", match));

//int length = input.Length < pattern.Length ? input.Length : pattern.Length;