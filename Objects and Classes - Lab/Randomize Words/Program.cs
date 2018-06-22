using System;
using System.Collections.Generic;
using System.Linq;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            List<string> words = Console.ReadLine().Split().ToList();
            
            for (int i = 0; i<words.Count; i++)
            {
                int number = rnd.Next(0, words.Count);
                Console.WriteLine(words[number]);
                words.RemoveAt(number);
                i--;
            }
        }
    }
}
