using System;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int sumSeconds = hours * 3600 + minutes * 60 + seconds;
            float mPerSecSpeed = (float)distance / (float)sumSeconds ;
            float kmPerHourSpeed = mPerSecSpeed * 3.6f;
            float milesPerHourSpeed = kmPerHourSpeed / 1.609f;

            Console.WriteLine($"{mPerSecSpeed}");
            Console.WriteLine($"{kmPerHourSpeed}");
            Console.WriteLine($"{milesPerHourSpeed}");
        }
    }
}
