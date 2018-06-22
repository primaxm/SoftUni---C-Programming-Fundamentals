using System;

namespace Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int a = 2; a <= number; a++)
            {
                bool TowaLIE = true;
                for (int b = 2; b <= Math.Sqrt(a); b++)
                {
                    if (a % b == 0)
                    {
                        TowaLIE = false;
                        break;
                    }
                }
                Console.WriteLine($"{a} -> {TowaLIE}");
            }
        }
    }
}
