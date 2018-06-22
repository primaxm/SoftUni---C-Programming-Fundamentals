using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int persons = int.Parse(Console.ReadLine());

            double cources = Math.Ceiling((double)n / persons);
            Console.WriteLine(cources);
      
        }
    }
}
