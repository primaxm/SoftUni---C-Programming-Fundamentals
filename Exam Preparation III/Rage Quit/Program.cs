using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
        
            string output = string.Empty;
            while (text.Length != 0)
            {
                var letterMatch = Regex.Match(text, @"[^0-9]+");
                var digitMatch = Regex.Match(text, @"[0-9]+");

                if (letterMatch.Success && digitMatch.Success)
                {
                    int digits = int.Parse(digitMatch.ToString());
                    string let = letterMatch.ToString().ToUpper();
                    string tmp = string.Empty;
                    for (int i = 0; i < digits; i++)
                    {
                        tmp += let;
                    }
                    output += tmp;
                    int count = digitMatch.ToString().Length + letterMatch.ToString().Length;
                    text = text.Remove(0, count);
                }
                
            }

            Console.WriteLine($"Unique symbols used: {output.Distinct().Count()}");
            Console.WriteLine(output);
           
        }
    }
}
