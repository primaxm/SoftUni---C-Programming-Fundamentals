using System;

namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            string output = "";
            bool fit = false;

            try
            {
                sbyte num = sbyte.Parse(number);
                output += "* sbyte\r\n";
                fit = true;
            }
            catch {}

            try
            {
                byte num = byte.Parse(number);
                output += "* byte\r\n";
                fit = true;
            }
            catch { }

            try
            {
                short num = short.Parse(number);
                output += "* short\r\n";
                fit = true;
            }
            catch { }

            try
            {
                ushort num = ushort.Parse(number);
                output += "* ushort\r\n";
                fit = true;
            }
            catch { }

            try
            {
                int num = int.Parse(number);
                output += "* int\r\n";
                fit = true;
            }
            catch { }

            try
            {
                uint num = uint.Parse(number);
                output += "* uint\r\n";
                fit = true;
            }
            catch { }

            try
            {
                long num = long.Parse(number);
                output += "* long\r\n";
                fit = true;
            }
            catch { }

            if (fit)
            {
                Console.WriteLine($"{number} can fit in:\r\n{output}");
            }
            else
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
            
        }
    }
}
