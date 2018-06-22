using System;
using System.Linq;

namespace Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] pointOne = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] pointTwo = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Point p1 = new Point(pointOne[0], pointOne[1]);
            Point p2 = new Point(pointTwo[0], pointTwo[1]);

            double distance = CalcDistance(p1, p2);

            Console.WriteLine($"{distance:f3}");
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow((p1.X - p2.X),  2) + Math.Pow((p1.Y - p2.Y), 2));
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }


    }
}
