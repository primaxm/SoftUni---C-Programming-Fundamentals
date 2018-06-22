using System;

namespace Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char boatOne = char.Parse(Console.ReadLine());
            char boatTwo = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int fBoatSpeed = 0;
            int sBoatSpeed = 0;
            bool isPrint = false;
            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();

                if (word == "UPGRADE")
                {
                    boatOne = Convert.ToChar(boatOne + 3);
                    boatTwo = Convert.ToChar(boatTwo + 3);
                }
                else
                {

                    if (i % 2 != 0)
                    {
                        //first boat
                        fBoatSpeed += word.Length;
                        if (fBoatSpeed >= 50)
                        {
                            Console.WriteLine(boatOne);
                            isPrint = true;
                            break;
                        }
                    }
                    else
                    {
                        //second boat
                        sBoatSpeed += word.Length;
                        if (sBoatSpeed >= 50)
                        {
                            Console.WriteLine(boatTwo);
                            isPrint = true;
                            break;
                        }
                    }
                }


            }

            if (!isPrint)
            {
                if (fBoatSpeed > sBoatSpeed)
                {
                    Console.WriteLine(boatOne);
                }
                else
                {
                    Console.WriteLine(boatTwo);
                }
            }
            
        }
    }
}
