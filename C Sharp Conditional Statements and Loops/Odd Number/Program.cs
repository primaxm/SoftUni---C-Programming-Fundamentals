using System;

namespace Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxValue = int.MaxValue;

            for (int i = 0; i < maxValue; i++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                    n = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    break;
                }
            }
            
        }
    }
}
