using System;

namespace Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong numberOfPictures = ulong.Parse(Console.ReadLine());
            ulong filterTimeForOnePicture = ulong.Parse(Console.ReadLine()); //seconds
            ulong filterFactor = ulong.Parse(Console.ReadLine()); //procent
            ulong uploadTime = ulong.Parse(Console.ReadLine());

            ulong totalFilterTime = filterTimeForOnePicture * numberOfPictures;
            ulong filterdPictures = (ulong)Math.Ceiling(numberOfPictures * (filterFactor / 100.0));
            ulong timeToUploadFilteredPictures = filterdPictures * uploadTime;
            ulong totalTime = totalFilterTime + timeToUploadFilteredPictures;


            ulong newsconds = totalTime % 60;
            ulong minutes = (ulong)Math.Floor(totalTime / 60.0);
            ulong newminets = minutes % 60;
            ulong hourse = (ulong)Math.Floor(minutes / 60.0);
            ulong nehourse = hourse % 24;
            ulong days = (ulong)hourse / 24;

            
            Console.WriteLine($"{days}:{nehourse:d2}:{newminets:d2}:{newsconds:d2}");
        }
    }
}
