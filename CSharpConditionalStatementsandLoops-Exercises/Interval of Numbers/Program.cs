using System;

namespace Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            int n = first;
            int m = second;
            if (first > second)
            {
                n = second;
                m = first;
            }

            for (int i = n; i <= m; i++)
            {
                Console.WriteLine(i);
            }  
        }
    }
}
