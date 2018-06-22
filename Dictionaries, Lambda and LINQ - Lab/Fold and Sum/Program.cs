using System;
using System.Linq;
using System.Collections.Generic;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            
            List<int> rowOneLeft = numbers.Take(numbers.Count / 4).Reverse().ToList();
            numbers.Reverse();
           
            List<int> rowOneRight = numbers.Take(numbers.Count / 4).ToList();
            //List<int> rowOneRight = numbers.TakeLast(numbers.Count / 4).Reverse().ToList();
            List<int> rowOne = rowOneLeft.Concat(rowOneRight).ToList();
            numbers.Reverse();
            List<int> rowTwo = numbers.Skip(numbers.Count / 4).Take(2 * (numbers.Count / 4)).ToList();

            var sum = rowOne.Select((x, index) => x + rowTwo[index]);

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
