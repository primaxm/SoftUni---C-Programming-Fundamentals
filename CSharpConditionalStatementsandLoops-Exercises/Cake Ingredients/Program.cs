using System;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                string ingedient = Console.ReadLine();
                
                if (ingedient == "Bake!" || i == 20)
                {
                    Console.WriteLine($"Preparing cake with {i} ingredients.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {ingedient}.");
                }
            }
            
        }
    }
}
