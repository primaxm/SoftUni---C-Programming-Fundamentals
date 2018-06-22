using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Tseam_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] startGameNames = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> playGames = new List<string>();

            foreach (var item in startGameNames)
            {
                playGames.Add(item);
            }

            string inputCommand = Console.ReadLine();

            while (inputCommand != "Play!")
            {
                string[] command = inputCommand.Split(' ');


                switch (command[0])
                {
                    case "Install":
                        if (!playGames.Contains(command[1])) {
                            playGames.Add(command[1]);
                        }
                        break;
                    case "Uninstall":
                        if (playGames.Contains(command[1]))
                        {
                            playGames.Remove(command[1]);
                        }
                        break;
                    case "Update":
                        if (playGames.Contains(command[1]))
                        {
                            playGames.Remove(command[1]);
                            playGames.Add(command[1]);
                        }
                        break;
                    case "Expansion":
                        string expansion = Regex.Replace(command[1], "-", ":");
                        string[] exp = command[1].Split('-');
                        if (playGames.Contains(exp[0]))
                        {
                            int index = playGames.IndexOf(exp[0]);
                            playGames.Insert(index+1, expansion);
                        }

                        break;
                    default:
                        break;
                }

                inputCommand = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", playGames));

        }
    }
}