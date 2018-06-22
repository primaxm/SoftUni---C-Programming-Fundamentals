using System;

namespace Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintInt(number);
            
        }

        static void PrintInt(int number)
        {
            if(number > 0) Console.WriteLine($"The number {number} is positive.");
            if (number == 0) Console.WriteLine($"The number {number} is zero.");
            if (number < 0) Console.WriteLine($"The number {number} is negative.");
        }
    }
}
