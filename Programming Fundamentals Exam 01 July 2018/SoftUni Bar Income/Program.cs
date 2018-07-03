using System;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            //Each valid order should have a customer, product, count and a price:
            //Valid customer's name should be surrounded by '%' and must start with a capital letter, followed by lower-case letters

            //Valid product contains any word character and must be surrounded by '<' and '>' 
            //Valid count is an integer, surrounded by '|'
            //Valid price is any real number followed by '$'

            string text = Console.ReadLine();

            double totalIncome = 0;
            while (text != "end of shift")
            {
                string pattern = @"%([A-Z][a-z]+)%[^(|$%.)]*<(\w+)>[^(|$%.)]*\|([0-9]+)\|[^(|$%.0-9)]*([0-9]+.?[0-9]*)\$";
                bool isMatch = Regex.IsMatch(text, pattern);

                if (isMatch)
                {
                    var match = Regex.Match(text, pattern);
                    double totalPrice = int.Parse(match.Groups[3].Value) * double.Parse(match.Groups[4].Value);
                    totalIncome += totalPrice;
                    Console.WriteLine($"{match.Groups[1]}: {match.Groups[2]} - {totalPrice:f2}");
                }

                text = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");

        }
    }
}
