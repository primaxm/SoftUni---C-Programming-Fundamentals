using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());

            if (start <= 10)
            {
                for (int i = start; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }
            else
            {
                Console.WriteLine($"{n} X {start} = {n * start}");
            }

            
        }
    }
}
