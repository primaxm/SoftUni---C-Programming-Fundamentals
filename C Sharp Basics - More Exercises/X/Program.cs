using System;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new String(' ', i));
                Console.Write("x");
                Console.Write(new String(' ', n - 2 * i - 2));
                Console.WriteLine("x");
            }
            Console.Write(new String(' ', n/2));
            Console.WriteLine("x");
            for (int i = 0; i < n/2; i++)
            {
                int count = n / 2 - i - 1;
                if (count < 0) count = 0;
                Console.Write(new String(' ', count));
                Console.Write("x");
                Console.Write(new String(' ', 2 * i + 1));
                Console.WriteLine("x");

            }

        }
    }
}
