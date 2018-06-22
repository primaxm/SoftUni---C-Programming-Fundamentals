using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int lenght = 1;
            int tmpLenght = 1;
            int startPosition = 0;
            int tmpPosition = 0;
            for (int a = 0; a < numbers.Count; a++)
            {
                if (a < numbers.Count-1)
                {
                    if (numbers[a] == numbers[a + 1])
                    {
                        if (tmpLenght == 1) tmpPosition = a;
                        tmpLenght++;
                        if (a == numbers.Count- 2)
                        {
                            if (tmpLenght > lenght)
                            {
                                lenght = tmpLenght;
                                startPosition = tmpPosition;
                            }
                        }
                    }
                    else
                    {
                        if (tmpLenght > lenght)
                        {
                            lenght = tmpLenght;
                            startPosition = tmpPosition;
                        }
                        tmpLenght = 1;
                        tmpPosition = 0;
                    }
                }
            }

           
            for (int i = startPosition; i < startPosition + lenght; i++)
            {
                Console.Write(numbers[i]);
                if(i < startPosition + lenght -1) Console.Write(" ");
                
            }
            Console.WriteLine("");
        }
    }
}
