using System;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long sum = Fib(n);
            Console.WriteLine(sum);
        }

        static long Fib(int n)
        {
            long one = 0;
            long two = 1;
            long sum = 0;
            if (n == 0) sum = 1;
            for (int i = 0; i < n; i++)
            {
                sum = one + two;
                one = two;
                two = sum;
            }
            return sum;
        }
    }
}
