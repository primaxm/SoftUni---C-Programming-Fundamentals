using System;
using System.Collections.Generic;
using System.Linq;

namespace Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<int>>> dragons = new Dictionary<string, Dictionary<string, List<int>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string dragonType = input[0];
                string dragonName = input[1];
                int damageValue = 0;
                int healtValue = 0;
                int armorValue = 0;

                damageValue = checkSkils(input[2], 45);
                healtValue = checkSkils(input[3], 250);
                armorValue = checkSkils(input[4], 10);

                if (!dragons.ContainsKey(dragonType))
                {
                    Dictionary<string, List<int>> nameTmp= new Dictionary<string, List<int>>();
                    List<int> skillsTmp = fullSkils(damageValue, healtValue, armorValue);
                    nameTmp.Add(dragonName, skillsTmp);
                    dragons.Add(dragonType, nameTmp);
                }
                else
                {
                    if (!dragons[dragonType].ContainsKey(dragonName))
                    {
                        List<int> skillsTmp = fullSkils(damageValue, healtValue, armorValue);
                        dragons[dragonType].Add(dragonName, skillsTmp);
                    }
                    else
                    {
                        dragons[dragonType][dragonName][0] = damageValue;
                        dragons[dragonType][dragonName][1] = healtValue;
                        dragons[dragonType][dragonName][2] = armorValue;
                    }
                }
            }

            foreach (var dragonsPair in dragons)
            {
                int damageMid = 0;
                int healtMid = 0;
                int armorMid = 0;
                int count = 0;
                foreach (var namePair in dragonsPair.Value)
                {
                    damageMid += namePair.Value[0];
                    healtMid += namePair.Value[1];
                    armorMid += namePair.Value[2];
                    count++;
                }
                Console.WriteLine($"{dragonsPair.Key}::({(double)damageMid/count:f2}/{(double)healtMid / count:f2}/{(double)armorMid / count:f2})");

                foreach (var namePair in dragonsPair.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{namePair.Key} -> damage: {namePair.Value[0]}, health: {namePair.Value[1]}, armor: {namePair.Value[2]}");
                }
            }
        }
        
        static int checkSkils(string value, int def)
        {
            try
            {
                return int.Parse(value);
            }
            catch (Exception)
            {
                return def;
            }
        }

        static List<int> fullSkils (int damageValue, int healtValue, int armorValue)
        {
            List<int> skillsTmp = new List<int>();
            skillsTmp.Add(damageValue);
            skillsTmp.Add(healtValue);
            skillsTmp.Add(armorValue);
            return skillsTmp;
        }
    }
}
