using System;

namespace String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            byte n = byte.Parse(Console.ReadLine());

            string output = "";
            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();

                if (type == "odd" && i % 2 != 0)
                {
                    output += word + ch;
                }
                else if (type == "even" && i % 2 == 0)
                {
                    output += word + ch;
                }
            }


            Console.WriteLine(output.Remove(output.Length-1, 1));
        }
    }
}
