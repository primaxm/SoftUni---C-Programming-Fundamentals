using System;
using System.Collections.Generic;
using System.Linq;

namespace Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countryes = new Dictionary<string, Dictionary<string, long>>();
            string[] input = Console.ReadLine().Split('|').ToArray();

            while (input[0] != "report")
            {
                string country = input[1];
                string city = input[0];
                int population = int.Parse(input[2]);
                Dictionary<string, long> tmp = new Dictionary<string, long>();

                if (!countryes.ContainsKey(country))
                {
                    tmp.Add(city, population);
                    countryes.Add(country, tmp);
                }
                else
                {
                    countryes[country].Add(city, population);
                }


                input = Console.ReadLine().Split('|').ToArray();
            }

            foreach (var countryPair in countryes.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{countryPair.Key} (total population: {countryPair.Value.Values.Sum()})");
                foreach (var cityPair in countryPair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{cityPair.Key}: {cityPair.Value}");
                }
            }

        }
    }
}
