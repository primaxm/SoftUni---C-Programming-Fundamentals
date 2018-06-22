using System;
using System.Text.RegularExpressions;

namespace Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (text != "end")
            {
                string regEx = @"<a.*?href.*?=(.*)>(.*?)</a>";
               
                string replacemet = @"[URL href=$1]$2[/URL]";
                var replaced = Regex.Replace(text, regEx, replacemet);
                Console.WriteLine(replaced);

                text = Console.ReadLine();
            }
        }
    }
}
