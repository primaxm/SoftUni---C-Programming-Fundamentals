using System;
using System.Collections.Generic;
using System.Linq;

namespace Memory_View
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string text = string.Empty;

            while (input != "Visual Studio crash")
            {
                text = text + " " + input;

                input = Console.ReadLine();
            }
            
            text = text.Trim();

            List<int> split = text.Split(' ').Select(x=>int.Parse(x)).ToList();
            List<int> workValues = new List<int>();

            int lengt = split.Count;
            for (int i = 0; i < lengt; i++)
            {
                if (split[i] != 0) workValues.Add(split[i]);
            }

            bool ok = true;
            
            while (ok)
            {
                string output = string.Empty;
                int firstIndex = workValues.IndexOf(32656);
                int secondIndex = workValues.IndexOf(19759);
                int thirdIndex = workValues.IndexOf(32763);
                if (firstIndex + 1 == secondIndex && secondIndex + 1 == thirdIndex)
                {
                    int number = workValues[thirdIndex + 2];
                    List<int> take = workValues.Skip(thirdIndex + 3).Take(number).ToList();
                    Console.WriteLine(string.Join(" ", take));
                    workValues.RemoveRange(firstIndex, firstIndex + 5 + number);
                    
                }

                int check1 = workValues.IndexOf(32656);
                int check2 = workValues.IndexOf(19759);
                int check3 = workValues.IndexOf(32763);
                if (check1 + 1 != check2 && check2 + 1 != check3)
                {
                    ok = false;
                }
            }

            Console.WriteLine(string.Join(" ", workValues));
        }
    }
}
