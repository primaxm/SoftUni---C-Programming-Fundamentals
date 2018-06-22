using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isCorrect = Regex.IsMatch(input, @".+#{1}");

            Dictionary<string, Dictionary<string, List<string>>> events = new Dictionary<string, Dictionary<string, List<string>>>();

            while (input != "Time for Code")
            {
                if (isCorrect)
                {
                    string[] splitInput = input.Split(new string[] { " ", "#", "@" }, StringSplitOptions.RemoveEmptyEntries);

                    Dictionary<string, List<string>> tmpD = new Dictionary<string, List<string>>();
                    List<string> tmpL = new List<string>();
                    if (events.ContainsKey(splitInput[0]))
                    {
                        if (events[splitInput[0]].Any(x=>x.Key == splitInput[1]))
                        {
                            for (int i = 2; i < splitInput.Length; i++)
                            {
                                events[splitInput[0]][splitInput[1]].Add(splitInput[i]);
                            } 
                        }
                    }
                    else
                    {
                        for (int i = 2; i < splitInput.Length; i++)
                        {
                            tmpL.Add(splitInput[i]);
                        }
                        tmpD.Add(splitInput[1], tmpL);
                        events.Add(splitInput[0], tmpD);
                    }
                    

                }

                input = Console.ReadLine();
            }
            var ordered = events.OrderByDescending(x => x.Value.Values.Count);

            foreach (var enevtsPair in ordered)
            {
                foreach (var item in enevtsPair.Value)
                {
                    Console.WriteLine($"{item.Key} - {item.Value.Count}");
                    foreach (var parti in item.Value)
                    {
                        Console.WriteLine($"@{parti}");
                    }
                }
            }

        }

    }

   
}
