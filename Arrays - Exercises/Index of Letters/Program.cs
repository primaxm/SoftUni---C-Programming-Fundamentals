using System;
using System.Linq;

namespace Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            char[] arr = n.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                    Console.WriteLine($"{arr[i]} -> {(int)arr[i]-97}");
            }
 
        }
    }
}
