using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();
            while (input != "Lumpawaroo")
            {
                string forceSide = string.Empty;
                string forceUser = string.Empty;
                if (input.Contains("|"))
                {
                    string[] spInput = input.Split(new string[] { " | " }, StringSplitOptions.None).ToArray();

                    forceSide = spInput[0];
                    forceUser = spInput[1];
                    AddUser(sides, forceSide, forceUser, "no");
                }
                else
                {
                    string[] spInput = input.Split(new string[] { " -> " }, StringSplitOptions.None).ToArray();
                    forceSide = spInput[1];
                    forceUser = spInput[0];
                    AddUser(sides, forceSide, forceUser, "yes");
                }

                input = Console.ReadLine();
            }

            foreach (var users in sides.OrderByDescending(x => x.Value.Count).ThenBy(x=>x.Key))
            {
                if (users.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {users.Key}, Members: {users.Value.Count}");
                }
                
                foreach (var item in users.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {item}");
                }
            }
        }

        static void AddUser(Dictionary<string, List<string>> sides, string forceSide, string forceUser, string command)
        {
            bool contains = false;
            foreach (var users in sides)
            {
                if (users.Value.Contains(forceUser))
                {
                    if (command == "no")
                    {
                        contains = true;
                    }
                    else if (command == "yes")
                    {
                        //deleting
                        users.Value.Remove(forceUser);
                    }
                }
            }

            if (!contains && sides.ContainsKey(forceSide))
            {
                sides[forceSide].Add(forceUser);
                if (command == "yes") Console.WriteLine($"{forceUser} joins the {forceSide} side!");
            }
            else if (!contains && !sides.ContainsKey(forceSide))
            {
                List<string> tmp = new List<string>();
                tmp.Add(forceUser);
                sides.Add(forceSide, tmp);
                if (command == "yes") Console.WriteLine($"{forceUser} joins the {forceSide} side!");
            }
        }
    }

}
