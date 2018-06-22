using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] search = Console.ReadLine().Split().ToArray();
            //string[] search = { "9", "7" };
            string text = Console.ReadLine();
            //string text = "GreatBigSea|<uglyStuffHawaii|<boriiiingKilauea";

            string pattern = @"(?<=\|<).+?(?=\||\b)";

            var result = Regex.Matches(text, pattern);
            
            List<string> arr = new List<string>(); ;

            foreach (Match item in result)
            {
                char[] val = item.Value.Skip(int.Parse(search[0])).Take(int.Parse(search[1])).ToArray();
                string v = string.Join("", val);
                arr.Add(v);
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
