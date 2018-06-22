using System;
using System.Globalization;

namespace Objects_and_Classes___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string d = Console.ReadLine();
            DateTime date = DateTime.ParseExact(d, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
