using System;
using System.Linq;

namespace Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console
                .ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToArray();

            bool output = false;
            for (long a = 0; a < arr.Length-1; a++)
            {
                for (long b = a+1; b < arr.Length; b++)
                {
                    for (long c = 0; c < arr.Length; c++)
                    {
                        if (arr[a] + arr[b] == arr[c])
                        {
                            Console.WriteLine($"{arr[a]} + {arr[b]} == {arr[c]}");
                            output = true;
                            break;
                        }
                    }
                }
            }
            if (!output) Console.WriteLine("No"); 
        }
    }
}
