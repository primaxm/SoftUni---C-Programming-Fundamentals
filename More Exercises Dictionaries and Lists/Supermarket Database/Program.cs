using System;
using System.Linq;
using System.Collections.Generic;

namespace Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> products = new Dictionary<string, Dictionary<string, double>>();
            string[] input = Console.ReadLine().Split(' ').ToArray();

            while (input[0] != "stocked")
            {
                if (!products.ContainsKey(input[0]))
                {
                    Dictionary<string, double> tmp = new Dictionary<string, double>();
                    tmp.Add("price", double.Parse(input[1]));
                    tmp.Add("quantity", double.Parse(input[2]));
                    products.Add(input[0], tmp);
                }
                else
                {
                    products[input[0]]["price"] = double.Parse(input[1]);
                    products[input[0]]["quantity"] += double.Parse(input[2]);
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }

            double grandTotal = 0;
            foreach (var prodPair in products)
            {
                double totalSum = products[prodPair.Key]["price"] * products[prodPair.Key]["quantity"];
                Console.WriteLine($"{prodPair.Key}: ${products[prodPair.Key]["price"]:F2} * {products[prodPair.Key]["quantity"]} = ${totalSum:F2}");
                grandTotal += totalSum;
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${grandTotal:F2}");
        }
    }
}
