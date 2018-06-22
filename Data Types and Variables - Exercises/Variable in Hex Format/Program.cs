using System;

namespace Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string var = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(var, 16));
        }
    }
}
