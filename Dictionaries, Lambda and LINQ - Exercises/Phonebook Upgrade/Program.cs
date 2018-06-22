using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();
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
                else if (input[0] == "ListAll")
                {
                    foreach (var item in phoneBook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
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
