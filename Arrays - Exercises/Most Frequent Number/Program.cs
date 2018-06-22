using System;
using System.Linq;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int num = 0;
            int count = 0;
            int finalCount = 0;
            for (int a = 0; a < arr.Length; a++)
            {
                    for (int b = 0; b < arr.Length; b++)
                    {
                        if (arr[a] == arr[b])
                        {
                            count++;
                        }
                    }
                if (finalCount < count)
                {
                    num = arr[a];
                    finalCount = count;
                }
                count = 0;
            }

            Console.WriteLine(num);
        }
    }
}
