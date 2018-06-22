using System;

namespace House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();

            bool isOne = false;
            int num1 = 0;
            int num2 = 0;
            try
            {
                num1 = sbyte.Parse(number1);
                num2 = int.Parse(number2);
                ulong sum = 10 * (ulong)num2 + 4 * (ulong)num1;
                Console.WriteLine(sum);
                isOne = true;
            }
            catch { }

            if (!isOne)
            {
                try
                {
                    num2 = sbyte.Parse(number2);
                    num1 = int.Parse(number1);
                    ulong sum = 10 * (ulong)num1 + 4 * (ulong)num2;
                    Console.WriteLine(sum);
                }
                catch { }
                
            }

            
        }
    }
}
