using System;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int thirth = int.Parse(Console.ReadLine());

            int biggestValue = MaxValue(first, second);
            int maxValue = MaxValue(biggestValue, thirth);
            Console.WriteLine(maxValue);
        }

        static int MaxValue(int first, int second)
        {
            return Math.Max(first, second);
        }
    }
}
