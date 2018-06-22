using System;
using System.Linq;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console
                .ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                double output = Math.Round(arr[i], mode: MidpointRounding.AwayFromZero);
                Console.WriteLine($"{arr[i]} => {output}");
            }
            
        }
    }
}
