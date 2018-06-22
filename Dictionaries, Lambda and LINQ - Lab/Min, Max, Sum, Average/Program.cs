using System;
using System.Collections.Generic;
using System.Linq;

namespace Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                
                    list.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"Sum = {list.Sum()}");
            Console.WriteLine($"Min = {list.Min()}");
            Console.WriteLine($"Max = {list.Max()}");
            Console.WriteLine($"Average = {list.Average()}");
        }
    }
}
