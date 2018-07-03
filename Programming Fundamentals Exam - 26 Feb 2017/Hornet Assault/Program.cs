using System;
using System.Collections.Generic;
using System.Linq;

namespace Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> beehives = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> hornets = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> liveBee = new List<int>();

            int count = beehives.Count;
            for (int i = 0; i < count; i++)
            {
                int hornetPower = 0;
                if (hornets.Sum() > 0)
                {
                    hornetPower = hornets.Sum();
                }
                if (hornetPower <= beehives[i])
                {
                    if (beehives[i] - hornetPower > 0)
                    {
                        liveBee.Add(beehives[i] - hornetPower);
                    }
                    if (hornets.Count > 0)
                    {
                        hornets.RemoveAt(0);
                    }
                }
            }

            if (liveBee.Count > 0)
            {
                Console.WriteLine(string.Join(" ", liveBee));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }

        }
    }
}
