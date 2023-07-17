var contest = new Dictionary<string, List<Contestant>>();
var topUser = new Dictionary<string, int>();
string input;
while ((input = Console.ReadLine())!= "no more time")
{
    string[] info = input.Split(" -> ");
    string username = info[0];
    string contestName = info[1];
    int points = int.Parse(info[2]);
    if (!contest.ContainsKey(contestName))
    {
        contest.Add(contestName, new List<Contestant>());
        contest[contestName].Add(new Contestant(username, points));
        if (!topUser.ContainsKey(username))
        {
        topUser.Add(username, points);
        }
        else
        {
            topUser[username] += points;
        }
    }
    else
    {
        Contestant currentContestant = contest[contestName].Find(x => x.Username == username);
        if (currentContestant != null)
        {
            if (currentContestant.Points < points)
            {
                int additionalPoints = points - currentContestant.Points;
                currentContestant.Points = points;
                topUser[username] += additionalPoints;
            }
        }
        else
        {
            contest[contestName].Add(new Contestant(username, points));
            if (!topUser.ContainsKey(username))
            {
                topUser.Add(username, points);
            }
            else
            {
                topUser[username] += points;
            }
        }
    }

    {
    }
}

foreach (var contestt in contest)
{
    Console.WriteLine($"{contestt.Key}: {contestt.Value.Count} participants");
        int position = 1;
    foreach (var member in contestt.Value.OrderByDescending(x=>x.Points).ThenBy(x=>x.Username))
    {
        Console.WriteLine($"{position}. {member.Username} <::> {member.Points}");
        position++;
    }
}
Console.WriteLine("Individual standings:");
int totalPosition = 1;

foreach (var user in topUser.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{totalPosition}. {user.Key} -> {user.Value}");
    totalPosition++;
}

public class Contestant
{
    public Contestant(string username, int points)
    {
        Username = username;
        Points = points;
    }

    public string Username { get; set; }
    public int Points { get; set; }
}