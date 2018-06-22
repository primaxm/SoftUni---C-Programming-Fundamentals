using System;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string bojoPattern = @"([a-zA-Z]+)-([a-zA-Z]+)";
            string didiPattern = @"[^a-zA-Z\-]+";

            bool didisTurn = true;
            while (true)
            {
                var didiMatch = Regex.Match(text, didiPattern);
                var bojoMatch = Regex.Match(text, bojoPattern);
                if (didisTurn)
                {

                    if (didiMatch.Success)
                    {
                        Console.WriteLine(didiMatch.Value);
                        text = text.Remove(0, didiMatch.Index + didiMatch.Length);
                    }
                    else
                    {
                        if (!bojoMatch.Success) break;
                    }
                    didisTurn = false;
                    continue;
                }
                else
                {
                    if (bojoMatch.Success)
                    {
                        Console.WriteLine(bojoMatch.Value);
                        text = text.Remove(0, bojoMatch.Index + bojoMatch.Length);
                    }
                    else
                    {
                        if (!didiMatch.Success) break;
                    }
                    
                    didisTurn = true;
                    continue;
                }

            }
        }
    }
}
