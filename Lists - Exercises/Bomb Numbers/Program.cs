using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> command = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < int.MaxValue; i++)
            {
                bool stop = true;
                for (int a = 0; a < numbers.Count; a++)
                {
                    if (numbers[a] == command[0])
                    {
                        int startIndex = a - command[1];
                        if (startIndex < 0) startIndex = 0;
                        int deletedCount = 2 * command[1] + 1;
                        if(startIndex + deletedCount > numbers.Count)
                        {
                            deletedCount = numbers.Count - startIndex;
                        }
                        numbers.RemoveRange(startIndex, deletedCount);
                        stop = false;
                        break;  
                    }
                }

                if (stop) break;
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
