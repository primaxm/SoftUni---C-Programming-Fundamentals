using System;
using System.Collections.Generic;
using System.Linq;

namespace Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            List<Point> PointsCoordinates = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                Point point = new Point();
                double[] ipc = Console.ReadLine().Split().Select(double.Parse).ToArray();
                point.X = ipc[0];
                point.Y = ipc[1];
                PointsCoordinates.Add(point);
            }

            int indexPointOne = 0;
            int indexPointTwo = 0;
            double closestDistance = int.MaxValue;

            for (int i = 0; i < PointsCoordinates.Count-1; i++)
            {
                for (int b = i+1; b < PointsCoordinates.Count; b++)
                {
                    double distance = Math.Sqrt(Math.Pow(PointsCoordinates[i].X - PointsCoordinates[b].X, 2) + Math.Pow(PointsCoordinates[i].Y - PointsCoordinates[b].Y, 2));

                    if (distance < closestDistance)
                    {
                        closestDistance = distance;
                        indexPointOne = i;
                        indexPointTwo = b;
                    }
                }
            }

            Console.WriteLine($"{closestDistance:f3}");
            Console.WriteLine($"({PointsCoordinates[indexPointOne].X}, {PointsCoordinates[indexPointOne].Y})");
            Console.WriteLine($"({PointsCoordinates[indexPointTwo].X}, {PointsCoordinates[indexPointTwo].Y})");
        }
    }


    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

    }
}
