using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Email_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string[] email = Console.ReadLine().Split(new char[] { '@'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string[] splitDomain = email[1].Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string pattern = @"\b([a-zA-Z]+){5,}\b";
                bool usernameMatch = Regex.IsMatch(email[0], pattern);

                string domainPat = @"\b([a-z]+){3,}\b";
                bool domainMatch = Regex.IsMatch(splitDomain[0], domainPat);

                string extentionPat = @"\b(bg|com|org)\b";
                bool extentionMatch = Regex.IsMatch(splitDomain[1], extentionPat);

                if (usernameMatch && domainMatch  && extentionMatch)
                {
                    if (data.ContainsKey(email[1]))
                    {
                        if (!data[email[1]].Contains(email[0]))
                        {
                            data[email[1]].Add(email[0]);
                        }
                    }
                    else
                    {
                        List<string> tmp = new List<string>() { email[0] };
                        data.Add(email[1], tmp);
                    }
                }
            }

            foreach (var domainsPair in data.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{domainsPair.Key}:");
                foreach (var item in domainsPair.Value)
                {
                    Console.WriteLine($"### {item}");
                }
            }
        }
    }
}
