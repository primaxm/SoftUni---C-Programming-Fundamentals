using System;

namespace Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double spendedMoney = 0;
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                int number = int.Parse(Console.ReadLine());

                if (number > 1) name += "s";
                Console.WriteLine($"Adding {number} {name} to cart.");
                spendedMoney = spendedMoney + (price * number);
            }

            if (budjet > spendedMoney)
            {
                Console.WriteLine($"Subtotal: ${spendedMoney:f2}");
                Console.WriteLine($"Money left: ${budjet - spendedMoney:f2}");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${spendedMoney:f2}");
                Console.WriteLine($"Not enough. We need ${spendedMoney - budjet:f2} more.");
            }
        }
    }
}
