using System;
using System.Collections.Generic;
using System.Linq;

namespace Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string ip = input[0];
                string user = input[1];
                int value = int.Parse(input[2]);
                Dictionary<string, int> tmp = new Dictionary<string, int>();

                if (!users.ContainsKey(user))
                {
                    tmp.Add(ip, value);
                    users.Add(user, tmp);  
                }
                else
                {
                    if (!users[user].ContainsKey(ip))
                    {
                        tmp.Add(ip, value);
                        users[user].Add(ip, value);
                    }
                    else
                    {
                        users[user][ip] += value;
                    }
                }
                /*foreach (var usersPair in users)
                {
                    Console.WriteLine(usersPair.Key);
                    foreach (var ipPair in usersPair.Value)
                    {
                        Console.WriteLine(ipPair.Key + "=>"+ ipPair.Value);
                    }
                    Console.WriteLine();
                }*/
            }

            foreach (var usersPair in users.OrderBy(x=>x.Key))
            {
                List<string> ipvs = new List<string>();
                
                foreach (var ipPair in usersPair.Value.OrderBy(x => x.Key))
                {
                    ipvs.Add(ipPair.Key);
                }

                Console.WriteLine($"{usersPair.Key}: {usersPair.Value.Values.Sum()} [{string.Join(", ", ipvs)}]");
            }
        }
    }
}
