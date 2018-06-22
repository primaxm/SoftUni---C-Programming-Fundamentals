using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Print(1, i);
                Console.WriteLine();
            }
            for (int i = n-1; i >= 1; i--)
            {
                Print(1, i);
                Console.WriteLine();
            }
        }

        static void Print(int start, int end)
        {
            for (int i = Math.Min(start, end); i <= Math.Max(start, end); i++)
            {
                Console.Write(i + " ");
            }
        } 
    }
}
