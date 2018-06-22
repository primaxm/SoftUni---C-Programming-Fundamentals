using System;
using System.Collections.Generic;
using System.Linq;

namespace Ladybug_new
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] ladyBug = new int[size];
            Console.ReadLine().Split().Select(int.Parse).Where(z => z >= 0 && z < size).ToList().ForEach(i => ladyBug[i] = 1);

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] splitCommand = command.Split();
                int startIndex = int.Parse(splitCommand[0]);
                string direction = splitCommand[1];
                int step = int.Parse(splitCommand[2]);

                if (direction == "left") step *= -1;
                if (startIndex < 0 || startIndex > size-1) continue;
                if (ladyBug[startIndex] != 1) continue;

                ladyBug[startIndex] = 0;
                int nextindex = startIndex;
                while (true)
                {
                    nextindex += step;
                    if (nextindex > size - 1 || nextindex < 0) break;
                    if (ladyBug[nextindex] == 0)
                    {
                        ladyBug[nextindex] = 1;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", ladyBug));
        }
    }
}
