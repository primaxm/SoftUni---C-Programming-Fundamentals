using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Valid_Usernames
{
    class Program
    {
        public static string[] RegEx { get; private set; }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string splitPattern = @"[\s,\\\/\(\)]";
            string pattern = @"\b[a-zA-z][0-9a-zA-Z_]{2,24}";

            //string[] kuku = Regex.Split(input, splitPattern);
            List<string> inputUsernames = Regex.Split(input, splitPattern).Where(item => Regex.IsMatch(item, pattern) == true).ToList();

            int sum = 0;
            int index = 0;
            for (int i = 0; i <= inputUsernames.Count-2; i++)
            {
                int currentSum = inputUsernames[i].Length + inputUsernames[i + 1].Length;
                if (currentSum > sum)
                {
                    index = i;
                    sum = currentSum;
                }
               
            }
            Console.WriteLine(inputUsernames[index]);
            Console.WriteLine(inputUsernames[index+1]);
            //Console.WriteLine(string.Join(" ", inputUsernames));
        }
    }
}
