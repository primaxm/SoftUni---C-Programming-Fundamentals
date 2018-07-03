using System;
using System.Collections.Generic;
using System.Linq;

namespace Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            while (input != "Hornet is Green")
            {
                string[] splitedInput = input.Trim().Split(new string[] {" <-> "}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string add = string.Empty;
                if (splitedInput.Length == 2)
                {
                    if (IsDigitsOnly(splitedInput[0]) && LettersAndDigitsOnly(splitedInput[1]))
                    {
                        //private massage
                        char[] arr = splitedInput[0].ToCharArray();
                        Array.Reverse(arr);
                        string recipientsCode = new string(arr);
                        add = recipientsCode + " -> " + splitedInput[1];
                        messages.Add(add);
                    }

                    else if (NonDigitsOnly(splitedInput[0]) && LettersAndDigitsOnly(splitedInput[1]))
                    {
                        add = ChangeLetters(splitedInput[1]) + " -> " + splitedInput[0];
                        broadcasts.Add(add);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count > 0)
            {
                foreach (var item in broadcasts)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (messages.Count > 0)
            {
                foreach (var item in messages)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }



        }

        static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        static bool HasDigit(string str)
        {
            foreach (char c in str)
            {
                if (c >= '0' || c <= '9')
                    return true;
            }

            return false;
        }

        static bool NonDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c >= '0' && c <= '9')
                {
                    return false;
                }
                   
            }

            return true;
        }

        static bool LettersAndDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (!((c >= 48 && c <= 57) || (c >= 65 && c <= 90) || (c >= 97 && c <= 122)))
                    return false;
            }

            return true;
        }

        static bool HasLetters(string str)
        {
            foreach (char c in str)
            {
                if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122))
                    return true;
            }

            return false;
        }


        static string ChangeLetters(string str)
        {
            string convert = string.Empty;
            foreach (char c in str)
            {
                int cha = c;
                if (c > 64 && c < 91)
                {
                    cha += 32;
                }
                else if (c > 96 && c < 123)
                {
                    cha -= 32;
                }
                convert += Convert.ToChar(cha);
            }
            
            return convert;
        }
    }
}
