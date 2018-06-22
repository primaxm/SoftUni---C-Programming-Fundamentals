using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            var output = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (output.ContainsKey(words[i].ToLower()) == false)
                {
                    output[words[i].ToLower()] = 0;
                }
                output[words[i].ToLower()]++;
            }

            Console.WriteLine(string.Join(", ", output.Keys.Where(a => output[a] % 2 != 0)));
        }
    }
}
