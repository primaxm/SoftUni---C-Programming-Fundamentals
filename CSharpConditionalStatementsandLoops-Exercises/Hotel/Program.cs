using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double priceForTheStayStudio = 0;
            double priceForTheStayDouble = 0;
            double priceForTheStaySuite = 0;

            if (month == "May" || month == "October")
            {
                int night = nightsCount;
                if (nightsCount > 7 && month == "October")
                {
                    night--;
                }

                priceForTheStayStudio = 50 * night;
                if (nightsCount > 7)
                {
                    priceForTheStayStudio = priceForTheStayStudio - priceForTheStayStudio * 0.05;
                }
                priceForTheStayDouble = 65 * nightsCount;
                priceForTheStaySuite = 75 * nightsCount;
            }
            else if (month == "June" || month == "September")
            {
                int night = nightsCount;
                if (nightsCount > 7 && month == "September")
                {
                    night--;
                }
                priceForTheStayStudio = 60 * night;
                priceForTheStayDouble = 72 * nightsCount;
                if (nightsCount > 14)
                {
                    priceForTheStayDouble = priceForTheStayDouble - priceForTheStayDouble * 0.1;
                }
                priceForTheStaySuite = 82 * nightsCount;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                priceForTheStayStudio = 68 * nightsCount;
                priceForTheStayDouble = 77 * nightsCount;
                priceForTheStaySuite = 89 * nightsCount;
                if (nightsCount > 14)
                {
                    priceForTheStaySuite = priceForTheStaySuite - priceForTheStaySuite * 0.15;
                }
            }

            Console.WriteLine($"Studio: {priceForTheStayStudio:f2} lv.");
            Console.WriteLine($"Double: {priceForTheStayDouble:f2} lv.");
            Console.WriteLine($"Suite: {priceForTheStaySuite:f2} lv.");
        }
    }
}
