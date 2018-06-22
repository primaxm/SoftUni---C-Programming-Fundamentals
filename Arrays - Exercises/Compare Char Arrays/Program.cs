using System;
using System.Linq;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrOne = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arrTwo = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            string which = "";
            for (int i = 0; i < Math.Min(arrOne.Length, arrTwo.Length); i++)
            {
                if (arrOne[i] < arrTwo[i])
                {
                    which = "first";
                    break;
                }
                else if (arrOne[i] > arrTwo[i])
                {
                    which = "second";
                    break;
                }
            }

            if (which == "first")
            {
                WriteOutput(arrOne);
                WriteOutput(arrTwo);
            }
            else if (which == "second")
            {
                WriteOutput(arrTwo);
                WriteOutput(arrOne);
            }
            else
            {
                if (arrOne.Length < arrTwo.Length)
                {
                    WriteOutput(arrOne);
                    WriteOutput(arrTwo);
                }
                else
                {
                    WriteOutput(arrTwo);
                    WriteOutput(arrOne);
                }
            }
            
        }

        private static void WriteOutput(char[] arr)
        {
            Console.WriteLine(string.Join("", arr));
        }
    }
}
