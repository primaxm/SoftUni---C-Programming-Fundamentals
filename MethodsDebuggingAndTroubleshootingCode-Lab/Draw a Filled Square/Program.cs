using System;

namespace Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTopAndBottomRow(n);
            for (int i = 1; i <= n-2; i++)
            {
                PrintMidRow(n);
                Console.WriteLine();
            }
            
            PrintTopAndBottomRow(n);

        }

        static void PrintTopAndBottomRow(int n)
        {
            Console.WriteLine(new String('-', 2 * n));
        }

        static void PrintMidRow(int n)
        {
            Console.Write("-");
            for (int i = 1; i <= n-1 ; i++)
            {   
                Console.Write("\\/");
            }
            Console.Write("-");
        }

    }
}
