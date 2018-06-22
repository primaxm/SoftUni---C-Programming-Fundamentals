using System;

namespace Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string output = "";
            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                output += ch;
            }
            Console.WriteLine($"The word is: {output}");
        }
    }
}
