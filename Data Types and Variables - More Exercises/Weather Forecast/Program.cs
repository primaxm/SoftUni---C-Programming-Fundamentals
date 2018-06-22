using System;

namespace Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            bool isFit = false;

            try
            {
                sbyte num = sbyte.Parse(number);
                isFit = true;
                Console.WriteLine("Sunny");
            } catch {}

            if (!isFit)
            {
                try
                {
                    int num = int.Parse(number);
                    isFit = true;
                    Console.WriteLine("Cloudy");
                }
                catch { }
            }

            if (!isFit)
            {
                try
                {
                    long num = long.Parse(number);
                    isFit = true;
                    Console.WriteLine("Windy");
                }
                catch { }
            }

            if (!isFit)
            {
                try
                {
                    double num = double.Parse(number);
                    isFit = true;
                    Console.WriteLine("Rainy");
                }
                catch { }
            }

        }
    }
}
