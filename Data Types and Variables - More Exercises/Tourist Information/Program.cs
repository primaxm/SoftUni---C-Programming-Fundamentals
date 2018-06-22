using System;

namespace Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            var unit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            switch (unit)
            {
                case "miles":
                    Console.WriteLine($"{value} {unit} = {(1.6 * value):f2} kilometers");
                    break;
                case "inches":
                    Console.WriteLine($"{value} {unit} = {(2.54 * value):f2} centimeters");
                    break;
                case "feet":
                    Console.WriteLine($"{value} {unit} = {(30 * value):f2} centimeters");
                    break;
                case "yards":
                    Console.WriteLine($"{value} {unit} = {(0.91 * value):f2} meters");
                    break;
                case "gallons":
                    Console.WriteLine($"{value} {unit} = {(3.8 * value):f2} liters");
                    break;
            }
            
        }
    }
}
