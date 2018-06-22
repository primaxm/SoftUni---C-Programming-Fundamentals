using System;
using System.Linq;

namespace Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int pos = 0;
            int len = 1;
            int bestPos = 0;
            int bestLen = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    len++;
                }
                else
                {
                    len = 1;
                    pos = i;
                }

                if (len > bestLen)
                {
                    bestLen = len;
                    bestPos = pos;
                }
            }

            for (int i = bestPos; i < bestPos + bestLen; i++)
            {
                Console.Write($"{arr[i]} ");

            }
            Console.WriteLine();
        }
    }
}
