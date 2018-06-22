using System;

namespace Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int countOfCombination = 0;
            int sumOfCombination = 0;

            for (int a = n; a >= 1; a--)
            {
                for (int b = 1; b <= m; b++)
                {
                    countOfCombination++;
                    sumOfCombination += 3 * (a * b);
                    if (sumOfCombination >= maxSum)
                    {
                        Console.WriteLine($"{countOfCombination} combinations");
                        Console.WriteLine($"Sum: {sumOfCombination} >= {maxSum}");
                        break;
                    }
                }
                if (sumOfCombination > maxSum) break;
            }

            if (sumOfCombination < maxSum)
            {
                Console.WriteLine($"{countOfCombination} combinations");
                Console.WriteLine($"Sum: {sumOfCombination}");
            }

        }
    }
}
