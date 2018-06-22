using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>(); 
            while (n-- != 0)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                double[] gr = new double[input.Length - 1];
                for (int i = 1; i < input.Length; i++)
                {
                    gr[i - 1] = double.Parse(input[i]);
                }
                Student st = new Student(input[0], gr, gr.Average());
                students.Add(st);
            }

            foreach (var item in students.Where(x => x.AverageGrade >= 5.0).OrderBy(y => y.Name).ThenByDescending(z => z.AverageGrade))
            {
                Console.WriteLine($"{item.Name} -> {item.AverageGrade:f2}");
            }
            
        }
    }

    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade { get; set; }

        public Student(string n, double[] gr, double average)
        {
            Name = n;
            Grades = gr;
            AverageGrade = average;
        }
    }
}
