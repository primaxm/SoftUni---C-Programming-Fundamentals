using System;
using System.Collections.Generic;

namespace Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double myMoney = double.Parse(Console.ReadLine());

            double totalSpend = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                string games = Console.ReadLine();

                if (myMoney == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                if (games == "Game Time")
                {

                    Console.WriteLine($"Total spent: ${totalSpend:f2}. Remaining: ${myMoney:f2}");
                    break;
                }
                else if (games == "OutFall 4")
                {
                    if (myMoney < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought OutFall 4");
                        myMoney -= 39.99;
                        totalSpend += 39.99;
                    }  
                }
                else if (games == "CS: OG")
                {
                    if (myMoney < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought CS: OG");
                        myMoney -= 15.99;
                        totalSpend += 15.99;
                    }
                }
                else if (games == "Zplinter Zell")
                {
                    if (myMoney < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought Zplinter Zell");
                        myMoney -= 19.99;
                        totalSpend += 19.99;
                    }
                }
                else if (games == "Honored 2")
                {
                    if (myMoney < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought Honored 2");
                        myMoney -= 59.99;
                        totalSpend += 59.99;
                    }
                }
                else if (games == "RoverWatch")
                {
                    if (myMoney < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought RoverWatch");
                        myMoney -= 29.99;
                        totalSpend += 29.99;
                    }
                }
                else if (games == "RoverWatch Origins Edition")
                {
                    if (myMoney < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        myMoney -= 39.99;
                        totalSpend += 39.99;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }



            }
            
        }
    }
}
