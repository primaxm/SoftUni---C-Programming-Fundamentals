using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teamList = new List<Team>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] t = Console.ReadLine().Split('-').ToArray();

                if (teamList.Any(x => x.TeamName == t[1]))
                {
                    Console.WriteLine($"Team {t[1]} was already created!");
                }
                else
                {
                    if (teamList.Any(x => x.Creator == t[0]))
                    {
                        Console.WriteLine($"{t[0]} cannot create another team!");
                    }
                    else
                    {
                        Team team = new Team(t[0], t[1], new List<string>());
                        teamList.Add(team);
                        Console.WriteLine($"Team {t[1]} has been created by {t[0]}!");
                    }
                }

            }

            string input = Console.ReadLine();
            while (input != "end of assignment")
            {
                string[] mem = input.Split(new char[] {'-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!teamList.Any(x => x.TeamName == mem[1]))
                {
                    Console.WriteLine($"Team {mem[1]} does not exist!");
                }
                else
                {
                    if (teamList.Any(x => x.Members.Contains(mem[0])) || teamList.Any(x => x.Creator == mem[0]))
                    {
                        Console.WriteLine($"Member {mem[0]} cannot join team {mem[1]}!");
                    }
                    else
                    {
                        foreach (var item in teamList.Where(x => x.TeamName == mem[1]))
                        {
                            item.Members.Add(mem[0]);
                        }
                    }
                }

                input = Console.ReadLine();
            }


            foreach (var item in teamList.Where(x => x.Members.Count > 0).OrderByDescending(x => x.Members.Count).ThenBy(y => y.TeamName))
            {

                    Console.WriteLine(item.TeamName);
                Console.WriteLine($"- {item.Creator}");
                    foreach (var members in item.Members.OrderBy(x => x))
                    {
                        Console.WriteLine($"-- {members}");
                    }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var item in teamList.Where(x => x.Members.Count == 0).OrderBy(x => x.TeamName))
            {
                    Console.WriteLine($"{item.TeamName}");
            }
        }
    }

    class Team
    {
        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }

        public Team(string creator, string name, List<string> mem)
        {
            Creator = creator;
            TeamName = name;
            Members = mem;
        }
    }
}
