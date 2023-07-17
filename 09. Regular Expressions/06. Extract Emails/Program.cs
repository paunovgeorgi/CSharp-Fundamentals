using System.Text.RegularExpressions;

string input = Console.ReadLine();
string pattern = @" [a-z0-9]+[a-z0-9-_.]*[a-z0-9][@][a-z]+[a-z-.]+[a-z]+[.][a-z]+";
MatchCollection emails = Regex.Matches(input, pattern);
foreach (Match mail in emails)
{
    Console.WriteLine(mail);
}