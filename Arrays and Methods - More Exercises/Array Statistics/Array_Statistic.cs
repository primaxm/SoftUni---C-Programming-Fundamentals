using System;
using System.Linq;

namespace Array_Statistics
{
    class Array_Statistic
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            MinValue(arr);
            MaxValue(arr);      
            CalculateSum(arr);
        }

        static void MaxValue(int [] arr)
        {
            int maxValue = arr[0];
            for (int a = 1; a < arr.Length; a++)
            {
                if (maxValue < arr[a]) maxValue = arr[a];
            }

            Console.WriteLine($"Max = {maxValue}");
        }

        static void MinValue(int[] arr)
        {
            int minValue = arr[0];
            for (int a = 1; a < arr.Length; a++)
            {
                if (minValue > arr[a]) minValue = arr[a];
            }

            Console.WriteLine($"Min = {minValue}");
        }

        static void CalculateSum(int[] arr)
        {
            int sum = 0;
            double average = 0;
            for (int a = 0; a < arr.Length; a++)
            {
                sum += arr[a];
            }

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {((double)sum / (double)arr.Length)}");
        }

    }
}
