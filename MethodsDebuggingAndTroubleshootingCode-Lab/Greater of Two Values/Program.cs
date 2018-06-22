using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            var one = Console.ReadLine();
            var two = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(one);
                int second = int.Parse(two);
                int max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char first = char.Parse(one);
                char second = char.Parse(two);
                char max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string max = GetMax(one, two);
                Console.WriteLine(max);
            }

            
        }

        static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }

        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }

}
