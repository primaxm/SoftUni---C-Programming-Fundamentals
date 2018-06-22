using System;
using System.Collections.Generic;
using System.Numerics;

namespace Be_Positive
{
    class Program
    {
        static void Main(string[] args)
        {
            long countSequences = long.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                var numbers = new List<BigInteger>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        BigInteger num = BigInteger.Parse(input[j]);
                        numbers.Add(num);
                    }
                    
                }

                bool found = false;

                for (int j = 0; j < numbers.Count; j++)
                {

                    BigInteger currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                    else if (currentNum < 0 && j != numbers.Count - 1)
                    {
                        currentNum += numbers[j + 1];

                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            found = true;
                        }
                        j++;
                    }
                    
                }

                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
                else
                {
                    Console.WriteLine();
                }  
            }
        }
    }
}
