using System;
using System.Collections.Generic;
using System.Linq;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            List<int> indexes = Console.ReadLine().Split().Select(int.Parse).Where(z=>z >= 0 && z < size).ToList();

            List<int> ladyBug = new List<int>();
            for (int i = 0; i < size; i++)
            {
                if (indexes.Contains(i))
                {
                    ladyBug.Add(1);
                }
                else
                {
                    ladyBug.Add(0);
                }
            }
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] splitCommand = command.Split();
                int startIndex = int.Parse(splitCommand[0]);
                string direction = splitCommand[1];
                int step = int.Parse(splitCommand[2]);

                if (step < 0)
                {
                    step = Math.Abs(step);
                    if (direction == "right") 
                    {
                        direction = "left";
                    }
                    else if (direction == "left")
                    {
                        direction = "right";
                    }
                }

                if (startIndex < 0 || startIndex > ladyBug.Count - 1)
                {
                    continue;
                }

                if (ladyBug[startIndex] == 1)
                {
                    ladyBug[startIndex] = 0;
                    int move = step;
                    while (true)
                    {
                        if (direction == "right")
                        {
                            if (startIndex + move > ladyBug.Count - 1) break;
                            if (ladyBug[startIndex + move] == 0)
                            {
                                ladyBug[startIndex + move] = 1;
                                break;
                            }
                            else
                            {
                                move += step;
                                continue;
                            }
                        }
                        else if (direction == "left")
                        {
                            if (startIndex - move < 0) break;
                            if (ladyBug[startIndex - move] == 0)
                            {
                                
                                ladyBug[startIndex - move] = 1;
                                break;
                            }
                            else
                            {
                                move += step;
                                continue;
                            }
                        }
                    }
                }
                
                command = Console.ReadLine();
            }


            Console.WriteLine(string.Join(" ", ladyBug));
        }
    }
}
