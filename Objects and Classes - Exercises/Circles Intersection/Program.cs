using System;
using System.Linq;

namespace Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pointOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] pointTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point p1 = new Point(pointOne[0], pointOne[1]);
            Circle circle1 = new Circle(p1, pointOne[2]);
            Point p2 = new Point(pointTwo[0], pointTwo[1]);
            Circle circle2 = new Circle(p2, pointTwo[2]);

            bool kuku = Intersect(circle1, circle2);

            Console.WriteLine(kuku?"Yes":"No");

        }

        public static bool Intersect(Circle circle1, Circle circle2)
        {
            double d = Math.Sqrt(Math.Pow(circle1.MyPoint.X - circle2.MyPoint.X, 2) + 
                Math.Pow(circle1.MyPoint.Y - circle2.MyPoint.Y, 2));
            if (d <= (circle1.Radius + circle2.Radius))
            {
                return true;
            }
            return false;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Circle
    {
        public Point MyPoint { get; set; }
        public int Radius { get; set; }

        public Circle(Point p, int r)
        {
            MyPoint = p;
            Radius = r;
        }
    }
}
