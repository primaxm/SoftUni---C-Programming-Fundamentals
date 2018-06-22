using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            long power = long.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            double halfPower = power / 2.0;
            int count = 0;
            while (power >= distance)
            {
                power -= distance;
                count++;
                if (power == halfPower && power >= exhaustionFactor && exhaustionFactor != 0)
                {
                    power /= exhaustionFactor;
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(count);
        }
    }
}
