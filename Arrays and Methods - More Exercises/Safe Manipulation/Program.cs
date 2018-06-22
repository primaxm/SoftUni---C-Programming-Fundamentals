using System;

namespace Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //int n = int.Parse(Console.ReadLine());

            string[] arr = input.Split(' ');

            for (int a = 0; a < int.MaxValue; a++)
            {
                string line = Console.ReadLine();
                string[] lineArr = line.Split(' ');
                line = lineArr[0];
                if (line.Equals("Reverse"))
                {
                    Reverse(arr);
                }
                else if (line.Equals("Distinct"))
                {
                    Distinct(arr);
                    int count = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i].Equals(" ")) count++;
                    }

                    string[] newArr = new string[arr.Length - count];

                    int cc = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (!arr[i].Equals(" "))
                        {
                            newArr[i - cc] = arr[i];
                        }
                        else
                        {
                            cc++;
                        }
                    }
                    Array.Resize(ref arr, arr.Length - cc);
                    for (int i = 0; i < newArr.Length; i++)
                    {
                        arr[i] = newArr[i];
                    }
                }
                else if (line.Equals("Replace"))
                {
                    
                    int index = int.Parse(lineArr[1]);

                    if (index >= 0 && index < arr.Length)
                    {
                        Replace(arr, index, lineArr[2]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }   
                }
                else if (line.Equals("END"))
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length - 1)
                {
                    Console.Write($"{arr[i]}, ");
                }
                else
                {
                    Console.WriteLine($"{arr[i]}");
                }
            }
        }

        static void Reverse(string[] arr)
        {
            Array.Reverse(arr);
        }

        static void Distinct(string[] arr)
        {
            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = a + 1; b < arr.Length; b++)
                {
                    if (arr[a].Equals(arr[b]))
                    {
                        arr[b] = " ";
                    }
                }
            }
        }


        static void Replace(string[] arr, int index, string replase)
        {
            arr[index] = replase;
        }
    }
}
