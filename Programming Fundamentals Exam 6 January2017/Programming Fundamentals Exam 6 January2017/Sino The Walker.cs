using System;
using System.Linq;
using System.Numerics;

namespace Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] startTime = Console.ReadLine().Split(':').ToArray();
            long steps = long.Parse(Console.ReadLine());
            long secondsForSingleStep = long.Parse(Console.ReadLine());

            BigInteger walkTime = steps * secondsForSingleStep;

            BigInteger walkHours = walkTime / 3600;
            BigInteger walkMinutes = (walkTime % 3600) / 60;
            BigInteger walkSeconds = (walkTime % 3600) % 60;

            walkSeconds += long.Parse(startTime[2]);
            if(walkSeconds >= 60)
            {
                walkMinutes += walkSeconds / 60;
                walkSeconds = walkSeconds % 60;
                
            }

            walkMinutes += long.Parse(startTime[1]);

            if (walkMinutes >= 60)
            {
                walkHours += walkMinutes / 60;
                walkMinutes = walkMinutes % 60;
                
            }

            walkHours += long.Parse(startTime[0]);

            if (walkHours >= 24)
            {
                walkHours = walkHours % 24;
            }

            Console.WriteLine($"Time Arrival: {walkHours:d2}:{walkMinutes:d2}:{walkSeconds:d2}");
           
        }
    }
}
