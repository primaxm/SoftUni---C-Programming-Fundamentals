using System;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            switch (figure)
            {
                case "triangle":
                    double sideT = double.Parse(Console.ReadLine());
                    double heightT = double.Parse(Console.ReadLine());
                    double triangleArea = CalculateArea(sideT, heightT);
                    Console.WriteLine($"{triangleArea:f2}");
                    break;
                case "square":
                    double sideS = double.Parse(Console.ReadLine());
                    double squareleArea = CalculateArea(sideS);
                    Console.WriteLine($"{squareleArea:f2}");
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double heightR = double.Parse(Console.ReadLine());
                    double rectangleArea = CalculateArea(width, heightR, figure);
                    Console.WriteLine($"{rectangleArea:f2}");
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    double circleArea = CalculateArea(radius, figure);
                    Console.WriteLine($"{circleArea:f2}");
                    break;
            }
            
        }

        static double CalculateArea(double sideT, double heightT)
        {
            return (sideT * heightT) / 2;
        }

        static double CalculateArea(double sideS)
        {
            return Math.Pow(sideS, 2);
        }

        static double CalculateArea(double width, double heightR, string figure)
        {
            return width * heightR;
        }

        static double CalculateArea(double radius, string figure)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

    }
}
