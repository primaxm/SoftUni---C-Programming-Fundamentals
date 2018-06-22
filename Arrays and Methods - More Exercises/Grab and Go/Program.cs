using System;
using System.Linq;

namespace Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            long sum = 0;
            bool hasInt = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (n == arr[i])
                {
                    count = i;
                    hasInt = true;
                }
            }

            for (int i = 0; i < count; i++)
            {
                sum += arr[i];
            }

            if(hasInt)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");

            }
        }
    }
}
