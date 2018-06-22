using System;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            double output = 0;
            if (parameter == "face")
            {
                output = CalculateFace(s);
            }
            else if (parameter == "space")
            {
                output = CalculateSpace(s);
            }
            else if (parameter == "volume")
            {
                output = CalculateVolume(s);
            }
            else if (parameter == "area")
            {
                output = CalculateArea(s);
            }

            Console.WriteLine($"{output:f2}");
        }

        static double CalculateFace(double s)
        {
            return Math.Sqrt(2 * Math.Pow(s, 2));
        }

        static double CalculateSpace(double s)
        {
            return Math.Sqrt(3 * Math.Pow(s, 2));
        }

        static double CalculateVolume(double s)
        {
            return Math.Pow(s, 3);
        }

        static double CalculateArea(double s)
        {
            return 6 * (s * s);
        }
    }
}
