using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            
            while (command != "3:1")
            {
                string[] splittedCommand = command.Split().ToArray();

                string toDo = splittedCommand[0];

                if (toDo == "merge")
                {
                    int startIndex = int.Parse(splittedCommand[1]);
                    int endIndex = int.Parse(splittedCommand[2]);

                    if (startIndex > input.Count-1) startIndex = input.Count - 1;
                    if (startIndex < 0) startIndex = 0;
                    if (endIndex > input.Count-1) endIndex = input.Count - 1;
                    if (endIndex < 0) endIndex = 0;
                    if (endIndex < startIndex) endIndex = startIndex;
                    for (int i = startIndex+1; i <= endIndex; i++)
                    {
                        input[startIndex] += input[i];
                    }
                    input.RemoveRange(startIndex+1, endIndex - startIndex);

                }
                else if (toDo == "divide")
                {
                    int index = int.Parse(splittedCommand[1]);
                    int partitions = int.Parse(splittedCommand[2]);

                    int elementsOfPartition = input[index].Length / partitions;
                    int remainder = input[index].Length % partitions;

                    List<string> tmp = new List<string>();
                    for (int a = 0; a < input[index].Length; a += elementsOfPartition)
                    {
                        string concat = string.Empty;
                        if (a == partitions - 1 && remainder > 0)
                        {
                            for (int i = 0; i < elementsOfPartition + remainder; i++)
                            {
                                concat += input[index][a + i];
                            }
                        }
                        else
                        {
                            for (int i = 0; i < elementsOfPartition; i++)
                            {
                                concat += input[index][a + i];
                            }
                        }

                        tmp.Add(concat);
                    }
                    input.RemoveAt(index);
                    input.InsertRange(index, tmp);
                }

                command = Console.ReadLine();
            }

            //Console.WriteLine(string.Join(" ", tmp));
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
