using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex pattern = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            var matches = pattern.Matches(text);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
