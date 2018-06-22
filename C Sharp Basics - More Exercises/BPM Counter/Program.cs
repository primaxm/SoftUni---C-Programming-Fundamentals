using System;

namespace BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int beatsPerMinute = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());

            double secondsForOneBeat = 60.0 / beatsPerMinute;
            double secondsForAllBeats = beats * secondsForOneBeat;

           

            int minutes = (int)secondsForAllBeats / 60;
            int seconds = (int)secondsForAllBeats % 60;
            Console.WriteLine($"{Math.Round(beats/4.0, 1)} bars - {minutes}m {seconds}s");
        }
    }
}
