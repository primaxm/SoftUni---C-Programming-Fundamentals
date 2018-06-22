using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = Console.ReadLine();
            string lname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {fname} {lname}.\r\nYou are {age} years old.");
        }
    }
}
