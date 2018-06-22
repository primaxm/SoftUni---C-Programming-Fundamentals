using System;

namespace Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            string output = ReverseNumber(number);
            
            Console.WriteLine(output);
        }

        static string ReverseNumber(decimal number)
        {
            string output = "";
            string s = number.ToString();

            for (int i = 1; i <= s.Length; i++)
            {
                output += s.Substring(s.Length - i, 1);
            }

            return output;
        }
    }
}
