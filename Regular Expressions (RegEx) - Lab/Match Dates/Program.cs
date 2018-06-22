using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            //string text = "13/Jul/1928, 10-Nov-1934, , 01/Jan-1951,f 25.Dec.1937 23/09/1973, 1/Feb/2016";

            var dates = Regex.Matches(text, @"\b(\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b");
            

            foreach (Match date in dates)
            {
                Console.WriteLine($"Day: {date.Groups[1].Value}, Month: {date.Groups["month"].Value}, Year: {date.Groups["year"].Value}");
            }
            
        
        }
    }
}
