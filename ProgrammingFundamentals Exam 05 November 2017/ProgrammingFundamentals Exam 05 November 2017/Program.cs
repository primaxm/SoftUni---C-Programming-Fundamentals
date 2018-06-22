using System;
using System.Linq;
using System.Numerics;

namespace Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int key = int.Parse(Console.ReadLine());

            string[] websitest = new string[n];
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string siteName = input[0];
                uint siteVisits = uint.Parse(input[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(input[2]);

                websitest[i] = siteName;
                decimal siteLoss = siteVisits * siteCommercialPricePerVisit;
                sum += siteLoss;
            }

            BigInteger SecurityToken = BigInteger.Pow(key, n);

            for (int i = 0; i < websitest.Length; i++)
            {
                Console.WriteLine(websitest[i]);
            }
            Console.WriteLine($"Total Loss: {sum:f20}");
            Console.WriteLine($"Security Token: {SecurityToken}");
        }
    }
}
