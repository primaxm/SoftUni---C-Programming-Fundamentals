using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snowmen = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (snowmen.Count > 1)
            {
                List<int> indexOfKilled = new List<int>();
                int sequenceLenght = snowmen.Count;
                int count = snowmen.Count;
                for (int i = 0; i < snowmen.Count; i++)
                {
                    if (indexOfKilled.Contains(i))
                    {
                        continue;
                    }

                    int attackerIndex = i;
                    int targetIndex = snowmen[i];
                    if (snowmen[i] >= sequenceLenght)
                    {
                        targetIndex = snowmen[i] % sequenceLenght;
                    }

                    int difference = Math.Abs(attackerIndex - targetIndex);

                    if (difference % 2 == 0 && difference != 0)
                    {
                        if (count == 1) break;
                        indexOfKilled.Add(targetIndex);
                        Console.WriteLine($"{attackerIndex} x {targetIndex} -> {attackerIndex} wins");
                        count--;
                    }
                    else if (difference % 2 == 1)
                    {
                        if (count == 1) break;
                        indexOfKilled.Add(attackerIndex);
                        Console.WriteLine($"{attackerIndex} x {targetIndex} -> {targetIndex} wins");
                        count--;
                    }
                    else if (difference == 0)
                    {
                        if (count == 1) break;
                        indexOfKilled.Add(attackerIndex);
                        Console.WriteLine($"{attackerIndex} performed harakiri");
                        count--;
                    }

                }

                //Console.WriteLine(string.Join(" ", indexOfKilled));
                foreach (var item in indexOfKilled.OrderByDescending(x=>x))
                {
                    snowmen.RemoveAt(item);
                }
                //Console.WriteLine(string.Join(" ", snowmen));

                /*
                Console.WriteLine(indexOfKilled.Count);
                for (int i = 0; i > indexOfKilled.Count; i++)
                {
                    snowmen.RemoveAt(indexOfKilled[i]-i);                 
                }
                Console.WriteLine(snowmen.Count);*/
             }
        }
    }
}
