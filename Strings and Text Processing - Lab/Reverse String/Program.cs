using System;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] inpt = input.ToCharArray();
            Array.Reverse(inpt);
            Console.WriteLine(new string(inpt));
        }
    }
}
