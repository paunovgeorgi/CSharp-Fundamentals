using System.Text;
using System.Text.RegularExpressions;
int key = int.Parse(Console.ReadLine());
string pattern = @"@([A-Za-z]+)[^@\-!:>]*!([G|N])!";
var names = new StringBuilder();
string messages;
while ((messages = Console.ReadLine()) != "end")
{
    string decrypted = string.Empty;
    foreach (char c in messages)
    {
        decrypted += (char)(c - key);
    }
    if (Regex.IsMatch(decrypted, pattern) && Regex.Match(decrypted, pattern).Groups[2].Value == "G")
    {
        names.AppendLine(Regex.Match(decrypted, pattern).Groups[1].Value);
    }
}
Console.WriteLine(names);