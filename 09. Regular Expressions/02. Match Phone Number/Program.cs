using System.Text.RegularExpressions;

string input = Console.ReadLine();
string regex = @"\s?\+359( |-)2\1\d{3}\1\d{4}\b";
MatchCollection collection = Regex.Matches(input, regex);

Console.WriteLine(string.Join(", ", collection));