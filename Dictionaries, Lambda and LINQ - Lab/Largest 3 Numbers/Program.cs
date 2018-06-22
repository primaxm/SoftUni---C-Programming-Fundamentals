using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split().Select(x => double.Parse(x)).ToList();
            
            Console.WriteLine(string.Join(" ", list.OrderByDescending(x => x).Take(3)));
        }
    }
}
