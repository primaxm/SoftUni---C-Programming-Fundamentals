using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> planets = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int decriptCode = 0;
                decriptCode = input.Count(x => (x == 'a' || x == 'A' || x == 's' || x == 'S' || x == 't' || x == 'T' || x == 'r' || x == 'R'));

                string dectiptedMessage = string.Empty;

                for (int a = 0; a < input.Length; a++)
                {
                    dectiptedMessage += Convert.ToChar(input[a] - decriptCode);
                }

                int kuku = Regex.Match(dectiptedMessage, @"(?<=@)[a-zA-Z]+").Index;

                if (Regex.IsMatch(dectiptedMessage, @"(?<=@)[a-zA-Z]+") &&
                Regex.IsMatch(dectiptedMessage, @"(?<=:)[0-9]+(?=[^.0-9]||\b)") &&
                Regex.IsMatch(dectiptedMessage, @"(?<=!)[a-zA-Z](?=!)") &&
                Regex.IsMatch(dectiptedMessage, @"(?<=(->))([0-9]+)(?=[^.0-9]||\b)"))
                {
                    if (Regex.Match(dectiptedMessage, @"(?<=@)[a-zA-Z]+").Index < Regex.Match(dectiptedMessage, @"(?<=:)[0-9]+(?=[^.0-9]||\b)").Index
                        && Regex.Match(dectiptedMessage, @"(?<=:)[0-9]+(?=[^.0-9]||\b)").Index < Regex.Match(dectiptedMessage, @"(?<=!)[a-zA-Z](?=!)").Index
                        && Regex.Match(dectiptedMessage, @"(?<=!)[a-zA-Z](?=!)").Index < Regex.Match(dectiptedMessage, @"(?<=(->))([0-9]+)(?=[^.0-9]||\b)").Index)
                    {
                        string planetName = Regex.Match(dectiptedMessage, @"(?<=@)[a-zA-Z]+").ToString();
                        //int population = int.Parse(Regex.Match(dectiptedMessage, @"(?<=:)[0-9]+").ToString());
                        string attackType = Regex.Match(dectiptedMessage, @"(?<=!)[a-zA-Z](?=!)").ToString();
                        //int soldierCount = int.Parse(Regex.Match(dectiptedMessage, @"(?<=(->))[0-9]+").ToString());

                        FullDict(planets, planetName, attackType);
                    }

                }
            }

            Console.WriteLine($"Attacked planets: {planets.Where(x=> (x.Value == "A")).Count()}");
            if (planets.Where(x => (x.Value == "A")).Count() > 0)
            {
                foreach (var item in planets.Where(x => (x.Value == "A")).OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-> {item.Key}");
                }
            }

            Console.WriteLine($"Destroyed planets: {planets.Where(x => (x.Value == "D")).Count()}");
            if (planets.Where(x => (x.Value == "D")).Count() > 0)
            {
                foreach (var item in planets.Where(x => (x.Value == "D")).OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-> {item.Key}");
                }
            }

        }

        static void FullDict (Dictionary<string, string> planets, string planetName, string attackType)
        {
            
                if (planets.ContainsKey(planetName))
                {
                    planets.Add(planetName, attackType);
                }
                else
                {
                    planets[planetName] = attackType;
                }
        }
    }
}
