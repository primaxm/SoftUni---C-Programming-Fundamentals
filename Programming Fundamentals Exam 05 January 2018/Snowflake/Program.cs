using System;
using System.Text.RegularExpressions;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineOne = Console.ReadLine();
            string lineTwo = Console.ReadLine();
            string lineTree = Console.ReadLine();
            string lineFour = Console.ReadLine();
            string lineFive = Console.ReadLine();

            bool fLineCheck = Check(lineOne, @"([a-zA-Z0-9])");
            bool sLineCheck = Check(lineTwo, @"[^0-9_]");
            //bool treeLineCheck = Check(lineTree, @"([^a-zA-Z0-9_\s]+)([0-9_]+)([a-zA-Z]+)([0-9_]+)([^a-zA-Z0-9_\s]+)");
            bool treeLineCheck = Check(lineTree, @"([^a-zA-Z0-9_]+)([0-9_]+)([a-zA-Z]+)([0-9_]+)([^a-zA-Z0-9_]+)");
            bool fourLineCheck = Check(lineFour, @"[^0-9_]");
            bool fiveLineCheck = Check(lineFive, @"([a-zA-Z0-9])");

            //var match = Regex.Match(lineTree, @"([^a-zA-Z0-9_\s]+)([0-9_]+)([a-zA-Z]+)([0-9_]+)([^a-zA-Z0-9_\s]+)");
            var match = Regex.Match(lineTree, @"([^a-zA-Z0-9_]+)([0-9_]+)([a-zA-Z]+)([0-9_]+)([^a-zA-Z0-9_]+)");
            int coreLenght = match.Groups[3].Value.ToString().Length;

            if (!fLineCheck && !sLineCheck && treeLineCheck && !fourLineCheck && !fiveLineCheck)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(coreLenght);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        static bool Check(string text, string pattern)
        {
            return Regex.IsMatch(text, pattern);
        }
    }
}
