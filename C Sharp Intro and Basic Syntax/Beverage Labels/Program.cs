using System;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}: \r\n{volume/100.0*energy}kcal, {volume/100.0*sugar}g sugars");
        }
    }
}
