using System;

namespace Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            string var = Console.ReadLine();

            bool isInt = false;
            try
            {
                long num = long.Parse(var);
                Console.WriteLine("integer");
                isInt = true;
            }
            catch (Exception)
            {
            }

            if (!isInt)
            {
                try
                {
                    double num = double.Parse(var);
                    Console.WriteLine("floating-point");
                }
                catch (Exception)
                {
                }
            }

        }
    }
}
