using System;
using System.Linq;

namespace Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] pointOne = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] pointTwo = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Point p1 = new Point(pointOne[0], pointOne[1], pointOne[2], pointOne[3]);
            Point p2 = new Point(pointTwo[0], pointTwo[1], pointTwo[2], pointTwo[3]);

            bool inside = IsInside(p1, p2);
            Console.WriteLine(inside ? "Inside" : "Not inside");
        }

        public static bool IsInside(Point p1, Point p2)
        {
            bool isIns = false;
            if (p1.Left >= p2.Left && p1.Right <= p2.Right
                && p1.Bottom <= p2.Bottom && p1.Top <= p2.Top) isIns = true;
            return isIns;
        }

    }

    class Point
    {
        public double Left { get; set; }
        public double Top { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Right { get; set; }
        public double Bottom { get; set; }

        public Point(double left, double top, double width, double height)
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
            Right = left + width;
            Bottom = top + height;
        }

        
    }
}
