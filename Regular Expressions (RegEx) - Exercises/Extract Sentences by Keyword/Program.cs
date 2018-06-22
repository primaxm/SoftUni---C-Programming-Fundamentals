using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string search = Console.ReadLine();

            string text = Console.ReadLine();

            string pattern = $@"\b[^?.!]*\b{search}\b[^?.!]*";

            var result = Regex.Matches(text, pattern);

            foreach (Match item in result)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
