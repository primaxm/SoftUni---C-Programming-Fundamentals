using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> words = new List<string>(); 
            foreach (var item in input)
            {
                bool ok = false;
                if (item.Length > 1)
                {
                    for (int i = 0; i < item.Length / 2; i++)
                    {
                        if (item[i].Equals(item[item.Length - i - 1]))
                        {
                            ok = true;
                        }
                        else
                        {
                            ok = false;
                            break;
                        }
                    }
                }
                else
                {
                    ok = true;
                }
                
                if (ok)
                {
                    words.Add(item);
                }
            }

            Console.WriteLine(string.Join(", ", words.Distinct().OrderBy(x=>x)));
        }
    }
}
