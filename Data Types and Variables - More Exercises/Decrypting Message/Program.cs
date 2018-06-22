using System;

namespace Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string output = "";
            for (int i = 1; i <= n; i++)
            {
                char ch = char.Parse(Console.ReadLine());

                output += Convert.ToChar(ch + key);
            }

            Console.WriteLine(output);
        }
    }
}
