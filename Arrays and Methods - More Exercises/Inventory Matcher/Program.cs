using System;
using System.Linq;

namespace Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameOfProducts = Console.ReadLine().Split(' ').ToArray();
            long[] productQuantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] priceProduct = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            for (int a = 0; a < int.MaxValue; a++)
            {
                string productName = Console.ReadLine();

                if (productName == "done")
                {
                    break;
                }
                else
                {
                    for (int i = 0; i < nameOfProducts.Length; i++)
                    {
                        if (productName == nameOfProducts[i])
                        {
                            Console.WriteLine($"{nameOfProducts[i]} costs: {priceProduct[i]}; Available quantity: {productQuantities[i]}");
                        }
                    }  
                }
            }
        }
    }
}
