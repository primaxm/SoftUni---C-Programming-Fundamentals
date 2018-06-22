using System;

namespace English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            string output = GetResult(number);
            Console.WriteLine(output);
        }

        static string GetResult(long number)
        {
            string output = "";
            long lastNumber = Math.Abs(number % 10);
            if (lastNumber == 0) output = "zero";
            if (lastNumber == 1) output = "one";
            if (lastNumber == 2) output = "two";
            if (lastNumber == 3) output = "three";
            if (lastNumber == 4) output = "four";
            if (lastNumber == 5) output = "five";
            if (lastNumber == 6) output = "six";
            if (lastNumber == 7) output = "seven";
            if (lastNumber == 8) output = "eight";
            if (lastNumber == 9) output = "nine";
            return output;
        }
    }
}
