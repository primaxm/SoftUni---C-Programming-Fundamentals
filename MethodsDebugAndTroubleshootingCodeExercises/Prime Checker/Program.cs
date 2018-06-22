using System;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            bool isPrime = IsPrime(n);
            Console.WriteLine(isPrime);
        }

        static bool IsPrime(long n)
        {
            bool isPrime = true;
            if (n == 0 || n == 1) isPrime = false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
