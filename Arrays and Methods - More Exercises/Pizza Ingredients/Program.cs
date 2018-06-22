using System;
using System.Linq;

namespace Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            int lenght = int.Parse(Console.ReadLine());

            string output = "";
            int numberOfFitIngredient = 0;

            for (int a = 0; a < arr.Length; a++)
            {
                int count = 0;
                foreach (char ch in arr[a])
                {
                    count++;
                }
                if (count == lenght)
                {
                    if (numberOfFitIngredient < 10)
                    {
                        Console.WriteLine($"Adding {arr[a]}.");
                        numberOfFitIngredient++;
                        output = output + arr[a] + " ";
                    }
                    else
                    {
                        break;
                    }

                }
            }

            Console.WriteLine($"Made pizza with total of {numberOfFitIngredient} ingredients.");

            string[] outputArr = output.Split(' ').ToArray();
            Console.Write("The ingredients are: ");
            for (int i = 0; i < outputArr.Length-1; i++)
            {
                Console.Write(outputArr[i]);
                if (i != outputArr.Length-2)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine(".");
                }

            }
            
        }
    }
}

