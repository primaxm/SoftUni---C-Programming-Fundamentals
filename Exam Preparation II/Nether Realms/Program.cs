using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Nether_Realms
{
    class Program
    {
        public static string Rexex { get; private set; }

        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

            List<Demon> output = new List<Demon>();

            foreach (var name in names)
            {
                if (name == "") continue;
                //string symbolPattern = @"[^0-9+\-*/\.]";
                string symbolPattern = @"[^0-9\+\-\*\/\.]";

                string digitPattern = @"([0-9]+\.[0-9]+)|[0-9]+|-([0-9]+\.[0-9]+)";
                //string digitPattern = @"-?\d\.?\d*";

                string operationPattern = @"[/*]";

                var symbolMatches = Regex.Matches(name, symbolPattern);
                var digitMatches = Regex.Matches(name, digitPattern);
                var operationMatches = Regex.Matches(name, operationPattern);

                decimal totalHealth = 0;
                foreach (Match item in symbolMatches)
                {
                    totalHealth += Convert.ToChar(item.Value);
                }

                decimal damage = 0;
                foreach (Match item in digitMatches)
                {
                    damage += decimal.Parse(item.Value);
                }

                foreach (Match item in operationMatches)
                {
                    if (item.Value == "*")
                    {
                        damage *= 2.0M;
                    }
                    else if (item.Value == "/")
                    {
                        damage /= 2.0M;
                    }

                }

                Demon demon = new Demon();
                demon.Name = name;
                demon.Healt = totalHealth;
                demon.Damage = damage;

                if (!output.Any(x=>x.Name == name)) output.Add(demon);
            }

            foreach (var item in output.OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{item.Name} - {item.Healt} health, {item.Damage:f2} damage");
            }
        }


    }

    class Demon
    {
        public string Name { get; set; }
        public decimal Healt { get; set; }
        public decimal Damage { get; set; }
    }
}
