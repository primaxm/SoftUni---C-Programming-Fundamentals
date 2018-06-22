using System;

namespace C_Sharp_Intro_and_Basic_Syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());

            Console.WriteLine($"{one:d4} {two:d4} {three:d4} {four:d4}");
        }
    }
}
