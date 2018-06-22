using System;
using System.Linq;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int len1 = arrayOne.Length;
            int len2 = arrayTwo.Length;

            int[] arraySum = new int[Math.Max(len1, len2)];
            for (int i = 0; i < arraySum.Length; i++)
            {
                        arraySum[i] = arrayOne[i % len1] + arrayTwo[i % len2];
   
            }
            Console.WriteLine(string.Join(" ", arraySum));
        }
    }
}
