using System;
using System.Globalization;

namespace Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal totalSum = 0;
            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int capsulesCount = int.Parse(Console.ReadLine());
                int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

                decimal monthSum = (daysInMonth * capsulesCount) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${monthSum:F2}");
                totalSum += monthSum;
            }

            Console.WriteLine($"Total: ${totalSum:F2}");
        }
    }
}
