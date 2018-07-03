using System;

namespace SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int empOne = int.Parse(Console.ReadLine());
            int empTwo = int.Parse(Console.ReadLine());
            int empTree = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int sumEmpCanHelpForHour = empOne + empTwo + empTree;

            int neededHours = 0;
            if (sumEmpCanHelpForHour >= studentsCount)
            {
                neededHours = 1;
            }
            else
            {
                neededHours = studentsCount / sumEmpCanHelpForHour;
                if (studentsCount % sumEmpCanHelpForHour > 0)
                {
                    neededHours++;
                }
            }

            //adding hours for rest
            if (neededHours % 3 != 0)
            {
                neededHours += neededHours / 3;
            }
            else
            {
                neededHours += neededHours / 3 - 1;
            }

            if (studentsCount == 0)
            {
                neededHours = 0;
            }
            Console.WriteLine($"Time needed: {neededHours}h.");
        }
    }
}
