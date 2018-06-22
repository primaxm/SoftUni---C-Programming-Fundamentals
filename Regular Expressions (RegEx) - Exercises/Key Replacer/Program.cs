using System;
using System.Text.RegularExpressions;
using System.Linq;


namespace Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keys = Console.ReadLine();
            string text = Console.ReadLine();
            //string keys = "start<213asfaas|end";
            //string text = "saaastarthelloendsdarstartFromTheOtherenddvsefdsfstartSideend";


            string startPattern = @"[a-zA-Z]+?(?=[|\\<])"; 
            string endPattern = @"(?<=[|\\<])[a-zA-Z]+";

            var startKey = Regex.Match(keys, startPattern);
            var endKey = Regex.Matches(keys, endPattern);

            string pattern = $@"{startKey.Value}(.*?){endKey.Last().Value}";
            var result = Regex.Matches(text, pattern);

            string output = string.Empty;
            foreach (Match match in result)
            {
                output += match.Groups[1].Value;
            }

            if (output == "")
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(output);
            }
            
        }
    }
}
