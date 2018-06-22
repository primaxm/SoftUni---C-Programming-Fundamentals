using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] commands = Console.ReadLine().Split(new char[] { '}', '{'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string pattern = @"([a-zA-Z]+)(.+)\1";
            var matches = Regex.Matches(text, pattern);

            int placeholderIndex = 0;
            foreach (Match match in matches)
            {
                if (placeholderIndex >= commands.Length) break;

                string substringOld = text.Substring(0, text.IndexOf(match.Groups[2].Value) + match.Groups[2].Value.Length);
                string subtringNew = substringOld.Replace(match.Groups[2].Value, commands[placeholderIndex]);
                text = subtringNew + text.Substring(substringOld.Length);
                placeholderIndex++;
            }

            Console.WriteLine(text);
        }
    }
}
