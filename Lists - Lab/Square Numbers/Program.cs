using System;
using System.Collections.Generic;
using System.Linq;

namespace Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> sq = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    sq.Add(numbers[i]);
                }
            }

            sq.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", sq));
        }
    }
}
