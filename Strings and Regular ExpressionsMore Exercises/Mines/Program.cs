using System;
using System.Text.RegularExpressions;

namespace Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string getMinePattern = @"(?<=<).{2}(?=>)";

            var matches = Regex.Matches(text, getMinePattern);

            foreach (Match match in matches)
            {
                int range = Math.Abs(match.Value[0] - match.Value[1]);
                string pattern = @"(^|.{" + range + "})<" + match.Value + ">(.{" + range + "}|$)";
                
                var rmatche = Regex.Match(text, pattern);

                    
                    string replace = new String('_', rmatche.Length);

                    text = Regex.Replace(text, pattern, replace);

            }

            Console.WriteLine(text);
        }
    }
}
