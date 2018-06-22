using System;
using System.Linq;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banned = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
            string text = Console.ReadLine();

            foreach (var word in banned)
            {
                text = text.Replace(word, new string('*', word.Length), StringComparison.CurrentCultureIgnoreCase);
            }
            
            Console.WriteLine(text);
        }
    }
}
