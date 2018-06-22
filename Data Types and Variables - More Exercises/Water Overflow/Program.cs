using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int litersTotal = 0;
            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                int litersM = litersTotal + liters;

                if (litersM > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    litersTotal += liters;
                }

            }
            Console.WriteLine(litersTotal);
        }
    }
}
