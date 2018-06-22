using System;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int number = i;
                bool output = false;
                
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }

                output = (sum == 5 || sum == 7 || sum == 11);

                Console.WriteLine($"{i} -> {output}");
                sum = 0;
            }

        }
    }
}
