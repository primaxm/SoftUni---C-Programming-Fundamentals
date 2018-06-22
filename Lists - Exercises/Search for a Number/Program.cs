using System;
using System.Collections.Generic;
using System.Linq;

namespace Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> action = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> output = new List<int>();

            for (int i = 0; i < action[0]; i++)
            {
                output.Add(numbers[i]);
            }

            for (int i = 0; i < action[1]; i++)
            {
                output.RemoveAt(i);
                action[1]--;
                i--;
            }

            bool has = false;
            for (int i = 0; i < output.Count; i++)
            {
                if (output[i] == action[2]) has = true;
            }

            if (has)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
            
        }
    }
}
