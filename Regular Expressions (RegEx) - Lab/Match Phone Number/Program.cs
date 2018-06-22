using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex pattern = new Regex(@"\+359([ |-])2\1[0-9]{3}\b\1[0-9]{4}\b");

            var matches = pattern.Matches(text);

            List<string> output = new List<string>();
            foreach (Match match in matches)
            {
                output.Add(match.Value);
            }
            Console.WriteLine(String.Join(", ", output));
        }
    }

}
