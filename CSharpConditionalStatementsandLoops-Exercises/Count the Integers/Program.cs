using System;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    int first = int.Parse(Console.ReadLine());
                    
                }
                catch
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            
        }
    }
}
