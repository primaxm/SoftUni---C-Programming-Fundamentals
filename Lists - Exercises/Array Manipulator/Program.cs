using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < int.MaxValue; i++)
            {
                List<string> commands = Console.ReadLine().Split(' ').ToList();

                if (commands[0] == "add" || commands[0] == "addMany")
                {
                    Add(numbers, commands);
                }
                else if (commands[0] == "contains")
                {
                    int index = Contains(numbers, commands);
                    Console.WriteLine(index);
                }
                else if (commands[0] == "remove")
                {
                    Remove(numbers, commands);
                }
                else if (commands[0] == "shift")
                {
                    Shift(numbers, commands);
                }
                else if (commands[0] == "sumPairs")
                {
                    sumPairs(numbers, commands);
                }
                else if (commands[0] == "print")
                {
                    Console.WriteLine("[" + string.Join(", ", numbers) + "]");
                    break;
                }
            }
            
        }

        static void Add(List<int> numbers, List<string> commnads)
        {
            int index = int.Parse(commnads[1]);
            int value = 0;
            for (int i = 2; i < commnads.Count; i++)
            {
                value = int.Parse(commnads[i]);
                numbers.Insert(index, value);
                index++;
            }
        }

        static int Contains(List<int> numbers, List<string> commnads)
        {
            int value = int.Parse(commnads[1]);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == value) return i;
            }
            return -1;
        }

        static void Remove(List<int> numbers, List<string> commnads)
        {
            numbers.RemoveAt(int.Parse(commnads[1]));
        }

        static void Shift(List<int> numbers, List<string> commnads)
        {
            int index = int.Parse(commnads[1]);
            for (int i = 0; i < index;)
            {
                numbers.Add(numbers[i]);
                numbers.RemoveAt(i);
                index--;
            }
        }

        static void sumPairs(List<int> numbers, List<string> commnads)
        {
            List<int> sum = new List<int>();
            for (int i = 1; i <= numbers.Count; i += 2)
            {
                if (i < numbers.Count)
                {
                    sum.Add(numbers[i] + numbers[i - 1]);
                   
                }
                else
                {
                    sum.Add(numbers[i-1]); 
                }
            }
            
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers.RemoveAt(i);
                i--;
            }
            for (int i = 0; i < sum.Count; i++)
            {
                numbers.Add(sum[i]);
            }
           
        }
    }
}
