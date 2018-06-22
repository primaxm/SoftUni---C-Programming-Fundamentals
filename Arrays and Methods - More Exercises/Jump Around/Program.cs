using System;
using System.Linq;

namespace Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int currentIndex = 0;
            int sum = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                sum += arr[currentIndex];
                int nextIndex = currentIndex + arr[currentIndex];
                if (nextIndex > arr.Length)
                {
                    nextIndex = currentIndex - arr[currentIndex];
                    if (nextIndex < 0)
                    {
                        break;
                    }
                    else
                    {
                        currentIndex = nextIndex;
                    }
                }
                else
                {
                    currentIndex = nextIndex;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
