using System;

namespace Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string latsChar = word.Substring(word.Length - 1);
            string lastTwoChars = word.Substring(word.Length - 2);

            if (lastTwoChars == "ch" || lastTwoChars == "sh")
            {
                word += "es";
            }
            else
            {
                if (latsChar == "y")
                {
                    word = word.Remove(word.Length - 1);
                    word += "ies";
                }
                else if (latsChar == "o" || latsChar == "s" || latsChar == "x" || latsChar == "z")
                {
                    word += "es";
                }
                else
                {
                    word += "s";
                }
            }
            Console.WriteLine(word);
        }
    }
}
