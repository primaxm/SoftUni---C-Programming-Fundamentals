using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            
            
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                bool count = false;
                int number = i;
                for (int b = 0; b < int.MaxValue; b++)
                {
                    sum += number % 10;
                    number = number / 10;
                    if (number == 0)
                    {
                        break;
                    }
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    count = true;
                }
                Console.WriteLine(i + " -> " + count);
            }
           
        }
    }
}
