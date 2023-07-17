using System.Security.Cryptography.X509Certificates;
string input;
var moba = new Dictionary<string, List<Position>>();
var totalSkillPoints = new Dictionary<string, int>();
while ((input = Console.ReadLine())!= "Season end")
{
    int index = input.IndexOf(">");
    if (index >= 0)
    {
        string[] commands = input.Split(" -> ");
        string playerOne = commands[0];
        string position = commands[1];
        int skill = int.Parse(commands[2]);
        if (!moba.ContainsKey(playerOne))
        {
            Position currentPosition = new Position(position, skill);
            moba.Add(playerOne, new List<Position>());
            moba[playerOne].Add(currentPosition);
            totalSkillPoints.Add(playerOne, skill);
        }
        else
        {
            Position currentPosition = new Position(position, skill);
            Position positionToUpdate = moba[playerOne].Find(x => x.PositionName == position);
            if (positionToUpdate != null)
            {
                if (skill > positionToUpdate.Skill)
                {
                    int additionalSkill = skill - positionToUpdate.Skill;
                    positionToUpdate.Skill = skill;
                    totalSkillPoints[playerOne] += additionalSkill;
                }
            }
            else
            {
                moba[playerOne].Add(currentPosition);
                totalSkillPoints[playerOne] += skill;

            }
        }
    }
    else
    {
        string[] commands = input.Split();
        string playerOne = commands[0];
        string playerTwo = commands[2];
        if (moba.ContainsKey(playerOne) && moba.ContainsKey(playerTwo))
        {
            bool thereIsAMatch = false;
            foreach (var item in moba[playerOne])
            {
                foreach (var item2 in moba[playerTwo])
                {
                    if (item.PositionName == item2.PositionName)
                    {
                        thereIsAMatch = true;
                        break;
                    }
                }
            }
            if (thereIsAMatch)
            {
                if (totalSkillPoints[playerOne] > totalSkillPoints[playerTwo])
                {
                    moba.Remove(playerTwo);
                    totalSkillPoints.Remove(playerTwo);
                }
                else if (totalSkillPoints[playerOne] < totalSkillPoints[playerTwo])
                {
                    moba.Remove(playerOne);
                    totalSkillPoints.Remove(playerOne);
                }
            }
        }
    }
}
foreach (var player in totalSkillPoints.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
{
    Console.WriteLine($"{player.Key}: {player.Value} skill");
    foreach (var pos in moba[player.Key].OrderByDescending(x=>x.Skill).ThenBy(x=>x.PositionName))
    {
        Console.WriteLine($"- {pos.PositionName} <::> {pos.Skill}");
    }
}

public class Position
{
    public Position(string name, int skill)
    {
        PositionName = name;
        Skill = skill;
    }

    public string PositionName { get; set; }
    public int Skill { get; set; }
}
