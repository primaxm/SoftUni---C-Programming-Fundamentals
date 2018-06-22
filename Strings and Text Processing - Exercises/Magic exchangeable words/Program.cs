using System;
using System.Linq;

namespace Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int s1 = input[0].Distinct().Count();
            int s2 = input[1].Distinct().Count();
            
            if (s1 == s2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
