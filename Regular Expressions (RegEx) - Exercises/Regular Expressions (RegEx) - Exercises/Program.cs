using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            //string pattern = @"(^|(?<=\s))([A-Za-z0-9])+([\.-_]?|[A-Za-z0-9]*)*@([A-Za-z])+?([-\.][A-Za-z]*)*(\.[a-z]{2,})((?=\s|\.)|$)";
            string pattern = @"((?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([.-][a - zA - Z]*)*(\.[a-z]{2,}))";
            //string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-_][A-Za-z]+)+))(\b|(?=\s))";
            var result = Regex.Matches(text, pattern);//.Select(s => s.Value).ToArray();

            foreach (Match item in result)
            {
                Console.WriteLine(item.Value);
            }
            //Console.WriteLine(string.Join(" ", result));
        }
    }
}
