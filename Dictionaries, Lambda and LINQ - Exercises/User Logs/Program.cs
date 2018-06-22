using System;
using System.Collections.Generic;
using System.Linq;

namespace User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine().Split(' ').ToArray();

            while (input[0] != "end")
            {
                string [] ipvs = input[0].Split('=').ToArray();
                string [] usrnm = input[2].Split('=').ToArray();
                string username = usrnm[1];
                string IP = ipvs[1];

                if (!users.ContainsKey(username))
                {
                    Dictionary<string, int> ips = new Dictionary<string, int>();
                    ips.Add(IP, 1);
                    users.Add(username, ips);
                }
                else
                {
                    if (!users[username].ContainsKey(IP))
                    {
                        users[username].Add(IP, 1);   
                    }
                    else
                    {
                        users[username][IP]++;
                    }
                    
                }

                input = Console.ReadLine().Split(' ').ToArray();
            }

            foreach (var item in users.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}:");
                List<string> tmp = new List<string>();
  
                foreach (var dd in item.Value)
                {
                    tmp.Add($"{ dd.Key} => {dd.Value}");
                }
                Console.Write(string.Join(", ", tmp) + ".");
                Console.WriteLine();
            }
            
        }
    }
}
