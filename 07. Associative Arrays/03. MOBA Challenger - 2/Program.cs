using System.Security.Cryptography.X509Certificates;

string input;
var moba = new Dictionary<string, Player>();
while ((input = Console.ReadLine()) != "Season end")
{
    string[] commands = input.Split(" -> ");
    if (commands.Length == 3)
    {
        string playerOne = commands[0];
        string position = commands[1];
        int skill = int.Parse(commands[2]);

        if (!moba.ContainsKey(playerOne))
        {
            Position currentPosition = new Position(position, skill);
            Player currentPlayer = new Player(playerOne, currentPosition);
            moba.Add(currentPlayer.PlayerName, currentPlayer);
        }
        else
        {
            if (moba[playerOne].Position.PositionName.Contains(position))
            {
                moba[playerOne].Position.Update(skill);
            }
            else
            {
                Position currentPosition = new Position(position, skill);
                moba[playerOne].Position = currentPosition;
            }



        }
    }
    else
    {
        string playerOne = commands[0];
        string playerTwo = commands[1];
    }
    //switch (commands.Length)
    //{
    //    case 3:
    //        string player = commands[0];
    //        string position = commands[1];
    //        int skill = int.Parse(commands[2]);
    //        break;
    //    case 2:
    //        string playerOne = commands[0];
    //        string playerTwo = commands[1];
    //        break;
    //}






}
public class Player
{
    public Player(string playerName, Position position)
    {
        PlayerName = playerName;
        Position = position;
    }


    public string PlayerName { get; set; }
    public Position Position { get; set; }

    public void Update(string position, int skill)
    {

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

    public void Update(int skill)
    {
        if (skill > Skill)
        {
            Skill = skill;
        }
    }
}


