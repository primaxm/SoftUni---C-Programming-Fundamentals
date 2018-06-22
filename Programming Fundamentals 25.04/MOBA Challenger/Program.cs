using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();


            while (input != "Season end")
            {
                bool commandType = input.Contains("->");
                if (commandType)
                {
                    string[] data = input.Split(new string[] { " -> " }, StringSplitOptions.None);
                    string playerName = data[0];
                    string playerPosition = data[1];
                    int playerPositionSkill = int.Parse(data[2]);

                    if (players.ContainsKey(playerName))
                    {
                        if (players[playerName].ContainsKey(playerPosition))
                        {
                            if (players[playerName][playerPosition] < playerPositionSkill)
                            {
                                players[playerName][playerPosition] = playerPositionSkill;
                            }
                        }
                        else
                        {
                            players[playerName].Add(playerPosition, playerPositionSkill);
                        }
                    }
                    else
                    {
                        Dictionary<string, int> tmp = new Dictionary<string, int>();
                        tmp.Add(playerPosition, playerPositionSkill);
                        players.Add(playerName, tmp);
                    }
                }
                else
                {
                    string[] data = input.Split(new string[] { " vs " }, StringSplitOptions.None);
                    string firtstPlayerName = data[0];
                    string secondPlayerName = data[1];
                    if (players.ContainsKey(firtstPlayerName) && players.ContainsKey(secondPlayerName))
                    {
                        int totalSkillFirstPlayer = 0;
                        int totalSkillSecoindPlayer = 0;
                        bool hasMatch = false;
                        foreach (var positionOne in players[firtstPlayerName])
                        {
                            if (players[secondPlayerName].ContainsKey(positionOne.Key))
                            {
                                hasMatch = true;
                            }
                            totalSkillFirstPlayer += positionOne.Value;
                        }
                        if (hasMatch)
                        {
                            foreach (var positionTwo in players[secondPlayerName])
                            {
                                totalSkillSecoindPlayer += positionTwo.Value;
                            }

                            if (totalSkillFirstPlayer > totalSkillSecoindPlayer)
                            {
                                players.Remove(secondPlayerName);
                            }
                            else if (totalSkillFirstPlayer < totalSkillSecoindPlayer)
                            {
                                players.Remove(firtstPlayerName);
                            }
                        }
                    }
                }


                input = Console.ReadLine();
            }

            foreach (var positionSkillPair in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{positionSkillPair.Key}: {positionSkillPair.Value.Values.Sum()} skill");
                foreach (var item in positionSkillPair.Value.OrderByDescending(x=>x.Value).ThenBy(y => y.Key))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }
            }
        }
    }
}
