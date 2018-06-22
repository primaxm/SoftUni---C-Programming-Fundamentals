using System;
using System.Linq;

namespace Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] price = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int jewelsPrice = price[0];
            int goldPrice = price[1];


            int totalEarnings = 0;
            int totalExpenses = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                string input = Console.ReadLine();
                if (input == "Jail Time")
                {
                    break;
                }
                else
                {
                    string[] inputArr = input.Split(' ').ToArray();
                    int heistExpenses = int.Parse(inputArr[1]);

                    foreach (char ch in inputArr[0])
                    {
                        if (ch == '%') //jewels
                        {
                            totalEarnings += jewelsPrice;
                        }
                        else if (ch == '$') //gold
                        {
                            totalEarnings += goldPrice;
                        }
                    }
                    totalExpenses += heistExpenses;
                }

                
            }

            if (totalEarnings >= totalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings-totalExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpenses-totalEarnings}.");
            }
        }
    }
}
