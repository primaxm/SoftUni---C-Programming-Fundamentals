using System;
using System.Linq;

namespace Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int count = arr.Length / 2 + 1;
            int to = 2;
            if (arr.Length % 2 != 0)
            {
                count = arr.Length / 2 + 2;
                to = 3;
            }

            if (arr.Length == 1)
            {
                Console.WriteLine($"{arr[0]}");
            }
            else
            {
                for (int i = count - to; i < count; i++)
                {
                    Console.WriteLine($"{arr[i]} ");
                }
            }
        }
    }
}
