using System.Text.RegularExpressions;
int n = int.Parse(Console.ReadLine());
List<string> attackedPlanets = new List<string>();
List<string> destroyedPlanets = new List<string>();
string pattern = @"[@](?<planet>[A-Z][a-z]+)[^@\-!:>]*[:](?<population>[\d]*)[^@\-!:>]*[!](?<attackOrDestruction>[A-Z])[!][^@\-!:>]*->(?<count>\d*)";
Regex regex = new Regex(pattern);
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string decrypted = Decrypt(input);
    AddToList(regex, decrypted, attackedPlanets, destroyedPlanets);
}
Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
if (attackedPlanets.Count > 0)
{
    foreach (string attackedPlanet in attackedPlanets.OrderBy(x=>x))
    {
        Console.WriteLine($"-> {attackedPlanet}");
    }
}
Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
if (destroyedPlanets.Count > 0)
{
    foreach (string planet in destroyedPlanets.OrderBy(x=>x))
    {
        Console.WriteLine($"-> {planet}");
    }
}
string Decrypt(string input)
{
    int count = 0;
    foreach (char c in input)
    {
        if (c == 's' | c == 't' | c == 'a' | c == 'r' | c == 'S' | c == 'T' | c == 'A' | c == 'R')
        {
            count++;
        }
    }
    string decrypted = string.Empty;
    foreach (char c in input)
    {
        decrypted += (char)(c - count);
    }
    return decrypted;
}
void AddToList(Regex regex1, string decryptedText, List<string> attacked, List<string> destroyed)
{
    if (regex1.IsMatch(decryptedText))
    {
        Match currentMatch = regex1.Match(decryptedText);
        switch (currentMatch.Groups["attackOrDestruction"].Value)
        {
            case "A":
                attacked.Add(currentMatch.Groups["planet"].Value);
                break;
            case "D":
                destroyed.Add(currentMatch.Groups["planet"].Value);
                break;
        }
    }
}