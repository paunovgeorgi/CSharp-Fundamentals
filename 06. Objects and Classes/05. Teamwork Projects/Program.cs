

using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < numberOfTeams; i++)
            {
            string[] userAndTeam = Console.ReadLine().Split('-');
            string user = userAndTeam[0];
            string teamName = userAndTeam[1];
           
                if (teams.Select(x=>x.TeamName).Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Select(x=>x.Creator).Contains(user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                 continue;
                }

                Team team = new Team(user, teamName);
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {user}!");
                
            }
            
        string command;
            while ((command = Console.ReadLine())!= "end of assignment")
            {
            string[] usersToJoin = command.Split("->");
            string teamMember = usersToJoin[0];
            string nameOfTeam = usersToJoin[1];
            Team team = teams.FirstOrDefault(x => x.TeamName == nameOfTeam);
            Team sameTeam = teams.Find(x => x.Members.Contains(teamMember));
            if (team is null)
            {
                    Console.WriteLine($"Team {nameOfTeam} does not exist!");
                    continue;
            }
            if (sameTeam != null)
                {
                    Console.WriteLine($"Member {teamMember} cannot join team {nameOfTeam}!");
                    continue;
                }

            team.Members.Add(teamMember);
            }

            List<Team> orderedByMembersCount = teams.Where(x=>x.Members.Count != 0).OrderByDescending(x => x.Members.Count).ThenBy(x=>x.TeamName).ToList();
            List<Team> disbanedTeams = teams.Where(x => x.Members.Count == 0).OrderBy(x => x.TeamName).ToList();
            foreach (var team in orderedByMembersCount)
            {
                Console.WriteLine(team);
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in disbanedTeams)
            {
                Console.WriteLine(team.TeamName);
            }

            //foreach (var team in teams)
            //{
            //    Console.WriteLine(team.TeamName);
            //    Console.WriteLine($"- {team.Creator}");
            //    foreach (var member in team.Members)
            //    {
            //        Console.WriteLine($"-- {member}");
            //    }
            //}

        }
        
        }

        public class Team
        {
            public Team(string creator, string teamName)
            {
                Creator = creator;
                TeamName = teamName;
            }
            
            public string Creator { get; set; }
            public string TeamName { get; set; }

            public List<string> Members { get; set; } = new List<string>();

            public override string ToString()
            {
                Members.Sort();
                string result = "";
                result += TeamName + "\n";
                result += $"- {Creator}\n";
                foreach (var member in Members)
                {
                    result += $"-- {member}\n";
                }

                return result.Trim();
            }

            //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine(TeamName);
        //    sb.AppendLine($"- {Creator}");

        //    foreach (var player in Members)
        //    {
        //        sb.AppendLine($"-- {player}");
        //    }

        //    return sb.ToString().Trim('\n');
        //}
    }

       
    
}