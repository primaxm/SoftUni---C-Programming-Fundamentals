using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Karate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('>');

            int dif = 0;
            for (int i = 1; i < input.Length; i++)
            {
                string numpattern = @"[0-9]+";
                var strength = Regex.Match(input[i], numpattern);
                //int numLenght = strength.Length;
                //input[i] = input[i].Remove(0, numLenght);
                //Console.WriteLine(Convert.ToInt32(strength.Value));
                //Console.WriteLine(input[i].Length);

                int strenghtValue = Convert.ToInt32(strength.Value) + dif;
                if (input[i].Length <= 0)
                {
                    continue;
                }
                
                if(input[i].Length >= strenghtValue)
                {
                    input[i] = input[i].Remove(0, strenghtValue);
                    dif = 0;
                }
                else
                {
                    dif = strenghtValue - input[i].Length;
                    input[i] = input[i].Remove(0, input[i].Length);
                }
                
            }

            Console.WriteLine(string.Join(">", input));
        }
    }
}
