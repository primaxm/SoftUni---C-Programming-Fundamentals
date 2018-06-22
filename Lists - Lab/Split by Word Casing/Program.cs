using System;
using System.Collections.Generic;
using System.Linq;

namespace Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ', '"', ',', ';', ':', '.', '!', '\\', '/', '(', ')', '\'', '[', ']' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> small = new List<string>();
            List<string> upper = new List<string>();
            List<string> mix = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                bool hasSmall = false;
                bool hasUpper = false;
                bool hasElse = false;
                foreach (char ch in input[i])
                {
                    if (ch >= 'a' && ch <= 'z')
                    {
                        hasSmall = true;
                    }
                    else if (ch >= 'A' && ch <= 'Z')
                    {
                        hasUpper = true;
                    }
                    else
                    {
                        hasElse = true;
                    }
                }

                if ((hasSmall && hasUpper) || hasElse)
                {
                    //mix
                    mix.Add(input[i]);
                }
                else if (hasSmall && !hasUpper && !hasElse)
                {
                    //small
                    small.Add(input[i]);
                }
                else if (!hasSmall && hasUpper && !hasElse)
                {
                    //Upeer
                    upper.Add(input[i]);
                }
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", small));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mix));
            Console.WriteLine("Upper-case: " + string.Join(", ", upper));
        }
    }
}
