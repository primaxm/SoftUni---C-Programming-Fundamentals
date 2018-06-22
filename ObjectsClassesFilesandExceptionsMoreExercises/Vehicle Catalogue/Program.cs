using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            List<Vehicle> car = new List<Vehicle>();

            while (input[0] != "End")
            {
                Vehicle vehicleType = new Vehicle();
                string word = input[0][0].ToString().ToUpper() + input[0].Substring(1, input[0].Length - 1);
                vehicleType.Type = word;
                vehicleType.Model = input[1];
                vehicleType.Color = input[2];
                vehicleType.Horsepower = int.Parse(input[3]);

                car.Add(vehicleType);
                input = Console.ReadLine().Split().ToArray();
            }

            string inpt = Console.ReadLine();
            while (inpt != "Close the Catalogue")
            {
                if(car.Any(x => x.Model == inpt))
                {
                    var kuku = car.Where(x => x.Model == inpt).ToArray();

                    foreach (var item in kuku)
                    {
                        Console.WriteLine($"Type: {item.Type}");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.Horsepower}");
                    }
                    
                }

                inpt = Console.ReadLine();
            }

            var kukuruku = car.Where(x => x.Type == "Car").ToArray();
            double sum = 0;
            foreach (var item in kukuruku)
            {
                sum += item.Horsepower;
            }
            Console.WriteLine($"Cars have average horsepower of: {(sum/ kukuruku.Length):f2}.");

            var kukurukutruck = car.Where(x => x.Type == "Truck").ToArray();
            double sumTruck = 0;
            foreach (var item in kukurukutruck)
            {
                sumTruck += item.Horsepower;
            }
            if (kukurukutruck.Length == 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {(sumTruck / kukurukutruck.Length):f2}.");
            }
            

        }

        class Vehicle
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int Horsepower { get; set; }
        }
    }
}