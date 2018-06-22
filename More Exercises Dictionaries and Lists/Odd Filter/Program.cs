using System;
using System.Linq;

namespace Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            nums = nums.Where(value => value % 2 == 0).ToArray();
            double average = nums.Sum() / nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > average)
                {
                    nums[i] += 1;
                }
                else if (nums[i] <= average)
                {
                    nums[i] -= 1;
                }
            }

            nums = nums.Where(value => value % 2 != 0).ToArray();

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
