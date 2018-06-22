using System;
using System.Collections.Generic;
using System.Linq;

namespace Memory_View_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string text = string.Empty;

            while (input != "Visual Studio crash")
            {
                text = text + " " + input;

                input = Console.ReadLine();
            }

            text = text.Trim();
            List<int> values = text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int inOne = 0;
            int inTwo = 0;
            int inTree = 0;
            bool series = false;
            int number = 0;
            string output = string.Empty;
            List<string> print = new List<string>();

            for (int counter = 0; counter < values.Count; counter++)
            {
                if (values[counter] == 32656) 
                {
                    inOne = counter;
                }
                if (values[counter] == 19759 && inOne == counter - 1)
                {
                    inTwo = counter;
                }
                if (values[counter] == 32763 && inTwo == counter - 1 && inOne == counter - 2)
                {
                    inTree = counter;
                    series = true;
                }

                if (series == true && counter == inTree + 2)
                {
                    number = values[counter];
                }

                if (series == true && counter > inTree + 3 && counter <= inTree + 3 + number)
                {
                    output += Convert.ToChar(values[counter]);
                    if (counter == inTree + 3 + number)
                    {
                        print.Add(output);
                        inOne = 0;
                        inTwo = 0;
                        inTree = 0;
                        series = false;
                        number = 0;
                        output = string.Empty;
                    }
                }
            }

            foreach (var item in print)
            {
                Console.WriteLine(item);
            }
        }
    }
}
