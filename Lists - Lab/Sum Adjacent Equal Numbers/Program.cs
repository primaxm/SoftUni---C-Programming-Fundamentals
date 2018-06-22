using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 0; i < int.MaxValue; i++)
            {
                int count = 0;
                for (int b = 0; b < numbers.Count; b++)
                {
                    if (b + 1 < numbers.Count)
                    {
                        if (numbers[b] == numbers[b + 1])
                        {
                            decimal sum = numbers[b] + numbers[b + 1];
                            numbers[b] = sum;
                            numbers.RemoveAt(b + 1);
                            count++;
                        }
                    }
                }

                if (count == 0) break;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
