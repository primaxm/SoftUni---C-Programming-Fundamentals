using System;
using System.Linq;

namespace Arrays___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOme = Console.ReadLine().Split(' ').ToArray();
            string[] arrTwo = Console.ReadLine().Split(' ').ToArray();

            int min = Math.Min(arrOme.Length, arrTwo.Length);
            int max = Math.Max(arrOme.Length, arrTwo.Length);
            int leftCount = 0;
            int rightCount = 0;
            
            for (int i = 0; i < min; i++)
            {
                if (arrOme[i] == arrTwo[i])
                {
                    leftCount++;
                }
                else { break; }
            }

            for (int i = max - 1; i >= max - min; i--)
            {
                if (arrOme.Length > arrTwo.Length)
                {
                    if (arrOme[i] == arrTwo[i - (max - min)])
                    {
                        rightCount++;
                    }
                    else { break; }
                }
                else
                {
                    if (arrOme[i - (max - min)] == arrTwo[i])
                    {
                        rightCount++;
                    }
                    else { break; }
                }

            }

            if (leftCount >= rightCount)
            {
                    Console.WriteLine(leftCount);
            }
            else
            {
                    Console.WriteLine(rightCount);
            }
            
        }
    }
}
