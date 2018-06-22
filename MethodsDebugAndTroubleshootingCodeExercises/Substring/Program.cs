using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            //const char Search = 'р';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                
                if (Convert.ToChar(text[i])  == 'p')
                {
                    hasMatch = true;

                    int endIndex = jump;
                    string matchedString = "";
                    if (i + jump + 1 > text.Length)
                    {
                        matchedString = text.Substring(i);
                    }
                    else
                    {
                        matchedString = text.Substring(i, jump+1);
                    }
                    
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
