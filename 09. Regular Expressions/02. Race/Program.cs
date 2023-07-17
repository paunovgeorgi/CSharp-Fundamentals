using System.Text.RegularExpressions;
string[] input = Console.ReadLine().Split(", ");
var list = new Dictionary<string, double>();
foreach (var person in input)
{
    list.Add(person, 0);
}
string info;
while ((info = Console.ReadLine()) != "end of race")
{
    string currentRacer = Regex.Replace(info, "[^a-zA-Z]", "");
    string currentDistance = Regex.Replace(info, "[^0-9]", "");
    //var stringname = matches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
    if (list.ContainsKey(currentRacer))
    {
        int km = 0;
        foreach (char c in currentDistance)
        {
            km += int.Parse(c.ToString());
        }
        list[currentRacer] += km;
    }
}
int position = 1;
foreach (var racer in list.OrderByDescending(x=>x.Value))
{
    if (position == 1)
    {
        Console.WriteLine($"1st place: {racer.Key}");
    }
    else if (position == 2)
    {
        Console.WriteLine($"2nd place: {racer.Key}");
    }
    else
    {
        Console.WriteLine($"3rd place: {racer.Key}");
        break;
    }
    position++;
}

