using System;
using System.Collections.Generic;
using System.Linq;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>();
            for (int i = 0; i < int.MaxValue; i++)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    foreach (var item in contacts)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    break;
                }
                string email = Console.ReadLine();
                List<string> emailSplit = email.ToLower().Split('.').ToList();

                string lastTwo = emailSplit[emailSplit.Count - 1];

                if (lastTwo != "us" || lastTwo == "uk")
                {
                    contacts[name] = email;
                }
            }
        }
    }
}
