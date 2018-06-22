using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, BigInteger>> dwarfs = new Dictionary<string, Dictionary<string, BigInteger>>();

            while (input != "Once upon a time")
            {
                string[] splitedInput = input.Split(new string[] { " <:> " }, StringSplitOptions.None);
               
                string dwarfName = splitedInput[0];
                string dwarfColor = splitedInput[1];
                BigInteger dwarfPhysics = BigInteger.Parse(splitedInput[2]);

                if (dwarfs.ContainsKey(dwarfColor))
                {
                    if (dwarfs[dwarfColor].ContainsKey(dwarfName))
                    {
                        if (dwarfs[dwarfColor][dwarfName] < dwarfPhysics) dwarfs[dwarfColor][dwarfName] = dwarfPhysics;
                    }
                    else
                    {
                        dwarfs[dwarfColor].Add(dwarfName, dwarfPhysics);
                    }
                }
                else
                {
                    Dictionary<string, BigInteger> tmp = new Dictionary<string, BigInteger>();
                    tmp.Add(dwarfName, dwarfPhysics);
                    dwarfs.Add(dwarfColor, tmp);
                }

                input = Console.ReadLine();
            }

            
            foreach (var dwarfNamePower in dwarfs.OrderByDescending(x => x.Value.Values).ThenByDescending(x=>x.Value.Keys.Count()))
                {
                foreach (var item in dwarfNamePower.Value)
                {
                    Console.WriteLine($"({dwarfNamePower.Key}) {item.Key} <-> {item.Value}");
                }
            }
        }
    }
}
