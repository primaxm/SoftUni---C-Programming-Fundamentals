using System;

namespace Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string search = Console.ReadLine();

            int count = 0;
            int index = -1;
            while (true)
            {
                index = text.IndexOf(search, index + 1, StringComparison.CurrentCultureIgnoreCase);
                if (index < 0) break;
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
