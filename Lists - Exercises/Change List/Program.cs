using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < int.MaxValue; i++)
            {
                List<string> arr = Console.ReadLine().Split(' ').ToList();
                if (arr[0] == "Delete")
                {
                    int number = int.Parse(arr[1]);
                    for (int a = 0; a < numbers.Count; a++)
                    {
                        if (numbers[a] == number)
                        {
                            numbers.RemoveAt(a);
                            a--;
                        }
                       
                    }
                }
                else if (arr[0] == "Insert")
                {
                    int num = int.Parse(arr[1]);
                    int index = int.Parse(arr[2]);
                    numbers.Insert(index, num);
                }
                else if (arr[0] == "Odd")
                {
                    for (int b = 0; b < numbers.Count; b++)
                    {
                        if (numbers[b] % 2 == 0)
                        {
                            numbers.RemoveAt(b);
                            b--;
                        }
                    }
                    break;
                }
                else if (arr[0] == "Even")
                {
                    for (int b = 0; b < numbers.Count; b++)
                    {
                        if (numbers[b] % 2 != 0)
                        {
                            numbers.RemoveAt(b);
                            b--;
                        }
                    }
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
