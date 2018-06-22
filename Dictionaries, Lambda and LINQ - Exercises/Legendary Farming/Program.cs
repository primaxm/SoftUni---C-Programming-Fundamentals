using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string, int> goods = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();

            goods.Add("shards", 0);
            goods.Add("fragments", 0);
            goods.Add("motes", 0);
            bool stop = false;
            string prize = "";

            while (stop == false)
            {
                for (int a = 1; a < items.Length; a += 2)
                {
                    items[a] = items[a].ToLower();
                    if (items[a] == "shards" || items[a] == "fragments" || items[a] == "motes")
                    {
                        goods[items[a]] += int.Parse(items[a - 1]);

                        if (goods[items[a]] >= 250)
                        {
                            switch (items[a])
                            {
                                case "shards":
                                    prize = "Shadowmourne";
                                    break;
                                case "fragments":
                                    prize = "Valanyr";
                                    break;
                                case "motes":
                                    prize = "Dragonwrath";
                                    break;
                            }


                            goods[items[a]] -= 250;
                            stop = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(items[a]))
                        {
                            junk.Add(items[a], int.Parse(items[a - 1]));
                        }
                        else
                        {
                            junk[items[a]] += int.Parse(items[a - 1]);
                        }
                    }
                }

                if (stop)
                {
                    Console.WriteLine($"{prize} obtained!");
                    foreach (var goodsPair in goods.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
                    {
                        Console.WriteLine($"{goodsPair.Key}: {goodsPair.Value}");
                    }
                    foreach (var junkPair in junk.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"{junkPair.Key}: {junkPair.Value}");
                    }
                }
                else
                {
                    items = Console.ReadLine().Split(' ').ToArray();
                } 
            }
        }
    }
}
