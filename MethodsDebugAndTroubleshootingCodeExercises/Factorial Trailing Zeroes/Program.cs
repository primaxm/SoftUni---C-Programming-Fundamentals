using System;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            int zeroes = Trailing_Zeroes(factorial);
            Console.WriteLine(zeroes);
        }

        static int Trailing_Zeroes(BigInteger factorial)
        {
            int count = 0;
            while (factorial != 0)
            {
                BigInteger curNum = factorial % 10;
                if (curNum == 0)
                {
                    count++;
                }
                else
                {
                    break;
                }
                factorial /= 10;
            }
            return count;
        }
    }
}
