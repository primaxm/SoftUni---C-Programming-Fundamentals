using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> output = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    output.Add(numbers[i]);
                }
            }

            output.Reverse();
            if (output.Count > 0)
            {
                Console.WriteLine(string.Join(" ", output));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
