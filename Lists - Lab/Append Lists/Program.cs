using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine().Split('|').ToList();
            arrays.Reverse();

            for (int i = 0; i < arrays.Count; i++)
            {
                List<string> list = arrays[i].Split(' ').ToList();

                for (int a = 0; a < list.Count; a++)
                {
                    if (list[a] == "")
                    {
                        list.RemoveAt(a);
                        a--;
                    }  
                }
                
                string back = String.Join(" ", list);
                arrays[i] = back;
            }
            
            Console.WriteLine(string.Join(" ", arrays));
        }
    }
}
//, StringSplitOptions.RemoveEmptyEntries