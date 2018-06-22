using System;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int curHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int curEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |" + new String('|', curHealth) + new String('.', maxHealth - curHealth) + "|");
            Console.WriteLine($"Energy: |" + new String('|', curEnergy) + new String('.', maxEnergy - curEnergy) + "|");
        }
    }
}
