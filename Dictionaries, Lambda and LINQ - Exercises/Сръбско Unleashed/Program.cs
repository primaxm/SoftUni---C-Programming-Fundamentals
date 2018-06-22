using System;
using System.Collections.Generic;
using System.Linq;

namespace Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> places = new Dictionary<string, Dictionary<string, int>>();
            string[] input = new string[2];
            string singer = "";
            int ticketPrice = 0;
            int ticketCount = 0;
            int totalIncome = 0;
            string venue = "";

            while (input[0] != "End")
            {
                input = Console.ReadLine().Split('@').ToArray();
                
                try
                {
                    List<string> tmp = input[1].Split(' ').ToList();
                    if (input[0].EndsWith(' ') == false)
                    {
                        continue;
                    }
                    singer = input[0];
                    ticketCount = int.Parse(tmp[tmp.Count-1]);
                    tmp.RemoveAt(tmp.Count - 1);
                    ticketPrice = int.Parse(tmp[tmp.Count - 1]);
                    tmp.RemoveAt(tmp.Count - 1);
                    totalIncome = ticketPrice * ticketCount;
                    venue = string.Join(" ", tmp);
                }
                catch (Exception)
                {
                    continue;
                }

                if (!places.ContainsKey(venue))
                {
                    Dictionary<string, int> tmps = new Dictionary<string, int>();
                    tmps.Add(singer, totalIncome);
                    places.Add(venue, tmps);
                }
                else
                {
                    if (!places[venue].ContainsKey(singer))
                    {
                        places[venue].Add(singer, totalIncome);
                    }
                    else
                    {
                        places[venue][singer] += totalIncome;
                    }
                }
            }
            
            foreach (var placesPair in places)
            {
                Console.WriteLine(placesPair.Key);
                foreach (var singerPair in placesPair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("#  " + singerPair.Key + "-> " + singerPair.Value);
                }
            }

        }
    }
}
