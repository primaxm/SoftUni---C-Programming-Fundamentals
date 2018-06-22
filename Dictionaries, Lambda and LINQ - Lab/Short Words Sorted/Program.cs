using System;
using System.Collections.Generic;
using System.Linq;

namespace Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            //. , : ; ( ) [ ] " ' \ / ! ? 
            List<string> list = Console.ReadLine()
                .Split(new char[] {'.', ',', ';', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .Where(str => (str.Count() < 5))
                .OrderBy(str => str)
                .ToList();

            Console.WriteLine(string.Join(", ", list.ConvertAll(d => d.ToLower()).Distinct()));
        }
    }
}
