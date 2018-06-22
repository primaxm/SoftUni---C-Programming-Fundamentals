using System;
using System.Linq;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;
            int output = 0;
            bool hasSum = false;

            if (arr.Length == 1) hasSum = true;
            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = 0; b < arr.Length; b++)
                {
                    if (b < a)
                    {
                        leftSum += arr[b];
                    }
                    else if (b > a)
                    {
                        rightSum += arr[b];
                    }
                }
                if (leftSum == rightSum)
                {
                    output = a;
                    hasSum = true;
                }
                leftSum = 0;
                rightSum = 0;
            }
            if (hasSum)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
