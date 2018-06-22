using System;

namespace Price_Change_Alert
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double significance = double.Parse(Console.ReadLine());
            double firstPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double price = double.Parse(Console.ReadLine());

                double difference = Procent(firstPrice, price);

                bool isSignificantDifference = HasDifference(difference, significance);

                string message = GetOutput(price, firstPrice, difference, isSignificantDifference);
                Console.WriteLine(message);

                firstPrice = price;
            }
        }

        private static string GetOutput(double price, double firstPrice, double difference, bool etherTrueOrFalse)
        {
            string output = "";
            if (difference == 0)
            {
                output = string.Format("NO CHANGE: {0}", price);
            }
            else if (!etherTrueOrFalse)
            {
                output = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", firstPrice, price, difference * 100);
            }
            else if (etherTrueOrFalse && (difference > 0))
            {
                output = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", firstPrice, price, difference * 100);
            }
            else if (etherTrueOrFalse && (difference < 0))
                output = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", firstPrice, price, difference * 100);
            return output;
        }


        static bool HasDifference(double difference, double significance)
        {
            if (Math.Abs(difference) >= significance)
            {
                return true;
            }
            return false;
        }

        static double Procent(double firstPrice, double price)
        {
            double difference = (price - firstPrice) / firstPrice;
            return difference;
        }
    }
}
