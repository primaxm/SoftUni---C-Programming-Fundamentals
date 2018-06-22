using System;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int countA = 0;
            int countB = 0;
            int countCombinations = 0;
            for (int a = n; a <= m; a++)
            {
                for (int b = n; b <= m; b++)
                {
                    if (a + b == magicNumber)
                    {
                        countA = a;
                        countB = b;
                    }
                    countCombinations++;
                }
            }
            if (countA > 0)
            {
                Console.WriteLine($"Number found! {countA} + {countB} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{countCombinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}
