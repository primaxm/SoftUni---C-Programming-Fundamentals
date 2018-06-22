using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Morse_Code_Upgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                int zeroeCount = input[i].Where(x => x == '0').Count();
                int oneCount = input[i].Where(x => x == '1').Count();

                string zeroeP = @"([0]+){2,}";
                int zeroUp = Count(input[i], zeroeP);
                string oneP = @"([1]+){2,}";
                int oneUp = Count(input[i], oneP);


                int letterNum = zeroeCount * 3 + oneCount * 5 + zeroUp + oneUp;
                output = output + Convert.ToChar(letterNum);
            }

            Console.WriteLine(output);
        }

        static int Count(string input, string pattern)
        {
            int result = 0;
            var matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                result += match.Length;
            }

            return result;
        }
    }
}
