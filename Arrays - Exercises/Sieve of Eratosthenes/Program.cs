using System;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] arr = new bool[n+1];

            for (int i = 0; i <= n; i++)
            {
                arr[i] = true;
            }
            arr[0] = false;
            if (n > 0)
            {
                arr[1] = false;
                if (n == 2)
                {
                    Console.Write(2);
                }
                else
                {
                    for (int i = 2; i <= n; i++)
                    {
                        if (arr[i])
                        {
                            Console.Write(i + " ");
                            for (int c = 2; c <= n; c++)
                            {
                                if (c * i < n+1) arr[c * i] = false;
                            }

                        }
                    }
                }

            }
        }
    }
}
