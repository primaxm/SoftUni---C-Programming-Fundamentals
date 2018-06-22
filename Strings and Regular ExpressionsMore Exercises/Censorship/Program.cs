using System;
using System.Text.RegularExpressions;

namespace Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            int wordLenght = word.Length;
            string stars = new string('*', wordLenght);

            string pattern = $@"{word}";
            text = Regex.Replace(text, pattern, stars);
            Console.WriteLine(text);
        }
    }
}
