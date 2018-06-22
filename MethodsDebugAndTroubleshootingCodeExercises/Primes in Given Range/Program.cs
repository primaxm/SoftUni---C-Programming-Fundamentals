using System;

namespace Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            long first = long.Parse(Console.ReadLine());
            long second = long.Parse(Console.ReadLine());

            string output = "";
            for (long i = first; i <= second; i++)
            {
                bool isPrime = IsPrime(i);
                if (isPrime)
                {
                    if (output == "")
                    {
                        output += i;
                    }
                    else
                    {
                        output += (", " + i);
                    }
                }
                
            }

            Console.WriteLine(output);
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
