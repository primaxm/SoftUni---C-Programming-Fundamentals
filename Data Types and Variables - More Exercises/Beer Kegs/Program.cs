using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string outputType = "";
            double volume = 0.0;
            for (int i = 1; i <= n; i++)
            {
                string type = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double vol = Math.PI * Math.Pow(r, 2) * height;
                if (vol > volume)
                {
                    volume = vol;
                    outputType = type;
                }

            }
            Console.WriteLine(outputType);
        }
    }
}
