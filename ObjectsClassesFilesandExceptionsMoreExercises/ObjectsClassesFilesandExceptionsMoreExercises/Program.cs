using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectsClassesFilesandExceptionsMoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            List<Person> persones = new List<Person>();

            while (input[0] != "End")
            {
                Person person = new Person();
                person.Name = input[0];
                person.ID = input[1];
                person.Age = int.Parse(input[2]);
                persones.Add(person);

                input = Console.ReadLine().Split().ToArray();
            }

            foreach (var item in persones.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }
            
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
