using System;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            int sumsum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a);
                sumsum += a;
                a += 2;
            }
            Console.WriteLine($"Sum: {sumsum}");
        }
    }
}
