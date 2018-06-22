using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] output = new int[arr.Length / 2];
            int k = arr.Length / 4;
            for (int i = 0; i < arr.Length/4; i++)
            {
                output[arr.Length / 4 - 1 - i] = arr[i] + arr[arr.Length / 2 -1 - i];
                output[output.Length / 2 + i] = arr[arr.Length / 2 + i] + arr[arr.Length - 1 - i];
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
