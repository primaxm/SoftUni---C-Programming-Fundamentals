using System;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            n = n > 20 ? 20 : n;

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                string ingedient = Console.ReadLine();

                switch (ingedient.ToLower())
                {
                    case "cheese":
                        sum += 500;
                        break;
                    case "tomato sauce":
                        sum += 150;
                        break;
                    case "salami":
                        sum += 600;
                        break;
                    case "pepper":
                        sum += 50;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Total calories: {sum}");
        }
    }
}
