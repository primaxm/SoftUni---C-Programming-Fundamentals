using System;

namespace Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char exept = char.Parse(Console.ReadLine());

            for (int a = (int)first; a <= (int)second; a++)
            {
                for (int b = (int)first; b <= (int)second; b++)
                {
                    for (int c = (int)first; c <= (int)second; c++)
                    {
                        if (a == exept || b == exept || c == exept)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write((char)a);
                            Console.Write((char)b) ;
                            Console.Write((char)c + " ");
                        }
                    }
                }
            }
            
        }
    }
}
