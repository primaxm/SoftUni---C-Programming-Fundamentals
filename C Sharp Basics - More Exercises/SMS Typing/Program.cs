using System;

namespace SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string letter = "";
            string word = "";
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number == 0) letter = " ";
                if (number == 2) letter = "a";
                if (number == 22) letter = "b";
                if (number == 222) letter = "c";
                if (number == 3) letter = "d";
                if (number == 33) letter = "e";
                if (number == 333) letter = "f";
                if (number == 4) letter = "g";
                if (number == 44) letter = "h";
                if (number == 444) letter = "i";
                if (number == 5) letter = "j";
                if (number == 55) letter = "k";
                if (number == 555) letter = "l";
                if (number == 6) letter = "m";
                if (number == 66) letter = "n";
                if (number == 666) letter = "o";
                if (number == 7) letter = "p";
                if (number == 77) letter = "q";
                if (number == 777) letter = "r";
                if (number == 7777) letter = "s";
                if (number == 8) letter = "t";
                if (number == 88) letter = "u";
                if (number == 888) letter = "v";
                if (number == 9) letter = "w";
                if (number == 99) letter = "x";
                if (number == 999) letter = "y";
                if (number == 9999) letter = "z";


                word = word + letter;
            }
            Console.WriteLine(word);
            
        }
    }
}
