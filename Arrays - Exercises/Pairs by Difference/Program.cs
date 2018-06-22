using System;
using System.Linq;

namespace Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            int finalCount = 0;
            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = a; b < arr.Length; b++)
                {
                    if (Math.Abs(arr[a] - arr[b]) == n)
                    {
                        count++;
                    }
                }
                //if (count >= finalCount) finalCount = count;
               // count = 0;
            }
            Console.WriteLine(count);
        }
    }
}
