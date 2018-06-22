using System;

namespace Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double totalPrice = 0.0;
            if (profession.ToLower() == "athlete")
            {
                totalPrice = quantity * 0.70;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
            else if (profession.ToLower() == "businessman" || profession.ToLower() == "businesswoman")
            {
                totalPrice = quantity * 1.00;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
            else if (profession.ToLower() == "softuni student")
            {
                totalPrice = quantity * 1.70;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
            else
            {
                totalPrice = quantity * 1.20;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
        }
    }
}
