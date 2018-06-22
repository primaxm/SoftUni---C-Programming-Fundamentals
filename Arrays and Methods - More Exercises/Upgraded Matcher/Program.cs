using System;
using System.Linq;

namespace Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameOfProducts = Console.ReadLine().Split(' ').ToArray();
            long[] productQuantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] priceProduct = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            long[] prodQ = new long[nameOfProducts.Length];
            for (int i = 0; i < prodQ.Length; i++)
            {
                if (i < productQuantities.Length)
                {
                    prodQ[i] = productQuantities[i];
                }
                else
                {
                    prodQ[i] = 0;
                }
            }

            for (int a = 0; a < int.MaxValue; a++)
            {
                string [] productData = Console.ReadLine().Split(' ').ToArray();
                

                if (productData[0] == "done")
                {
                    break;
                }
                else
                {
                    long qant = long.Parse(productData[1]);
                    int index = Array.IndexOf(nameOfProducts, productData[0]);
                  
                    if (prodQ[index] >= qant)
                    {
                        Console.WriteLine($"{productData[0]} x {qant} costs {(qant* priceProduct[index]):f2}");
                        prodQ[index] = prodQ[index] - qant;
                    }
                    else
                    {
                        Console.WriteLine($"We do not have enough {productData[0]}");
                    }
                    
                }
            }
        }
    }
}
