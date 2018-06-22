using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var numbers = Regex.Matches(text, @"\b(?:0x)?[0-9A-F]+\b").Cast<Match>().Select(x => x.Value).ToArray();

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
