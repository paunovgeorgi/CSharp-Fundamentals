var contests = new Dictionary<string, string>();
var submissions = new Dictionary<string, int>();
string initialInput;
while ((initialInput = Console.ReadLine())!= "end of contests")
{
    string[] input = initialInput.Split(':');
    string contestName = input[0];
    string contestPassword = input[1];
    contests.Add(contestName, contestPassword);
}

var finalRegister = new Dictionary<string, List<Candidate>>();

string secondInput;

while ((secondInput = Console.ReadLine()) != "end of submissions")
{
    string[] subInfo = secondInput.Split("=>");
    string contestName = subInfo[0];
    string contestPass = subInfo[1];
    string username = subInfo[2];
    int points = int.Parse(subInfo[3]);

    if (contests.ContainsKey(contestName) && contests[contestName] == contestPass)
    {
        if (!submissions.ContainsKey(username))
        {
            submissions.Add(username, points);
        }
        else
        {
            submissions[username] += points;
        }

        if (!finalRegister.ContainsKey(username))
        {
            finalRegister.Add(username, new List<Candidate>());
        }

        finalRegister[username].Add(new Candidate(contestName, points));


        Candidate currentCnadidate = finalRegister[username].Find(x => x.ContestName == contestName);

        currentCnadidate.Score = points;

        // ************** if (finalRegister[username].ContestName == contestName) *************

    }
}

public class Candidate
{
    public Candidate(string name, int score)
    {
        ContestName = name;
        Score = score;
    }

    public string ContestName { get; set; }
    public int Score { get; set; }
    
}

public class Contest
{
    public string Name { get; set; }
    public string Password { get; set; }
}