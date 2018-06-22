using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> goods = new Dictionary<string, double>();
            for (int i = 0; i < 2000000000; i++)
            {
                string command = Console.ReadLine();
                if (command == "stop")
                {
                    foreach (var item in goods)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    break;
                }
                double qunatity = Double.Parse(Console.ReadLine());
                
                if (!goods.ContainsKey(command)) goods[command] = 0;
                goods[command] += qunatity;
            }
        }
    }
}
