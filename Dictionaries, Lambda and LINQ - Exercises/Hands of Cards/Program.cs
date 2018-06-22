using System;
using System.Collections.Generic;
using System.Linq;

namespace Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            string [] input = Console.ReadLine().Split(new string [] { ": ", ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0] != "JOKER")
            {
                Dictionary<string, int> cards = new Dictionary<string, int>();
                Dictionary<string, int> cardsPower = new Dictionary<string, int>()
                {  ["2"] = 2,
                    ["3"] = 3,
                    ["4"] = 4,
                    ["5"] = 5,
                    ["6"] = 6,
                    ["7"] = 7,
                    ["8"] = 8,
                    ["9"] = 9,
                    ["1"] = 10,
                    ["J"] = 11,
                    ["Q"] = 12,
                    ["K"] = 13,
                    ["A"] = 14,
                };
                Dictionary<string, int> cardsTypes = new Dictionary<string, int>()
                {
                    ["S"] = 4,
                    ["H"] = 3,
                    ["D"] = 2,
                    ["C"] = 1,
                };


                for (int i = 1; i < input.Length; i++)
                {
                    if (!cards.ContainsKey(input[i]))
                    {
                        cards.Add(input[i], cardsPower[input[i].First().ToString()] * cardsTypes[input[i].Last().ToString()]);
                    }
                }
                
                if (!players.ContainsKey(input[0]))
                {
                    players.Add(input[0], cards);
                }
                else
                {
                    foreach (var item in players[input[0]])
                    {
                        if (!cards.ContainsKey(item.Key))
                        {
                            cards.Add(item.Key, item.Value);
                        }
                    }
                    players[input[0]] = cards;
                }
                
                input = Console.ReadLine().Split(new string[] { ": ", ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            foreach (var item in players)
            {
                int sum = 0;
                foreach (var pair in item.Value)
                {
                    sum += pair.Value;
                }
                Console.WriteLine(item.Key + ": " + sum);
            }

        }

    }
}
