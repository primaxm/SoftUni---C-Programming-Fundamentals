using System;

namespace Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = ConvertTemperature(fahrenheit);

            Console.WriteLine($"{celsius:f2}");
        }

        static double ConvertTemperature(double fahrenheit)
        {
            return (fahrenheit - 32) * 5.0 / 9.0;
        }
    }
}
