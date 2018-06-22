using System;

namespace Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            if (country.ToLower() == "england" || country.ToLower() == "usa")
            {
                Console.WriteLine("English");
            }
            else if (country.ToLower() == "spain" || country.ToLower() == "argentina" || country.ToLower() == "mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
            
        }
    }
}
