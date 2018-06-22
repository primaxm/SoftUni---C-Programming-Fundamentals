using System;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            numbers.Sort();

            var q = from x in numbers
                    group x by x into g
                    let count = g.Count()
                    select new { Value = g.Key, Count = count };
            foreach (var x in q)
            {
                Console.WriteLine(x.Value + " -> " + x.Count);
            }
            //var list = new List<string> { "a", "b", "a", "c", "a", "b" };
            //var q = from x in list
            //        group x by x into g
            //        let count = g.Count()
            //        orderby count descending
            //        select new { Value = g.Key, Count = count };
            //foreach (var x in q)
            //{
            //    Console.WriteLine("Value: " + x.Value + " Count: " + x.Count);
            //}


            //int count = 1;
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (i < numbers.Count-1)
            //    {
            //        if (numbers[i] == numbers[i+1])
            //        {
            //            count++;
            //            if (i == numbers.Count - 2)
            //            {
            //                Console.WriteLine($"{numbers[i]} -> {count}");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{numbers[i]} -> {count}");
            //            count = 1;
            //        }
            //    }
            //}


        }
    }
}
