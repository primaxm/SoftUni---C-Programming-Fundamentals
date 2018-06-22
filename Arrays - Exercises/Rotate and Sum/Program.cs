using System;
using System.Linq;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] sumArray = new int[arr.Length];

            for (int r = 1; r <= k; r++)
            {
                int[] tmpArr = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {

                    if(i == arr.Length-1)
                    {
                         tmpArr[0] = arr[i];
                         sumArray[0] += tmpArr[0];
                    }
                    else
                    {
                         tmpArr[i+1] = arr[i];
                         sumArray[i+1] += tmpArr[i+1];
                    }
                }
                tmpArr.CopyTo(arr, 0);
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
