using System;

namespace Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double value1 = double.Parse(Console.ReadLine());
            double value2 = double.Parse(Console.ReadLine());

            if (Math.Abs(value1 - value2) >= 0.000001)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
            
        }
    }
}
