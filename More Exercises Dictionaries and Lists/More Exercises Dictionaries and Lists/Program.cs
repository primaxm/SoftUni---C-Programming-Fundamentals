using System;
using System.Collections.Generic;
using System.Linq;

namespace More_Exercises_Dictionaries_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] time = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string, List<string>> sort = new Dictionary<string, List<string>>();

            foreach (var item in time)
            {
                string[] tmp = item.Split(':').ToArray();
                List<string> ttmp = new List<string>();
                if (!sort.ContainsKey(tmp[0]))
                {
                    ttmp.Add(tmp[1]);
                    sort.Add(tmp[0], ttmp);
                }
                else
                {
                    sort[tmp[0]].Add(tmp[1]);
                }
            }
            List<string> tmps = new List<string>();
            foreach (var item in sort.OrderBy(x=>x.Key))
            {
                foreach (var lists in item.Value.OrderBy(x => x))
                {
                    tmps.Add($"{item.Key}:{lists}");
                }
                
            }

            Console.Write(string.Join(", ", tmps));
            Console.WriteLine();
        }
    }
}
