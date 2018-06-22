using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while(true)
            {
                string[] rules = Console.ReadLine().Split(new char[] { ' ' }).ToArray();

                string pattern = @"\b([" + rules[0] + @"]+){" + rules[1] + @",}\b";
                bool domainMatch = Regex.IsMatch(input, pattern);

                if (domainMatch)
                {
                    var match = Regex.Match(input, pattern);
                    int lenght = match.Value.Length;
                    string mm = new string(Convert.ToChar(rules[0]), lenght);
                    int index = input.IndexOf(mm);
                    Console.WriteLine($"Hideout found at index {index} and it is with size {lenght}!");
                    break;
                }
            }
        }
    }
}
