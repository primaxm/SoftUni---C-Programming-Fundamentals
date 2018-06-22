using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = GetMultipleOfEvensAndOdds(num);
            Console.WriteLine(sum);
        }

        static int GetMultipleOfEvensAndOdds(int num)
        {
            int sumOdddigits = GetSumOddDigits(Math.Abs(num));
            int sumEvenDigits = GetSumEvenDigits(Math.Abs(num));
            return sumOdddigits * sumEvenDigits;
        }

        static int GetSumOddDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }
            return sum;
        }

        static int GetSumEvenDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }
            return sum;
        }
    }
}
