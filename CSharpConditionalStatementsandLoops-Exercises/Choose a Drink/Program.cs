using System;

namespace Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profesion = Console.ReadLine();

            if (profesion.ToLower() == "athlete")
            {
                Console.WriteLine("Water");
            }
            else if (profesion.ToLower() == "businessman" || profesion.ToLower() == "businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (profesion.ToLower() == "softuni student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
