using System;
using System.Linq;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string s1 = input[0];
            string s2 = input[1];

            if (input[0].Length < input[1].Length)
            {
                s1 = input[1];
                s2 = input[0];
            }

            int sum = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (i < s2.Length)
                {
                    sum += s1[i] * s2[i];
                }
                else
                {
                    sum += s1[i];
                }
                
            }

            Console.WriteLine(sum);
        }
    }
}
