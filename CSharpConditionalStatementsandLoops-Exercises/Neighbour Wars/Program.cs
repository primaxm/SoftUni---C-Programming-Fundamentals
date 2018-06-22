using System;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            double peshoDamage = double.Parse(Console.ReadLine());
            double goshoDamage = double.Parse(Console.ReadLine());

            double peshoHealt = 100;
            double goshoHealt = 100;
            for (int i = 1; i < int.MaxValue; i++)
            {
                if (i % 2 == 0) //Gosho attacks
                {
                    peshoHealt -= goshoDamage;

                    if (Math.Round(peshoHealt) > 0) Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealt} health.");
                }
                else //Pesho attacks
                {
                    goshoHealt -= peshoDamage;
                    if (Math.Round(goshoHealt) > 0) Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealt} health.");
                }

                //If someone is dead
                if (Math.Round(peshoHealt) <= 0)
                {
                    Console.WriteLine($"Gosho won in {i}th round.");
                    break;
                }

                if (Math.Round(goshoHealt) <= 0)
                {
                    Console.WriteLine($"Pesho won in {i}th round.");
                    break;
                }


                if (i % 3 == 0)
                {
                    peshoHealt += 10;
                    goshoHealt += 10;
                }
            }
            
        }
    }
}
