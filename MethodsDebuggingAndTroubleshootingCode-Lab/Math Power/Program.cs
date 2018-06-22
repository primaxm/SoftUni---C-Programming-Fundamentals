using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());

            double calculation = GetPower(num, pow);
            Console.WriteLine(calculation);
        }

        static double GetPower(double num, double pow)
        {
            return Math.Pow(num, pow);
        }
    }
}
