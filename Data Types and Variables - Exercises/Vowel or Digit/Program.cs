using System;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char var = char.Parse(Console.ReadLine());

            if (var == 'a' || var == 'e' || var == 'i' || var == 'o' || var == 'u' || var == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if (var >= 48 && var <= 57)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
            
    }
}
