using System;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string var = Console.ReadLine();

            if (Convert.ToBoolean(var))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
