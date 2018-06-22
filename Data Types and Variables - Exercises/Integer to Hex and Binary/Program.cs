using System;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string xehexadecimal = Convert.ToString(number, 16);
            Console.WriteLine(xehexadecimal.ToUpper());
            Console.WriteLine(Convert.ToString(number, 2));


        }
    }
}
