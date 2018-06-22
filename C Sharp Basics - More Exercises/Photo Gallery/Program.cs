using System;

namespace Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double sizeInBites = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string bite = "B";
            string typeOfPic = "";
            if (sizeInBites >= 1000 && sizeInBites < 1000000)
            {
                sizeInBites = sizeInBites / 1000;
                bite = "KB";
            }
            else if (sizeInBites >= 1000000)
            {
                sizeInBites = sizeInBites / 1000000;
                bite = "MB";
            }

            if (width == height)
            {
                typeOfPic = "square";
            }
            else if (width < height)
            {
                typeOfPic = "portrait";
            }
            else
            {
                typeOfPic = "landscape";
            }
            

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hours:D2}:{minutes:D2}");
            Console.WriteLine($"Size: {sizeInBites}{bite}");
            Console.WriteLine($"Resolution: {width}x{height} ({typeOfPic})");
        }
    }
}
