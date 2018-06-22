using System;
using System.Text.RegularExpressions;

namespace Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"[0-9]+[a-zA-Z]";
            var matches = Regex.Matches(input, pattern);
            foreach (Match item in matches)
            {

                string letter = item.Value.Substring(item.Length - 1, 1);
                string patt = $@"{item.Value}";
                input = Regex.Replace(input, patt, letter+letter);
            }

            Console.WriteLine(input);
        }
    }
}
