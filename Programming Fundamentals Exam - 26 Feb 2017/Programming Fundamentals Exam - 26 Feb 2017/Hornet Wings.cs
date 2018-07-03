using System;

namespace Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            //N – the wing flaps, the hornet has chosen to do
            //M – the distance the hornet travels for 1000 wing flaps.
            //P – the endurance of the hornet or how many wing flaps he can make, 
            //before he stops to take a break and rest. A hornet rests for 5 seconds.

            long n = long.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            long p = long.Parse(Console.ReadLine());

            double distance = (n / 1000.0) * m;
            double flyTime = n / 100.0;
            double restTime = (n / p) * 5.0;
            double time = flyTime + restTime;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{time} s.");

        }
    }
}
