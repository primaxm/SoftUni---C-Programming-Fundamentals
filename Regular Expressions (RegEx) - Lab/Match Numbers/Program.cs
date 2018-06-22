using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string regEx = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var numbers = Regex.Matches(text, regEx).Cast<Match>().Select(x => x.Value).ToArray();
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
