using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> lenght = new List<int>();
            List<int> prev = new List<int>();
            List<int> longestSeq = new List<int>();

            int maxLenght = 0;
            int lastIndex = -1;

            for (int x = 0; x < numbers.Count; x++)
            {
                lenght.Insert(x, 1);
                prev.Insert(x, -1);
                for (int i = 0; i < x-1; i++)
                {
                    if (numbers[x] > numbers[i] && lenght[x] < lenght[i] +1)
                    {
                        lenght[x] = lenght[i] + 1;
                        prev[x] = i;
                    }
                }

                if (lenght[x] > maxLenght)
                {
                    maxLenght = lenght[x];
                    lastIndex = x;
                }
            }

            while(lastIndex != -1)
            {
                longestSeq.Add(numbers[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            longestSeq.Reverse();

            Console.WriteLine(string.Join(" ", longestSeq));
        }
    }
}
