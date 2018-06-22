using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries__Lambda_and_LINQ___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(x => double.Parse(x)).ToArray();
            var output = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                    if (output.ContainsKey(numbers[i]) == false)
                    {
                        output[numbers[i]] = 0;
                    }
                    output[numbers[i]]++;
            }

            foreach (var item in output)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
            
        }
    }
}
