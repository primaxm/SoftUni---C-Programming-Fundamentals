using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries__Lambda_and_LINQ___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            for (int i = 0; i < int.MaxValue; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                if (input[0] == "A")
                {
                    if (phoneBook.ContainsKey(input[1]) == false) phoneBook.Add(input[1], input[2]);
                    phoneBook[input[1]] = input[2];
                }
                else if (input[0] == "S")
                {
                    if (!phoneBook.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                    else
                    {
                        foreach (var item in phoneBook.Where(item => item.Key == input[1]))
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        }
                    }

                }
                else if (input[0] == "END")
                {
                    break;
                }
            }
            
        }
    }
}
