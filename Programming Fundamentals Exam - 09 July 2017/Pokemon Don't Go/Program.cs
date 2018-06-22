using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> input = Console.ReadLine().Split().Select(long.Parse).ToList();

            BigInteger totalSum = 0;
            while (true)
            {
                if (input.Count == 0) break;
                int index = int.Parse(Console.ReadLine());

                long updateValue = 0;
                if (index < 0)
                {
                    updateValue = input[0];
                    input[0] = input[input.Count - 1];  
                }
                else if (index > input.Count - 1)
                {
                    updateValue = input[input.Count - 1];
                    input[input.Count - 1] = input[0];  
                }
                else
                {
                    updateValue = input[index];
                    input.RemoveAt(index);
                }


                totalSum += updateValue;
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] > updateValue)
                    {
                        input[i] -= updateValue;
                    }
                    else
                    {
                        input[i] += updateValue;
                    }
                }
                
            }

            Console.WriteLine(totalSum);
        }
    }
}
