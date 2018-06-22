using System;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = Console.ReadLine();
            string lname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            long idNumber = long.Parse(Console.ReadLine());
            uint employeeNumber = uint.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {fname}");
            Console.WriteLine($"Last name: {lname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {idNumber}");
            Console.WriteLine($"Unique Employee number: {employeeNumber}");
            
        }
    }
}
