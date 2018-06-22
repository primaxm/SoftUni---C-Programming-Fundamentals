using System;
using System.Collections.Generic;
using System.Linq;

namespace Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            //List<string> data = new List<string> { "10", "9", "8", "7", "6", "5", "4", "3", "2", "1"};
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] splitCommand = command.Split().ToArray();

                if (splitCommand[0] == "reverse")
                {
                    int startIndex = int.Parse(splitCommand[2]);
                    int range = int.Parse(splitCommand[4]);
                    if (startIndex < 0 || startIndex + range > data.Count)
                    {
                        InvlidInput();
                        continue;
                    }
                    data.Reverse(startIndex, range);
                }
                else if (splitCommand[0] == "sort")
                {
                    int startIndex = int.Parse(splitCommand[2]);
                    int range = int.Parse(splitCommand[4]);
                    if (startIndex < 0 || startIndex + range > data.Count)
                    {
                        InvlidInput();
                        continue;
                    }
                    data.Sort(startIndex, range, StringComparer.InvariantCultureIgnoreCase);
                }
                else if (splitCommand[0] == "rollLeft")
                {
                    int count = int.Parse(splitCommand[1]);
                    var tmp = data.Take(count);
                    if (count > data.Count - 1)
                    {
                        InvlidInput();
                        continue;
                    }
                    data.AddRange(tmp);
                    data.RemoveRange(0, count);
                }
                else if (splitCommand[0] == "rollRight")
                {
                    int count = int.Parse(splitCommand[1]);
                    var tmp = data.TakeLast(count);
                    if (count > data.Count - 1)
                    {
                        InvlidInput();
                        continue;
                    }
                    data.InsertRange(0, tmp);
                    data.RemoveRange(data.Count - count, count);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", data) + "]");
        }

        static void InvlidInput()
        {
            Console.WriteLine("Invalid input parameters.");
        }
    }
}
