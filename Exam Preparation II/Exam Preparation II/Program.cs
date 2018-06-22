using System;
using System.Numerics;

namespace Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int marathonDays = int.Parse(Console.ReadLine());
            int runnerCount = int.Parse(Console.ReadLine());
            int avarageNumberOfLaps = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int capacityOfTheTrack = int.Parse(Console.ReadLine()); ;
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            long totalCapacity = capacityOfTheTrack * marathonDays;
            long runners = runnerCount;
            if (totalCapacity < runnerCount) runners = totalCapacity;

            decimal totalmeters = runners * avarageNumberOfLaps * lenght;
            decimal totalKilometers = totalmeters / 1000;
            decimal totalsum = moneyPerKilometer * totalKilometers;

            Console.WriteLine($"Money raised: {totalsum:f2}");
        }
    }
}
