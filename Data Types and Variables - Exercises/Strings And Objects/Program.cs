using System;

namespace Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string var1 = Console.ReadLine();
            string var2 = Console.ReadLine();

            object var3 = var1 + " " + var2;
            Console.WriteLine(var3.ToString());
        }
    }
}
