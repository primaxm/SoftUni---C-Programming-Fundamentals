using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> users = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string username = input[1];
                
                if (input[0] == "register")
                {
                    string licensePlateNumber = input[2];
                    string pattern = @"([A-Z]{2})([0-9]{4})([A-Z]{2})";
                    Regex regex = new Regex(pattern);

                    if (users.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users[username]}");
                    }
                    else if (!regex.IsMatch(licensePlateNumber))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
                    }
                    else if (users.ContainsValue(licensePlateNumber))
                    {
                        Console.WriteLine($"ERROR: license plate {licensePlateNumber} is busy");
                    }
                    else
                    {
                        users.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    } 
                }
                else if (input[0] == "unregister")
                {
                    if (!users.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                            users.Remove(username);
                            Console.WriteLine($"user {username} unregistered successfully");
                    }
                }
            }

            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
