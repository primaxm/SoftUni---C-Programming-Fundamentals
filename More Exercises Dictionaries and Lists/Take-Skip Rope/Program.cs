using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string justNumbers = new String(input.Where(Char.IsDigit).ToArray());
            string justLetters = Regex.Replace(input, @"\d", "");

            char[] numbersListChar = justNumbers.ToCharArray();
            int[] numbersList = numbersListChar.Select(a => a - '0').ToArray();
            char[] letters = justLetters.ToArray();
            int[] takeList = new int[numbersList.Length / 2];
            int[] skipList = new int[numbersList.Length / 2];
            int oddCount = 0;
            int evenCount = 0;
            for (int i = 0; i < numbersList.Length; i++)
            {
                if(i % 2 == 0)
                {
                    takeList[evenCount] = numbersList[i];
                    evenCount++;
                }
                else
                {
                    skipList[oddCount] = numbersList[i];
                    oddCount++;
                }
            }
            Console.WriteLine(string.Join(" ", takeList));

            Console.WriteLine(string.Join(" ", skipList));
            Console.WriteLine(string.Join(" ", letters));

            string output = "";
            int total = 0;
            for (int i = 0; i < takeList.Length; i++)
            {
                int takeCoun = takeList[i];
                int skipCount = skipList[i];

                Console.Write("take " + takeList[i] + " ");
                Console.Write("skip " + skipList[i] + " ");
                Console.Write("total " + total + " ");


                output += new String(letters.Skip(total).Take(takeList[i]).ToArray());
                total += skipCount + takeCoun;
                Console.WriteLine(output);
            }

            Console.WriteLine(output);
        }
    }
}
