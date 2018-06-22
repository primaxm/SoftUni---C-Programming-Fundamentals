using System;

namespace Programming_Fundamentals_Exam___04_March_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            double avalableMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double freeBelt = 0;
            if (students > 5) freeBelt = students/6;
            
            double neededSum = (Math.Ceiling(students * 1.1)) * lightsabersPrice + students * robesPrice + (students - freeBelt) * beltsPrice;

            if (avalableMoney >= neededSum)
            {
                Console.WriteLine($"The money is enough - it would cost {neededSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(neededSum-avalableMoney):f2}lv more.");
            }

        }
    }
}
