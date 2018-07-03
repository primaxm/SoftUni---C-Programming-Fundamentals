using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> users = new Dictionary<string, int>();
            Dictionary<string, int> lang = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "exam finished")
            {
                string[] split = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string username = split[0];

                if (split.Count() == 2 && split[1] == "banned")
                {
                    //check if exist
                    if (users.ContainsKey(username))
                    {
                        //if exist -> bann
                        users.Remove(username);
                    }
                } else
                {
                    string languege = split[1];
                    int points = int.Parse(split[2]);

                    if (users.ContainsKey(username))
                    {
                        if(users[username] < points)
                        {
                            users[username] = points;
                        }
                    }
                    else
                    {
                        //add data in users
                        users.Add(username, points);
                    }
                    //add data in lang
                    AddLangData(lang, languege);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            foreach (var item in users.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var item in lang.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }

        static void AddLangData (Dictionary<string, int> lang, string languege)
        {
            if (lang.ContainsKey(languege))
            {
                lang[languege]++;
            }
            else
            {
                lang.Add(languege, 1);
            }
        }
    }
}
