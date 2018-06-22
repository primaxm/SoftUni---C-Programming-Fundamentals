using System;
using System.Linq;
using System.Collections.Generic;

namespace Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealt = int.Parse(Console.ReadLine());
            string varusName = Console.ReadLine();
            List<string> virus = new List<string>();
            int remainingHealt = initialHealt;
            bool kuku = true;

            while (varusName != "end")
            {              
                int timeTodefeat = 0;
                int ttdMinutes = 0;
                int ttdSeconds = 0;
                int virusStrength = 0;
                int charSum = 0;
                foreach (char ch in varusName)
                {
                    charSum += ch;
                }
                virusStrength = charSum / 3;

                if (virus.Contains(varusName))
                {
                    timeTodefeat = (virusStrength * varusName.Length) / 3;
                }
                else
                {
                    virus.Add(varusName);
                    timeTodefeat = (virusStrength * varusName.Length);
                }
                ttdMinutes = timeTodefeat / 60;
                ttdSeconds = timeTodefeat % 60;
                
                Console.WriteLine($"Virus {varusName}: {virusStrength} => {timeTodefeat} seconds");

                if (remainingHealt >= timeTodefeat)
                {
                    remainingHealt -= timeTodefeat;
                    Console.WriteLine($"{varusName} defeated in {ttdMinutes}m {ttdSeconds}s.");
                    Console.WriteLine($"Remaining health: {remainingHealt}");
                }
                else
                {
                    Console.WriteLine("Immune System Defeated.");
                    kuku = false;
                    break;
                }
                
                remainingHealt += (20 * remainingHealt) / 100;
                if (remainingHealt > initialHealt) remainingHealt = initialHealt;
                varusName = Console.ReadLine();
            }

            if (kuku) Console.WriteLine($"Final Health: {remainingHealt}");

        }
    }
}
