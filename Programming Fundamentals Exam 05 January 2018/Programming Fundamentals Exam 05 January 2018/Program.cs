using System;
using System.Collections.Generic;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger biggestSnowballValue = -99999999;
            int biggestSnowballSnow = 0;
            int biggestSnowballTime = 0;
            int biggestSnowballQuality = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                    if (snowballValue >= biggestSnowballValue)
                    {
                        biggestSnowballValue = snowballValue;
                        biggestSnowballSnow = snowballSnow;
                        biggestSnowballTime = snowballTime;
                        biggestSnowballQuality = snowballQuality;
                    }
            }

            Console.WriteLine($"{biggestSnowballSnow} : {biggestSnowballTime} = {biggestSnowballValue} ({biggestSnowballQuality})");
        }
    }
}