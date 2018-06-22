using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> values = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < values.Count; i++)
            {
                List<char> splited = new List<char>();
                string back = "";
                foreach (char item in values[i])
                {
                    splited.Add(item);
                }
                splited.Reverse();
                foreach (var item in splited)
                {
                    back += item;
                }

                values[i] = back;
            }
            int sum = 0;
            foreach (string item in values)
            {
                int tmp = int.Parse(item);
                sum += tmp;
            }
            Console.WriteLine(sum);
        }
    }
}
