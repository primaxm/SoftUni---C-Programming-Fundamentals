using System;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double lengthFirstPair = LineLength(x1, y1, x2, y2);
            double lengthSecondPair = LineLength(x3, y3, x4, y4);

            if (lengthFirstPair >= lengthSecondPair)
            {
                ClosesPoint(x1, y1, x2, y2);
            }
            else
            {
                ClosesPoint(x3, y3, x4, y4);

            }
            

        }

        static double LineLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));
        }

        static void ClosesPoint(double x1, double y1, double x2, double y2)
        {
            if (Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)) <= Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}
