using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Pokemon> pokemon = new List<Pokemon>();

            while (input != "wubbalubbadubdub")
            {
                List<string> splitedInput = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (splitedInput.Count == 1)
                {
                    if (pokemon.Any(x => x.PokemonName == splitedInput[0]))
                    {
                        //print NameData
                        PrintNameData(splitedInput[0], pokemon);
                    }
                }
                else
                {
                    Pokemon poke = new Pokemon();
                    poke.PokemonName = splitedInput[0];
                    poke.EvolutionType = splitedInput[1];
                    poke.EvolutionIndex = int.Parse(splitedInput[2]);

                    pokemon.Add(poke);
                }

                input = Console.ReadLine();
            }

            var names = pokemon.Select(z => z.PokemonName).Distinct();
            foreach (var item in names)
            {
                Console.WriteLine($"# {item}");
                foreach (var data in pokemon.Where(x=>x.PokemonName == item).OrderByDescending(x=>x.EvolutionIndex))
                {
                    Console.WriteLine($"{data.EvolutionType} <-> {data.EvolutionIndex}");
                }
            }
        }
        
        static void PrintNameData (string name, List<Pokemon> pokemon)
        {
            Console.WriteLine($"# {name}");
            foreach (var item in pokemon.Where(x=>x.PokemonName == name))
            {
                Console.WriteLine($"{item.EvolutionType} <-> {item.EvolutionIndex}");
            }
        }

    }

    class Pokemon
    {
        public string PokemonName { get; set; }
        public string EvolutionType { get; set; }
        public int EvolutionIndex { get; set; }
    }
}
