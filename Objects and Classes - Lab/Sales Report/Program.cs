using System;
using System.Linq;
using System.Collections.Generic;

namespace Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> cities = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                //Sale sale = new Sale(input[0], input[1], double.Parse(input[2]), int.Parse(input[3]));
                if (cities.ContainsKey(input[0]))
                {
                    double salse = double.Parse(input[2]) * double.Parse(input[3]);
                    cities[input[0]] += salse;
                }
                else
                {
                    double salse = double.Parse(input[2]) * double.Parse(input[3]);
                    cities.Add(input[0], salse);
                }
            }

            foreach (var cityPair in cities.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{cityPair.Key} -> {cityPair.Value:f2}");
            }
        }
    }
    /*
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Sale(string town, string product, double price, int quantity)
        {
            Town = town;
            Product = product;
            Price = price;
            Quantity = quantity;
        }
    }*/
}
