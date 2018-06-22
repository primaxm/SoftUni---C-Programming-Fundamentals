using System;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            int hallPrice = 0;
            int packagePrice = 0;
            int discount = 0;
            double sum = 0;
            double pricePerPerson = 0;

            switch (package)
            {
                case "Normal":
                    packagePrice = 500;
                    discount = 5;
                    break;
                case "Gold":
                    packagePrice = 750;
                    discount = 10;
                    break;
                case "Platinum":
                    packagePrice = 1000;
                    discount = 15;
                    break;
            }

            if (group <= 50)
            {
                hallPrice = 2500;
                sum = hallPrice + packagePrice;
                sum = sum - sum * discount / 100.0;
                pricePerPerson = sum / group;
                Console.WriteLine($"We can offer you the Small Hall \r\nThe price per person is {pricePerPerson:f2}$");
            }
            else if (group > 50 && group <= 100)
            {
                hallPrice = 5000;
                sum = hallPrice + packagePrice;
                sum = sum - sum * discount / 100.0;
                pricePerPerson = sum / group;
                Console.WriteLine($"We can offer you the Terrace \r\nThe price per person is {pricePerPerson:f2}$");
            }
            else if (group > 100 && group <= 120)
            {
                hallPrice = 7500;
                sum = hallPrice + packagePrice;
                sum = sum - sum * discount / 100.0;
                pricePerPerson = sum / group;
                Console.WriteLine($"We can offer you the Great Hall \r\nThe price per person is {pricePerPerson:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            
        }
    }
}
