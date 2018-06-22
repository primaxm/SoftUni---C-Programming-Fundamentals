using System;
using System.Linq;

namespace Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            input = input.Where(x => (x.Length == 2)).ToArray();
            
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = new string(input[i].Reverse().ToArray());
            }

            Array.Reverse(input);

            foreach (string hex in input)
            {
                // Convert the number expressed in base-16 to an integer.
                int value = Convert.ToInt32(hex, 16);
                // Get the character corresponding to the integral value.
                
                char charValue = (char)value;
                Console.Write($"{charValue}");
            }

            Console.WriteLine();
        }
    }
}
